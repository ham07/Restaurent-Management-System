using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
namespace rmsDB
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if(!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\rms_connect"))
            {
                Settings obj = new Settings();
                MainClass.showWindow(obj,this);
            }
            else
            {
                Login l = new Login();
                MainClass.showWindow(l, this);
            }
          
        }

     

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            MainClass.showWindow(obj, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            MainClass.showWindow(obj, this);
        }
    }
}
