using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace rmsDB
{
    class retrival
    {
        private static string customer, address;
        public static string Customer
        {
            get
            {
                return customer;
            }
           private  set
            {
                customer = value;
            }

          
        }

        public static string Address
        {
            get
            {
                return address;
            }
            private set
            {
                address = value;
            }


        }
        public static Int64 getCustomerWRTphone(string phone)
        {
            Int64 custID = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCustomerWRTphone", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        custID = Convert.ToInt64(dr["CustomerID"].ToString());
                        Customer = dr["Name"].ToString();
                        Address = dr["Address"].ToString();
                    }

                }
                else
                {
                    custID = 0;
                    Customer = "";
                    Address = "";

                }
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
            return custID;
        }

        public void showRoles(DataGridView gv, DataGridViewColumn rolesIDGV, DataGridViewColumn roleNameGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rolesIDGV.DataPropertyName = dt.Columns["RolesID"].ToString();
                roleNameGV.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;

                MainClass.sno(gv, "srnoGV");
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static void loadItems(string proc,ComboBox cb,string dMember,string vMember,string param=null,int val =0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param ==null && val ==0)
                {

                }
                else
                {
                    cmd.Parameters.AddWithValue(param,val);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember =dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;
                


            }
            catch(Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static void loadItems(string proc, ListBox cb, string dMember, string vMember, string param = null, int val = 0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param == null && val == 0)
                {

                }
                else
                {
                    cmd.Parameters.AddWithValue(param, val);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;



            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

       private static int catID;
        private static string catName;

        public static int CategoryID
        {
            get
            {
                return catID;
            }
           private set
            {
                catID = value;
            }
        }
        public static string CatName
        {
            get
            {
                return catName;
            }
            private set
            {
                catName = value;
            }
        }

        public static void loadCategoryWRTitem(string item)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategoryWRTitem", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",item);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        CategoryID = Convert.ToInt32(dr[0].ToString());
                        CatName = dr[1].ToString();
                    }
                }
                MainClass.con.Close();



            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static Int64 loadLastOrderID()
        {
            Int64 orderID=0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLastOrderID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                orderID = Convert.ToInt64(cmd.ExecuteScalar().ToString());
             
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
            return orderID;
        }

        public static bool checkTableStatus(int tableID,Int64 floorID)
        {
            bool stats = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkTableBusyFree", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableID",tableID);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    stats = true;
                }
                else
                {
                    stats = false;
                }
                MainClass.con.Close();
            }
            catch(Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
            return stats;
        }

        public void showUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn userGV, DataGridViewColumn userNameGV, DataGridViewColumn passGV, DataGridViewColumn phoneGV, DataGridViewColumn addressGV, DataGridViewColumn roleIDGV, DataGridViewColumn roleNameGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["User ID"].ToString();
                userGV.DataPropertyName = dt.Columns["User"].ToString();
                userNameGV.DataPropertyName = dt.Columns["UserName"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                roleIDGV.DataPropertyName = dt.Columns["Role ID"].ToString();
                roleNameGV.DataPropertyName = dt.Columns["Role"].ToString();


                gv.DataSource = dt;
                MainClass.sno(gv, "srnoGV");
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void showCustomers(DataGridView gv, DataGridViewColumn custIDGV, DataGridViewColumn nameGV,  DataGridViewColumn phoneGV, DataGridViewColumn addressGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCustomer", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                custIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Customers"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();



                gv.DataSource = dt;
                MainClass.sno(gv, "srnoGV");
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void showFloors(DataGridView gv, DataGridViewColumn floorIDGV, DataGridViewColumn nameGV, DataGridViewColumn floornumGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getFloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                floorIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Floor"].ToString();
                floornumGV.DataPropertyName = dt.Columns["Floor number"].ToString();
    



                gv.DataSource = dt;
                MainClass.sno(gv, "srnoGV");
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void showTables(DataGridView gv, DataGridViewColumn tablenumGV, DataGridViewColumn floornameGV, DataGridViewColumn floorIDGV, DataGridViewColumn tableIDGV, DataGridViewColumn chairsGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                floorIDGV.DataPropertyName = dt.Columns["Floor ID"].ToString();
                tableIDGV.DataPropertyName = dt.Columns["Table ID"].ToString();
                chairsGV.DataPropertyName = dt.Columns["Chairs"].ToString();
                tablenumGV.DataPropertyName = dt.Columns["Table Number"].ToString();
                floornameGV.DataPropertyName = dt.Columns["Floor"].ToString();
              




                gv.DataSource = dt;
                MainClass.sno(gv, "srnoGV");
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                gv.DataSource = dt;

                MainClass.sno(gv, "srnoGV");
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void showMenu(DataGridView gv, DataGridViewColumn menuIDGV, DataGridViewColumn menuNameGV, DataGridViewColumn priceGV, DataGridViewColumn status, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getMenu", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                menuIDGV.DataPropertyName = dt.Columns["Menu ID"].ToString();
                menuNameGV.DataPropertyName = dt.Columns["Menu Item"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                status.DataPropertyName = dt.Columns["Status"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();

                gv.DataSource = dt;

                MainClass.sno(gv, "srnoGV");
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static void getPendingOrder(DataGridView gv,DataGridViewColumn orderIDGV, DataGridViewColumn status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderForChef", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderIDGV.DataPropertyName = dt.Columns["Order ID"].ToString();
                status.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static void getPendingOrderDetails(Int64 orderID,DataGridView gv, DataGridViewColumn proGV, DataGridViewColumn quanGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderDetailForChef", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proGV.DataPropertyName = dt.Columns["Item"].ToString();
                quanGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static Image getItemImage(int mid)
        {
            byte[] arr;
            Image i=null;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getItemImage", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid",mid);
                MainClass.con.Open();
                arr = (byte[])cmd.ExecuteScalar();
                MemoryStream ms = new MemoryStream(arr);
                 i = Image.FromStream(ms);
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
            return i;
        }

        public static bool getOrderBill(int tableID,DataGridView gv,DataGridViewColumn orderID, DataGridViewColumn itemGV, DataGridViewColumn quanGV, DataGridViewColumn amounGV, DataGridViewColumn grosstotGV)
        {
            bool check = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderDetailWRTTable", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableID", tableID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderID.DataPropertyName = dt.Columns["ID"].ToString();
                itemGV.DataPropertyName = dt.Columns["Item"].ToString();
                quanGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                amounGV.DataPropertyName = dt.Columns["Price"].ToString();
                grosstotGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                

                gv.DataSource = dt;
                if(gv.Rows.Count>0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
            return check;
        }

        public static void getOrderBill(string phone, DataGridView gv, DataGridViewColumn orderID, DataGridViewColumn itemGV, DataGridViewColumn quanGV, DataGridViewColumn amounGV, DataGridViewColumn grosstotGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrdersDetailsWRTphone", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderID.DataPropertyName = dt.Columns["ID"].ToString();
                itemGV.DataPropertyName = dt.Columns["Item"].ToString();
                quanGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                amounGV.DataPropertyName = dt.Columns["Price"].ToString();
                grosstotGV.DataPropertyName = dt.Columns["Total Amount"].ToString();


                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static void showTax(DataGridView gv, DataGridViewColumn taxIDGV,  DataGridViewColumn taxTypeGV, DataGridViewColumn taxValueGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getTax", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                taxIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                taxTypeGV.DataPropertyName = dt.Columns["Type"].ToString();
                taxValueGV.DataPropertyName = dt.Columns["Value"].ToString();
            
              


                gv.DataSource = dt;
                MainClass.sno(gv, "srnoGV");
            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static void loadBillReport(ReportDocument rd,CrystalReportViewer crv,Int16 status,Int64 orderid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderReport", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
               
                
                    cmd.Parameters.AddWithValue("@orderID", orderid);
                    cmd.Parameters.AddWithValue("@status", status);
             
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\billReport.rpt");
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();

            }
            catch (Exception ex)
            {
                if(rd !=null)
                {
                    rd.Close();
                }
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static void geOrderIDWRTDate(DateTime date, ComboBox cb=null, ListBox lb=null)
        {
            
            try
            {
               // cb.Items.Clear();
                SqlCommand cmd = new SqlCommand("st_getOrderWRTDate", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = "ID";
                cb.ValueMember = "ID";
                if(cb == null)
                {
                    lb.DataSource = dt;
                }
                else if(lb == null)
                {
                    cb.DataSource = dt;
                }
                cb.SelectedIndex = -1;
              


            }
            catch (Exception ex)
            {
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static Int16 getTaxID(string taxtype)
        {
            Int16 id = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getTaxID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@taxtype", taxtype);
                MainClass.con.Open();
                id = Convert.ToInt16(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
            return id;
        }

        private static string name;
        private static string role;
        //for login
        public static string USER
        {
            get
            {
                return name;
            }
           private  set
            {
                name = value;
            }
        }
        public static string ROLE
        {
            //abstract property
            get
            {
                return role;
            }
            private set
            {
                role = value;
            }
        }
        

        public static bool getUserDetails(string user, string pass)
        {
            bool status=false;
            try
            {
               
                SqlCommand cmd = new SqlCommand("st_getUsersDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                MainClass.con.Open();
                //sql dataAdapter is a two way stream data mugwa bi sakte hai or data dalwa bi sakte hai
                //sql dataReader se sirf data magwate hai
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (user == dr["UserName"].ToString() && pass == dr["Password"].ToString())
                        {
                            USER = dr["User"].ToString();
                            ROLE = dr["Role"].ToString();
                            status = true;
                        }
                        else
                        {
                            MainClass.showMessage("invalid username or password", "Error", "Error");
                            status = false;
                        }
                     
                    }

                }
                else
                {
                    MainClass.showMessage("invalid username or password", "Error", "Error");
                    status = false;
                
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {

                MainClass.showMessage(ex.Message, "Error", "Error");
            }
            return status;
       
        }
    }
}
