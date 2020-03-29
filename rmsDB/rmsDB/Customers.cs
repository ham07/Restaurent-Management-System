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
    public partial class Customers : Sample2
    {
        public Customers()
        {
            InitializeComponent();
        }

        insertions i = new insertions();
        retrival r = new retrival();
        updation u = new updation();
        Int64 custID;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                if (edit == 0)//save code
                {
                    // i.insertUsers(nameTxt.Text,userTxt.Text,phoneTxt.Text,addressTxt.Text,passTxt.Text,Convert.ToInt16(roleCB.SelectedValue.ToString()));
                    i.insertCustomers(nameTxt.Text,  phoneTxt.Text, addressTxt.Text);
                    MainClass.disable_reset(leftpanel);
                    r.showCustomers(dataGridView1,custIDGV,nameGV,phoneGV,addressGV);
                }
                else if (edit == 1)// update code
                {
                    u.updateCustomers(custID, nameTxt.Text, phoneTxt.Text, addressTxt.Text);
                    MainClass.disable_reset(leftpanel);
                    r.showCustomers(dataGridView1, custIDGV, nameGV, phoneGV, addressGV);
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
                    d.deleteData("st_deleteCustomer", "@cID", 0,custID);
                    MainClass.disable_reset(leftpanel);
                    r.showCustomers(dataGridView1, custIDGV, nameGV, phoneGV, addressGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCustomers(dataGridView1, custIDGV, nameGV, phoneGV, addressGV);
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text =="") { nameTxt.BackColor = Color.Firebrick; } else { nameTxt.BackColor = Color.White; }
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "") { phoneTxt.BackColor = Color.Firebrick; } else { phoneTxt.BackColor = Color.White; }
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (addressTxt.Text == "") { addressTxt.BackColor = Color.Firebrick; } else { addressTxt.BackColor = Color.White; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.disable(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                custID = Convert.ToInt64(row.Cells["custIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["nameGV"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
            }
        }
    }
}
