using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpMinimize
{
    /// <summary>
    /// A collection of scripts
    /// </summary>
    public class ScriptCollection
    {
        private List<Script> scripts = new List<Script>();
        public List<Script> Scripts
        {
            get { return scripts; }
        }

        public Script CreateScript(string Name)
        {
            Script s = new Script(Name);
            scripts.Add(s);
            return s;
        }
    }

    /// <summary>
    /// A script that contains hosts and commands
    /// </summary>
    public class Script
    {
        public string Name { get; set; }
        private List<Host> hosts;
        public List<Host> Hosts { get { return hosts; } }
        
        public string[] Commands;
        public Script(string name)
        {
            Name = name;
            hosts = new List<Host>();
        }

        public void AddHost(Host host)
        {
            hosts.Add(host);
        }
        
        public override string ToString()
        {
            return Name;
        }
    }

    /// <summary>
    /// A host
    /// </summary>
    public class Host
    {
        private string name;

        /// <summary>
        /// The name of the host. If no name is set, the IP will be returned when read
        /// </summary>
        public string Name
        {
            get { return String.IsNullOrWhiteSpace(name) ? ip : name; }
            set { name = value; }
        }

        private string ip;

        public string IP
        {
            get { return ip; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    ip = value;
                else
                    throw new NoValueException();
            }
        }

        public Host(string IP)
        {
            this.IP = IP;
        }
        public Host(string IP, string Name)
            : this(IP)
        {
            this.Name = Name;
        }

        public bool Equals(Host other)
        {
            return other != null && other.ip == this.ip;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Host p = obj as Host;

            if (p == null)
                return false;

            return (ip == p.ip);
        }
        public override int GetHashCode()
        {
            return ip.GetHashCode();
        }
    }

    public class NoValueException : Exception
    {
        public NoValueException() : base("Value can not be empty") { }
    }
}