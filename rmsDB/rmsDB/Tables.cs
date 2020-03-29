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
    public partial class Tables : Sample2
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            retrival.loadItems("st_getFloors",FloorCB, "Floor","ID");
            FloorCB.SelectedIndex = -1;

       }
        insertions i = new insertions();
        retrival r = new retrival();
        updation u = new updation();
        int TabelID;
    

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count == 0)
            {
                if (edit == 0)//save code
                {
                    // i.insertUsers(nameTxt.Text,userTxt.Text,phoneTxt.Text,addressTxt.Text,passTxt.Text,Convert.ToInt16(roleCB.SelectedValue.ToString()));
                    i.insertTables(Convert.ToInt32(comboBox1.SelectedItem.ToString()),Convert.ToInt16(NOchairCB.SelectedItem.ToString()),Convert.ToInt16(FloorCB.SelectedValue.ToString()));
                    MainClass.disable_reset(leftpanel);
                    r.showTables(dataGridView1, tablenumGV, nameGV, floorIDGV,tableidGV, ChairsGV);
                }
                else if (edit == 1)// update code
                {
                    u.updateTables(TabelID, Convert.ToInt32(comboBox1.SelectedItem.ToString()), Convert.ToInt16(NOchairCB.SelectedItem.ToString()), Convert.ToInt16(FloorCB.SelectedValue.ToString()));
                    MainClass.disable_reset(leftpanel);
                    r.showTables(dataGridView1, tablenumGV, nameGV, floorIDGV, tableidGV, ChairsGV);
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
                    d.deleteData("st_deleteTables", "@tableID", TabelID);
                    MainClass.disable_reset(leftpanel);
                    r.showTables(dataGridView1, tablenumGV, nameGV, floorIDGV, tableidGV, ChairsGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showTables(dataGridView1, tablenumGV, nameGV, floorIDGV, tableidGV, ChairsGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.disable(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                TabelID = Convert.ToInt32(row.Cells["tableidGV"].Value.ToString());
                comboBox1.SelectedItem = row.Cells["tablenumGV"].Value.ToString();
                NOchairCB.SelectedItem = row.Cells["ChairsGV"].Value.ToString();
                FloorCB.SelectedValue= row.Cells["floorIDGV"].Value.ToString();
            }
        }
    }
}
