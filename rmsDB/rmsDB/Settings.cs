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
using System.Xml;
using System.IO;

namespace rmsDB
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void serverTxt_TextChanged(object sender, EventArgs e)
        {
            if (serverTxt.Text == "") { serverlabel.Visible = true; } else { serverlabel.Visible = false; }

        }

        private void databaseTxt_TextChanged(object sender, EventArgs e)
        {
            if (databaseTxt.Text == "") { databaselabel.Visible = true; } else { databaselabel.Visible = false; }

        }


        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if (CB.Checked)
            {
                if (userTxt.Text == "") { usrlabel.Visible = true; } else { usrlabel.Visible = false; }
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (CB.Checked)
            {
                if (passwordTxt.Text == "") { passlabel.Visible = true; } else { passlabel.Visible = false; }
            }
        }

        //public void updateConfigFile(string con)
        //{
        //    //updating config file
        //    XmlDocument XmlDoc = new XmlDocument();
        //    //loading the Config File
        //    XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        //    foreach(XmlElement xElement in XmlDoc.DocumentElement)
        //    {
        //        if(xElement.Name == "connectionStrings")
        //        {
        //            //setting the connection string
        //            xElement.FirstChild.Attributes[2].Value = con;
        //        }
        //    }
        //    //writing the connection string in config file
        //    XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        //    ConfigurationManager.RefreshSection("connectionStrings");
        //}

        string connection;
        private void saveConnection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\rms_connect";
            File.WriteAllText(path,connection);
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(CB.Checked)
            {
                if (serverTxt.Text == "") { serverlabel.Visible = true; } else { serverlabel.Visible = false; }
                if (databaseTxt.Text == "") { databaselabel.Visible = true; } else { databaselabel.Visible = false; }

                if (serverlabel.Visible || databaselabel.Visible)
                {
                    MainClass.showMessage("Feilds with * are Mandatory", "Error","Error");
                }
                else
                {

                    connection = "Data Source=" + serverTxt.Text + ";Database=" + databaseTxt.Text + ";Integrated Security = true;MultipleActiveResultSets=true;";
                    saveConnection();
                    DialogResult dr = MessageBox.Show("Settings saved Succesfully");
                    if(dr == DialogResult.OK)
                    {
                        Login ls = new Login();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);
                    }
             
                }
            }
           
            else
            {
                if (serverTxt.Text == "") { serverlabel.Visible = true; } else { serverlabel.Visible = false; }
                if (databaseTxt.Text == "") { databaselabel.Visible = true; } else { databaselabel.Visible = false; }
                if (userTxt.Text == "") { usrlabel.Visible = true; } else { usrlabel.Visible = false; }
                if (passwordTxt.Text == "") { passlabel.Visible = true; } else { passlabel.Visible = false; }

                if (serverlabel.Visible || databaselabel.Visible ||usrlabel.Visible || passlabel.Visible)
                {
                    MainClass.showMessage("Feilds with * are Mandatory", "Error", "Error");
                }
                else
                {
                    connection = "Data Source=" + serverTxt.Text + ";Database=" + databaseTxt.Text + ";User ID ="+userTxt.Text+";Password="+passwordTxt.Text+"; MultipleActiveResultSets=true;";
                    saveConnection();
                    DialogResult dr = MessageBox.Show("Settings saved Succesfully");
                    if (dr == DialogResult.OK)
                    {
                        Login ls = new Login();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);
                    }

                }
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CB.Checked)
            {
                usrlabel.Visible = false;
                passlabel.Visible = false;
                passwordTxt.Enabled = false;
                userTxt.Enabled = false;
                userTxt.Text = "";
                passwordTxt.Text = "";

            }
            else
            {
                userTxt.Enabled = true;
                passwordTxt.Enabled = true;
            }
        }

    }
}
