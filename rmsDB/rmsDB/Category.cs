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
    public partial class Category : Sample2
    {
        public Category()
        {
            InitializeComponent();
        }

        insertions i = new insertions();
        retrival r = new retrival();
        updation u = new updation();
        int catID;
        private void categoryTxt_TextChanged(object sender, EventArgs e)
        {
            if (categoryTxt.Text=="") { categoryTxt.BackColor = Color.Firebrick; } else {categoryTxt.BackColor=Color.White; }
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                if (edit == 0)//save code
                {
                    // i.insertUsers(nameTxt.Text,userTxt.Text,phoneTxt.Text,addressTxt.Text,passTxt.Text,Convert.ToInt16(roleCB.SelectedValue.ToString()));
                    i.insertCategory (categoryTxt.Text);
                    MainClass.disable_reset(leftpanel);
                    r.showCategories(dataGridView1, catIDGV, CatnameGV);
                }
                else if (edit == 1)// update code
                {
                    u.updateCategory(catID, categoryTxt.Text);
                    MainClass.disable_reset(leftpanel);
                    r.showCategories(dataGridView1, catIDGV, CatnameGV);
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
                    d.deleteData("st_deleteCategory", "@id",catID);
                    MainClass.disable_reset(leftpanel);
                    r.showCategories(dataGridView1, catIDGV, CatnameGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, catIDGV, CatnameGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.disable(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                categoryTxt.Text = row.Cells["CatnameGV"].Value.ToString();
              
            }
        }
    }
}
