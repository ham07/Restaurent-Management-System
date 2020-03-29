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
    public partial class Roless : Sample2
    {
        public Roless()
        {
            InitializeComponent();
        }

        int edit = 0,delStatus=0;
       

      
        insertions i = new insertions();
        retrival r = new retrival();
        updation u = new updation();
        
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (rolesTxt.Text =="") { rolesErrorlabel.Visible = true; } else { rolesErrorlabel.Visible = false; }
            if(rolesErrorlabel.Visible)
            {
                MainClass.showMessage("feilds * are mandotory","Error","Error");
            }
            else
            {
                if(edit ==0)//for save operation
                {
                    i.insertRoles(rolesTxt.Text);
                    MainClass.disable_reset(leftpanel);
                    r.showRoles(dataGridView1, rolesIDGV, rolesGV);

                }
                else if(edit==1)//for update operation
                {
                    u.updateRoles(rolesTxt.Text,roleID);
                    MainClass.disable_reset(leftpanel);
                    r.showRoles(dataGridView1, rolesIDGV, rolesGV);

                }
            }
        }

       
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if(delStatus==1)
            {
                
                DialogResult dr = MessageBox.Show("are you sure you want to delete this record","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    deletions d = new deletions();
                    d.deleteData("st_deleteRole", "@rid", roleID);
                    MainClass.disable_reset(leftpanel);
                    r.showRoles(dataGridView1, rolesIDGV, rolesGV);
                }
            }

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showRoles(dataGridView1, rolesIDGV, rolesGV);
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        Int16 roleID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1 && e.ColumnIndex !=-1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.disable(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt16(row.Cells["rolesIDGV"].Value.ToString());
                rolesTxt.Text = row.Cells["rolesGV"].Value.ToString();

            }
        }

        private void rolesTxt_TextChanged_1(object sender, EventArgs e)
        {
            if (rolesTxt.Text == "") { rolesErrorlabel.Visible = true; } else { rolesErrorlabel.Visible = false; }
        }
    }
}
