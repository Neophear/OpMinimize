using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Renci.SshNet;

namespace OpMinimize
{
    public partial class Form1 : Form
    {
        SSHCOM scom = new SSHCOM();
        ScriptCollection scol = new ScriptCollection();

        public Form1()
        {
            InitializeComponent();

            Script script = scol.CreateScript("Script 1");
            script.AddHost(new Host("10.255.10.2"));
            script.Commands = new string[] { "conf t", "int gi1/0/8", "shu", "end", "wri"};

            Script script2 = scol.CreateScript("Script 2");
            script2.AddHost(new Host("10.255.10.2", "CIS Center"));
            script2.Commands = new string[] { "conf t", "int gi1/0/8", "shu", "end", "wri"};

            lstbxScripts.DataSource = scol.Scripts;
        }

        private void btnOPM_Click(object sender, EventArgs e)
        {
            foreach (Script script in scol.Scripts)
            {
                WriteOutput("---Running script: {0}", script.Name);

                foreach (Host host in script.Hosts)
                {
                    try
                    {
                        using (SshClient client = new SshClient(host.IP, txtUsername.Text, txtPassword.Text))
                        {
                            WriteOutput("{0}Connecting to {1}...", Environment.NewLine, host.Name);
                            client.Connect();

                            if (client.IsConnected)
                            {
                                WriteOutput("Connected!");

                                using (ShellStream ss = client.CreateShellStream("dumb", 80, 24, 800, 600, 1024))
                                {
                                    WriteOutput(scom.ReadToEnd(ss));
                                    foreach (string c in script.Commands)
                                        WriteOutput(scom.SendCommandCR(c, ss));
                                }

                                client.Disconnect();
                                WriteOutput("Disconnected!\n");
                            }
                            else
                                WriteOutput("Connection failed!");
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteOutput("CAUGHT: " + ex.ToString());
                    }
                    finally
                    {
                        WriteOutput("\n\n");
                    }
                }
            }
        }
        
        private void WriteOutput(string format, params object[] args)
        {
            txtOutput.AppendText(String.Format(format, args));
        }

        private void lstbxScripts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstbxScripts.SelectedIndex != -1)
                OpenScriptFrom((Script)lstbxScripts.SelectedItem);
        }

        private void OpenScriptFrom(Script script)
        {
            frmScript returnForm = Application.OpenForms.OfType<frmScript>().SingleOrDefault<frmScript>(x => x.script == script);
            if (returnForm == null)
                returnForm = new frmScript(script);

            returnForm.Show();
            returnForm.Focus();
        }
    }
}