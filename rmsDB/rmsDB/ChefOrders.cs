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
    public partial class ChefOrders : Sample2
    {
        public ChefOrders()
        {
            InitializeComponent();
        }
        public override void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen2 obj = new HomeScreen2();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
           // timer1.Stop();
        }
        private void ChefOrders_Load(object sender, EventArgs e)
        {
            retrival.getPendingOrder(dataGridView1,orderIDGV, StatusGV);
            
            addBtn.Enabled = false;
            editBtn.Enabled = false;
            deleteBtn.Enabled=false;
            viewBtn.Enabled = false;
            
           // timer1.Start();
        }

        Int64 orderID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                orderID = Convert.ToInt64(row.Cells["orderIDGV"].Value.ToString());
                retrival.getPendingOrderDetails(orderID, dataGridView2, productGV, quanGV);
             
                if(e.ColumnIndex == 0)
                {
                    DialogResult dr = MessageBox.Show("Are you Sure?", "Qquestion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(dr ==DialogResult.Yes)
                    {
                        updation.updateOrderStatus(orderID,1);
                        retrival.getPendingOrder(dataGridView1, orderIDGV, StatusGV);
                
                    }
                }
            }
        }

        //int count = 0;
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    count++;
        //    if(count ==60)
        //    {
        //        retrival.getPendingOrder(dataGridView1, orderIDGV, StatusGV);
        //        MainClass.sno(dataGridView1, "snoGV");
        //        count = 0;
        //    }
        //}

        private void ChefOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            //timer1.Stop();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            retrival.getPendingOrder(dataGridView1, orderIDGV, StatusGV);
          

        }
    }
}
