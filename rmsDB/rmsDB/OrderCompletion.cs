using CrystalDecisions.CrystalReports.Engine;
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
    public partial class OrderCompletion : Sample
    {
        public OrderCompletion()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        int chk = 0;
        private void OrderCompletion_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            retrival.loadItems("st_getFloors", floorCB, "Floor", "ID");
            retrival.loadItems("st_getTax", taxCB, "Type", "Value");
            floorCB.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            billLabel.Text = "";
            orderIDTxt.Text = "";

        }

        private void floorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (floorCB.SelectedIndex != -1)
            {
                retrival.loadItems("st_getTablesWRTFloor", tableCB, "Table Number", "Table ID", "@floorID", Convert.ToInt32(floorCB.SelectedValue.ToString()));
                tableCB.SelectedIndex = -1;
                dataGridView1.DataSource = null;
                billLabel.Text = "";
                orderIDTxt.Text = "";
            }
            else
            {

            }
        }

        float taxAmount = 0;
        private void tableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableCB.SelectedIndex != -1)
           
            {
                if (chk != 0)
                {
                  if (retrival.getOrderBill(Convert.ToInt32(tableCB.SelectedValue.ToString()), dataGridView1, orderIDGV, itemGV, quanGV, amountGV, grossGV))
                  {
                        float amount = 0;

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            amount += (float)Math.Round(Convert.ToDouble(row.Cells["amountGV"].Value.ToString()), 0);
                        }
                   
                 
                    float per = Convert.ToSingle(taxCB.SelectedValue.ToString()) / 100;
                     taxAmount = amount * per;
                    DataRowView drv = taxCB.SelectedItem as DataRowView;
                    if (drv["Type"].ToString() == "Inclusive")
                    {

                    }
                    else if (drv["Type"].ToString() == "Exclusive")
                    {
                        amount += taxAmount;
                    }

                    billLabel.Text = amount.ToString();
                    orderIDTxt.Text = dataGridView1.Rows[0].Cells["orderIDGV"].Value.ToString();
                    amouPaidTxt.Text = "";
                    amounRetTxt.Text = "";
                  }
                }

            }

        }

        private void tableCB_Enter(object sender, EventArgs e)
        {
            chk = 1;
        }

        private void amouPaidTxt_TextChanged(object sender, EventArgs e)
        {
            if (amouPaidTxt.Text == "")
            {
                amouPaidTxt.BackColor = Color.Firebrick;
            }
            else
            {
                amouPaidTxt.BackColor = Color.White;
                if (Convert.ToDouble(amouPaidTxt.Text) > Convert.ToDouble(billLabel.Text))
                {
                    double amtPaid = Convert.ToDouble(amouPaidTxt.Text);
                    double amtRet = amtPaid - Convert.ToDouble(billLabel.Text);
                    amounRetTxt.Text = amtRet.ToString();
                }
            }
        }

        ReportDocument rd;
        private void BillBtn_Click(object sender, EventArgs e)
        {
            if(orderTypeCB.SelectedIndex==0)
            {
                if (amounRetTxt.Text != "" && taxCB.SelectedIndex != -1 && floorCB.SelectedIndex != -1 && tableCB.SelectedIndex != -1)
                {
                    int chk = updation.updateOrder(Convert.ToInt64(orderIDTxt.Text), Convert.ToSingle(amouPaidTxt.Text), Convert.ToSingle(amounRetTxt.Text), 2, taxID, taxAmount);
                    if (chk > 0)
                    {
                        DialogResult dr = MessageBox.Show("Order Completed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            rd = new ReportDocument();
                           
                           retrival.loadBillReport(rd, crystalReportViewer1, 2,Convert.ToInt64(orderIDTxt.Text.ToString()));
                            
                        }
                    }
                }
            }

            else
            {
                if (amounRetTxt.Text != "" && taxCB.SelectedIndex != -1 && phoneTxt.Text !="")
                {
                    int chk = updation.updateOrder(Convert.ToInt64(orderIDTxt.Text), Convert.ToSingle(amouPaidTxt.Text), Convert.ToSingle(amounRetTxt.Text), 2, taxID, taxAmount);
                    if (chk > 0)
                    {
                        DialogResult dr = MessageBox.Show("Order Completed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            rd = new ReportDocument();

                            retrival.loadBillReport(rd, crystalReportViewer1, 2, Convert.ToInt64(orderIDTxt.Text.ToString()));

                        }
                    }
                }
          
            }
        }

        private void orderTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderTypeCB.SelectedIndex != -1)
            {
                if (orderTypeCB.SelectedIndex == 0)
                {
                    floorCB.Enabled = true;
                    tableCB.Enabled = true;
                    phoneLabel.Visible = false;
                    phoneTxt.Visible = false;
                    floorCB.Visible = true;
                    tableCB.Visible = true;
                    floorLabel.Visible = true;
                    tableCB.Visible = true;
                }
                else
                {
                    floorCB.Enabled = false;
                    tableCB.Enabled = false;
                    phoneTxt.Visible = true;
                    phoneLabel.Visible = true;
                    floorCB.Visible = false;
                    floorLabel.Visible = false;
                    tableCB.Visible = false;
                    tabelLabel.Visible = false;
                }
            }
        }


        private void phoneTxt_Leave(object sender, EventArgs e)
        {
            if (phoneTxt.Text !="")
            {
                retrival.getOrderBill(phoneTxt.Text, dataGridView1, orderIDGV, itemGV, quanGV, amountGV, grossGV);
                float amount = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    amount += (float)Math.Round(Convert.ToDouble(dataGridView1.Rows[0].Cells["grossGV"].Value.ToString()), 0);
                }
               // double amoun = Math.Round(Convert.ToDouble(dataGridView1.Rows[0].Cells["grossGV"].Value.ToString()), 0);
                double per = Convert.ToDouble(taxCB.SelectedValue.ToString()) / 100;
                double taxAmount = amount * per;
                DataRowView drv = taxCB.SelectedItem as DataRowView;
                if (drv["Type"].ToString() == "Inclusive")
                {

                }
                else if (drv["Type"].ToString() == "Exclusive")
                {
                 //   amount += taxAmount;
                }

                billLabel.Text = amount.ToString();
                orderIDTxt.Text = dataGridView1.Rows[0].Cells["orderIDGV"].Value.ToString();
            }
        }

        Int16 taxID=0;
        private void taxCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(taxCB.SelectedIndex !=-1)
            {
                DataRowView drv = taxCB.SelectedItem as DataRowView;
               taxID= retrival.getTaxID(drv["Type"].ToString());
            }
        }

        private void OrderCompletion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(rd !=null)
            {
                rd.Close();
            }
        }
    }

}
