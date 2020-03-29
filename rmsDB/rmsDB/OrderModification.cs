using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rmsDB
{
    public partial class OrderModification : Sample2
    {
        public OrderModification()
        {
            InitializeComponent();
        }

     
        private void OrderModification_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            retrival.geOrderIDWRTDate(date.Value, orderIDCB);
            retrival.geOrderIDWRTDate(date.Value,null, orderIDlistBox);
            // orderIDCB.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            retrival.loadItems("st_getMenu", itemCB, "Menu Item", "Menu ID");
           

        }

   
        private void date_ValueChanged(object sender, EventArgs e)
        {
            retrival.geOrderIDWRTDate(date.Value, orderIDCB);
            retrival.geOrderIDWRTDate(date.Value, null, orderIDlistBox);
            dataGridView1.DataSource = null;
        }

        private void getOrderDetails(Int64 orderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderDetailWRTOrderID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
              
                ItemIDGV.DataPropertyName = dt.Columns["Item ID"].ToString();
                ItemGV.DataPropertyName = dt.Columns["Item"].ToString();
                quanGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                perItemPriceGV.DataPropertyName = dt.Columns["PUP"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                orderIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        private void orderIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(orderIDCB.SelectedIndex !=-1)
            {

               // DataRowView drv = orderIDCB.SelectedItem as DataRowView;
               // getOrderDetails(Convert.ToInt64(drv[0].ToString()));
            }
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

        }

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
              
                DataRowView drvItem = itemCB.SelectedItem as DataRowView;

                float totAmon = 0;
                if (check)
                {
                    MainClass.showMessage("Item already exist", "Error", "Error");
                }
                else
                {
         
                  

                        totAmon += Convert.ToSingle(priceTxt.Text) * Convert.ToSingle(quantiNum.Value);
                        txt.Text = totAmon.ToString();
                    DataRowView drv = orderIDCB.SelectedItem as DataRowView;
                    DataRowView drv2 = itemCB.SelectedItem as DataRowView;
                        dataGridView1.Rows.Add(null, Convert.ToInt64(drv[0].ToString()),Convert.ToInt64(itemCB.SelectedValue.ToString()), drv2[1].ToString(),Convert.ToDouble(priceTxt.Text),quantiNum.Value,Convert.ToDouble(priceTxt.Text)*Convert.ToInt32(quantiNum.Value));
                    
                }


            }

        }

       private double orderAmount(Int64 orderID)
        {
            double om = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getAmountWRTOrderID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@orderID",orderID);
                MainClass.con.Open();
                om = Convert.ToDouble(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
             
            }
            catch(Exception ex)

            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
            return om;
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            Orders.insertOrderDetails(Convert.ToInt64(orderIDCB.SelectedValue.ToString()), dataGridView1);
            double total = Convert.ToDouble(txt.Text) +orderAmount(Convert.ToInt64(orderIDCB.SelectedValue.ToString()));
            updation.updateOrderAmount(Convert.ToInt64(orderIDCB.SelectedValue.ToString()),total);
        }
    }
}
