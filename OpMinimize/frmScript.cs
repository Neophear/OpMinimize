using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpMinimize
{
    public partial class frmScript : Form
    {
        public Script script;
        public frmScript(Script script)
        {
            InitializeComponent();

            this.script = script;

            txtName.Text = script.Name;
            txtCommands.Lines = script.Commands;
        }
    }
}
