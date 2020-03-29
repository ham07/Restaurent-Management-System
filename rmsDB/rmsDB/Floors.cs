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
    public partial class Floors : Sample2
    {
        public Floors()
        {
            InitializeComponent();
        }
        insertions i = new insertions();
        retrival r = new retrival();
        updation u = new updation();
        Int16 floorID;

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                if (edit == 0)//save code
                {
                    // i.insertUsers(nameTxt.Text,userTxt.Text,phoneTxt.Text,addressTxt.Text,passTxt.Text,Convert.ToInt16(roleCB.SelectedValue.ToString()));
                    i.insertFloors(floorTxt.Text, Convert.ToInt16(floorCB.SelectedItem.ToString()) );
                    MainClass.disable_reset(leftpanel);
                    r.showFloors(dataGridView1, floorIDGV, nameGV, FnumGV);
                }
                else if (edit == 1)// update code
                {
                    u.updateFloors(floorID,floorTxt.Text, Convert.ToInt16(floorCB.SelectedItem.ToString()));
                    MainClass.disable_reset(leftpanel);
                    r.showFloors(dataGridView1, floorIDGV, nameGV, FnumGV);
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
                    d.deleteData("st_deleteFloor", "@floorID",  floorID);
                    MainClass.disable_reset(leftpanel);
                    r.showFloors(dataGridView1, floorIDGV, nameGV, FnumGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showFloors(dataGridView1, floorIDGV, nameGV, FnumGV);
        }

        private void floorTxt_TextChanged(object sender, EventArgs e)
        {
            if (floorTxt.Text == "") { floorTxt.BackColor = Color.Firebrick; } else { floorTxt.BackColor = Color.White; }
        }

        private void floorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (floorCB.SelectedIndex == -1) { floorCB.BackColor = Color.Firebrick; } else { floorCB.BackColor = Color.White; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.disable(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                floorID = Convert.ToInt16(row.Cells["floorIDGV"].Value.ToString());
                floorTxt.Text = row.Cells["nameGV"].Value.ToString();
                floorCB.SelectedItem = row.Cells["FnumGV"].Value.ToString();
            }
        }
    }
}
