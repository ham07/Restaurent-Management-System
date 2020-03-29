using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rmsDB
{
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                if (retrival.getUserDetails(usrTxt.Text, passTxt.Text))
                {
                    if(retrival.ROLE== "Administrator")
                    {
                        HomeScreen obj = new HomeScreen();
                        MainClass.showWindow(obj, this, MDI.ActiveForm);
                    }
                    else if(retrival.ROLE == "Chef")
                    {
                        HomeScreen2 obj = new HomeScreen2();
                        MainClass.showWindow(obj, this, MDI.ActiveForm);
                    }
                  
                }
                else
                {

                }

            }
        }




        private void usrTxt_TextChanged(object sender, EventArgs e)
        {
            if (usrTxt.Text == "") { usrTxt.BackColor = Color.Firebrick; } else { usrTxt.BackColor = Color.White; }
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            if (passTxt.Text == "") { passTxt.BackColor = Color.Firebrick; } else { passTxt.BackColor = Color.White; }
        }
    }
}

