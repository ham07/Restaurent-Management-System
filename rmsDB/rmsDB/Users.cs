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
    public partial class Users : Sample2
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            retrival.loadItems("st_getRoles",roleCB,"Role","RoleID");
            roleCB.SelectedIndex = -1;
            
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameTxt.BackColor = Color.Firebrick; } else { nameTxt.BackColor = Color.White; }
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "") { phoneTxt.BackColor = Color.Firebrick; } else { phoneTxt.BackColor = Color.White; }
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (addressTxt.Text == "") { addressTxt.BackColor = Color.Firebrick; } else { addressTxt.BackColor = Color.White; }
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if (userTxt.Text == "") { userTxt.BackColor = Color.Firebrick; } else { userTxt.BackColor = Color.White; }
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            if (passTxt.Text == "") { passTxt.BackColor= Color.Firebrick; } else { passTxt.BackColor = Color.White ; }
        }

        private void roleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleCB.SelectedIndex == -1) { roleCB.BackColor = Color.Firebrick; } else { roleCB.BackColor = Color.Firebrick; }
        }

        insertions i=new insertions();
        retrival r = new retrival();
        updation u = new updation();
        int userID;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count==0)
            {
                if(edit ==0)//save code
                {
                    // i.insertUsers(nameTxt.Text,userTxt.Text,phoneTxt.Text,addressTxt.Text,passTxt.Text,Convert.ToInt16(roleCB.SelectedValue.ToString()));
                    i.insertUsers(nameTxt.Text,userTxt.Text,phoneTxt.Text,addressTxt.Text,passTxt.Text,Convert.ToInt16(roleCB.SelectedIndex.ToString()));
                    MainClass.disable_reset(leftpanel);
                    r.showUsers(dataGridView1,userIDGV,nameGV, usernameGV,passGV,phoneGV,addressGV,rolesIDGV,rolesGV);
                }
                else if(edit ==1)// update code
                {
                    u.updateUsers(userID,nameTxt.Text, userTxt.Text, phoneTxt.Text, addressTxt.Text, passTxt.Text, Convert.ToInt16(roleCB.SelectedIndex.ToString()));
                    MainClass.disable_reset(leftpanel);
                    r.showUsers(dataGridView1, userIDGV,nameGV, usernameGV, passGV, phoneGV, addressGV, rolesIDGV, rolesGV);
                }
              
            }
            else
            {
                MessageBox.Show("Please Enter all require Feilds");
            }
        }

       
      

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1)
            {

                DialogResult dr = MessageBox.Show("are you sure you want to delete this record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletions d = new deletions();
                    d.deleteData("st_deleteUser", "@userID", userID);
                    MainClass.disable_reset(leftpanel);
                    r.showUsers(dataGridView1, userIDGV, nameGV, usernameGV, passGV, phoneGV, addressGV, rolesIDGV, rolesGV);
                }
            }

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, userIDGV,nameGV, usernameGV, passGV, phoneGV, addressGV, rolesIDGV, rolesGV);
        }


        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.disable(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID= Convert.ToInt16(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text= row.Cells["nameGV"].Value.ToString();
                userTxt.Text = row.Cells["usernameGV"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString(); 
                passTxt.Text  = row.Cells["passGV"].Value.ToString(); 
                addressTxt.Text  = row.Cells["addressGV"].Value.ToString();
                roleCB.SelectedValue = row.Cells["rolesIDGV"].Value;



            }
        }
    }
}
