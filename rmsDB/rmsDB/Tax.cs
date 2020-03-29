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
    public partial class Tax : Sample2
    {
        public Tax()
        {
            InitializeComponent();
        }

        Int16 taxID;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                if (edit == 0)//save code
                {
                    insertions.insertTax( CB.SelectedItem.ToString(), Convert.ToSingle(taxTxt.Text));
                    MainClass.disable_reset(leftpanel);
                    retrival.showTax(dataGridView1, taxIDGV, taxtGV,taxvGV);
                }
                else if (edit == 1)// update code
                {
                    updation.updateTax(taxID, Convert.ToSingle(taxTxt.Text), CB.SelectedItem.ToString());
                    MainClass.disable_reset(leftpanel);
                    retrival.showTax(dataGridView1, taxIDGV, taxtGV, taxvGV);
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
                    d.deleteData("st_deleteTax", "@taxID", taxID);
                    MainClass.disable_reset(leftpanel);
                    retrival.showTax(dataGridView1, taxIDGV, taxtGV, taxvGV);
                }
            }

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            retrival.showTax(dataGridView1, taxIDGV, taxtGV, taxvGV);
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.disable(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                taxID = Convert.ToInt16(row.Cells["taxIDGV"].Value.ToString());
                taxTxt.Text = row.Cells["taxvGV"].Value.ToString();
               CB.SelectedItem = row.Cells["taxtGV"].Value;
            }
        }
    }
}
