using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using rmsDB.Properties;
using System.Transactions;

namespace rmsDB
{
    public partial class Orders : Sample2
    {
        public Orders()
        {
            InitializeComponent();
        }



        private void Orders_Load(object sender, EventArgs e)
        {
            retrival.loadItems("st_getMenu", itemlistBox, "Menu Item", "Menu ID");
            retrival.loadItems("st_getMenu", itemCB, "Menu Item", "Menu ID");
            retrival.loadItems("st_getFloors", floorCB, "Floor", "ID");
            floorCB.SelectedIndex = -1;
            itemCB.SelectedIndex = -1;
            floorCB.BackColor = Color.White;
            tableCB.BackColor = Color.White;
            quantiNum.BackColor = Color.White;
        }





        private void itemCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemCB.SelectedIndex != -1)
            {
                try
                {


                    itemCB.BackColor = Color.White;
                    SqlCommand cmd = new SqlCommand("st_getPriceWRTItem", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(itemCB.SelectedValue.ToString()));
                    MainClass.con.Open();
                    priceTxt.Text = Math.Round(Convert.ToDouble(cmd.ExecuteScalar().ToString()), 0).ToString();

                    MainClass.con.Close();
                    Image i = retrival.getItemImage(Convert.ToInt32(itemCB.SelectedValue.ToString()));
                    pictureBox1.Image = i;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    DataRowView drv = itemCB.SelectedItem as DataRowView;
                    retrival.loadCategoryWRTitem(drv["Menu Item"].ToString());

                }
                catch (Exception ex)
                {
                    MainClass.showMessage(ex.Message, "Error", "Error");
                }
            }
            else
            {
                priceTxt.Text = "";
                priceTxt.BackColor = Color.White;
                pictureBox1.Image = Resources.download;
                itemCB.BackColor = Color.Firebrick;
            }
        }

        private void floorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (floorCB.SelectedIndex != -1)
            {
                floorCB.BackColor = Color.White;
                retrival.loadItems("st_getTablesWRTFloor", tableCB, "Table Number", "Table ID", "@floorID", Convert.ToInt32(floorCB.SelectedValue.ToString()));
                tableCB.SelectedIndex = -1;
            }
            else
            {
                floorCB.BackColor = Color.Firebrick;
            }


        }

        private void orderTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderTypeCB.SelectedIndex != -1)
            {
                orderTypeCB.BackColor = Color.White;
                if (orderTypeCB.SelectedIndex == 0)
                {
                    floorCB.Enabled = true;
                    tableCB.Enabled = true;
                    phoneTxt.Visible = false;
                    phoneLabel.Visible = false;
                    floorCB.BackColor = Color.Firebrick;
                    tableCB.BackColor = Color.Firebrick;
                    phoneTxt.BackColor = Color.White;

                }
                else
                {
                    floorCB.Enabled = false;
                    tableCB.Enabled = false;
                    phoneTxt.Visible = true;
                    phoneLabel.Visible = true;
                    floorCB.BackColor = Color.White;
                    tableCB.BackColor = Color.White;
                    phoneTxt.BackColor = Color.Firebrick;
                }
            }
            else
            {
                orderTypeCB.BackColor = Color.Firebrick;
            }
        }

        float totAmon = 0;
        int catID;
        string catName;
        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count != 0)
            {
                MainClass.showMessage("Feilds with red marks are manadotory", "Error", "Error");
            }
            else
            {
                bool check = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ItemIDGV"].Value.ToString() == itemCB.SelectedValue.ToString())

                    {

                        check = true;
                        break;
                    }
                }
                DataRowView drvFloor = floorCB.SelectedItem as DataRowView;
                DataRowView drvTable = tableCB.SelectedItem as DataRowView;
                DataRowView drvItem = itemCB.SelectedItem as DataRowView;


                if (check)
                {
                    MainClass.showMessage("Item already exist", "Error", "Error");
                }
                else
                {
                    catID = retrival.CategoryID;
                    catName = retrival.CatName;
                    if (orderTypeCB.SelectedIndex == 0)
                    {

                        totAmon += Convert.ToSingle(priceTxt.Text) * Convert.ToSingle(quantiNum.Value);
                        txt.Text = totAmon.ToString();

                        dataGridView1.Rows.Add(null, Convert.ToInt32(tableCB.SelectedValue.ToString()),
                            Convert.ToInt32(floorCB.SelectedValue.ToString()),
                           catID, catName,
                            Convert.ToInt32(itemCB.SelectedValue.ToString()),
                            drvItem["Menu Item"],
                            Convert.ToSingle(priceTxt.Text),
                            Convert.ToInt32(quantiNum.Text),
                            Convert.ToSingle(priceTxt.Text) * Convert.ToInt32(quantiNum.Text),
                            orderTypeCB.SelectedItem.ToString(),
                            drvFloor["Floor"],
                            drvTable["Table Number"],
                           null);
                    }
                    else if (orderTypeCB.SelectedIndex == 1 || orderTypeCB.SelectedIndex == 2)
                    {

                        totAmon += Convert.ToSingle(priceTxt.Text) * Convert.ToSingle(quantiNum.Value);
                        txt.Text = totAmon.ToString();

                        dataGridView1.Rows.Add(null, null,
                       null,
                      catID, catName,
                       Convert.ToInt32(itemCB.SelectedValue.ToString()),
                       drvItem["Menu Item"],
                       Convert.ToSingle(priceTxt.Text),
                       Convert.ToInt32(quantiNum.Text),
                        Convert.ToSingle(priceTxt.Text) * Convert.ToInt32(quantiNum.Text),
                       orderTypeCB.SelectedItem.ToString(),
                       null,
                       null,
                       phoneTxt.Text);
                    }
                }


            }

            MainClass.sno(dataGridView1, "snoGV");
        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {
            if (priceTxt.Text == "") { priceTxt.BackColor = Color.Firebrick; } else { priceTxt.BackColor = Color.White; }
        }

        private void tableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableCB.SelectedIndex != -1)
            {
                tableCB.BackColor = Color.White;
                if (retrival.checkTableStatus(Convert.ToInt32(tableCB.SelectedValue.ToString()), Convert.ToInt16(floorCB.SelectedValue.ToString())))
                {
                    tableCB.SelectedIndex = -1;
                }
            }
            else
            {
                tableCB.BackColor = Color.Firebrick;
            }
        }

        Int64 custID;
        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "")
            {
                phoneTxt.BackColor = Color.Firebrick;
                custID = retrival.getCustomerWRTphone(phoneTxt.Text);
                MessageBox.Show(custID.ToString());

            }
            else
            {
                phoneTxt.BackColor = Color.White;
            }
        }

        private void quantiNum_ValueChanged(object sender, EventArgs e)
        {
            if (quantiNum.Value == 0) { quantiNum.BackColor = Color.Firebrick; } else { quantiNum.BackColor = Color.White; }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 14)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    float prc = Convert.ToSingle(row.Cells["priceGV"].Value.ToString())*Convert.ToSingle(quantiNum.Value);
                    totAmon -= prc;
                    txt.Text = totAmon.ToString();
                    dataGridView1.Rows.Remove(row);
                    MainClass.sno(dataGridView1, "snoGV");
                }
            }
        }
        public static void insertOrderDetails(Int64 orderID, DataGridView gv)
        {

            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count += insertions.insertOrderDetails(orderID, Convert.ToInt32(row.Cells["ItemIDGV"].Value.ToString()), Convert.ToInt16(row.Cells["quanGV"].Value.ToString()));
            }
            if (count > 0)
            {
                MainClass.showMessage("order updated Placed", "Success", "Success");
            }
            else
            {
                MainClass.showMessage("order not Placed", "Error", "Error");
            }
        }
        insertions i = new insertions();
        //private void insertOrderDetails()
        //    {
        //    Int64 orderID = retrival.loadLastOrderID();
        //                int count = 0;
        //                foreach(DataGridViewRow row in dataGridView1.Rows)
        //                {
        //                  count+=  insertions.insertOrderDetails(orderID, Convert.ToInt32(row.Cells["ItemIDGV"].Value.ToString()),Convert.ToInt16(row.Cells["quanGV"].Value.ToString()));
        //                }
        //                if (count>0)
        //                {
        //                    MainClass.showMessage("order Placed","Success","Success");
        //                }
        //                else
        //                {
        //                    MainClass.showMessage("order not Placed", "Error", "Error");
        //                }
        //    }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            using (TransactionScope sc = new TransactionScope())
            {
                try
                {
                    if (orderTypeCB.SelectedIndex == 0)
                    {
                        i.insertOrder(DateTime.Today, 1, Convert.ToInt16(orderTypeCB.SelectedIndex), Convert.ToInt16(floorCB.SelectedValue.ToString()),  Convert.ToInt16(tableCB.SelectedValue.ToString()),0, 0,
                           0, Convert.ToSingle(txt.Text) ,0,0,0
                           );
                        insertOrderDetails(retrival.loadLastOrderID(),dataGridView1);


                    }
                    else 
                    {
                        i.insertOrder(DateTime.Today, custID,Convert.ToInt16(orderTypeCB.SelectedIndex),
                           0, 0,  0, 0,0,
                           Convert.ToSingle(txt.Text), 0,0,0
                          );
                        insertOrderDetails(retrival.loadLastOrderID(),dataGridView1);

                    }
                   
                }
                catch (Exception ex)
                {

                }
                sc.Complete();
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void phoneTxt_Leave(object sender, EventArgs e)
        {
            if (phoneTxt.Text != "")
            {
                phoneTxt.BackColor = Color.White;
                custID = retrival.getCustomerWRTphone(phoneTxt.Text);
                if (custID==0)
                {
                    Customers cw = new Customers();
                    MainClass.showWindow(cw, this, MDI.ActiveForm);
                }
                else
                {
                    MainClass.showMessage(retrival.Customer+"\n"+retrival.Address+"\n","Success","Success");
                }
              

            }
        

        }
    }
}

