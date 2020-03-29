using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace rmsDB
{
    class insertions
    {
        public void insertRoles(string role)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", role);
                MainClass.con.Open();
                int res=cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if(res>0)
                {
                    MainClass.showMessage(role + "added to the system successfully", "Success", "Success");
                }
               
            }
            //exception handlini
            catch (Exception )
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save role.\nPossible error : \n Role May Exist Already.", "Error", "Error");
            }
        }

        public void insertUsers(string name, string uname, string phone, string address, string pass, Int16 roleID)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@password", pass);

                cmd.Parameters.AddWithValue("@roleID", roleID);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + "added to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }

        }

        public void insertCustomers(string name,  string phone, string address)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCustomer", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + "added to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void insertFloors(string name, Int16 number)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertFloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@floor", name);
                cmd.Parameters.AddWithValue("@floornumber", number);
              
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + "added to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void insertTables(int tablenum,Int16 chairs,Int16 floorid)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableNumber", tablenum);
                cmd.Parameters.AddWithValue("@chairs", chairs);
                cmd.Parameters.AddWithValue("@floorID", floorid);

                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(tablenum + "added to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void insertCategory(string Category)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Category);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(Category + "added to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save role.\nPossible error : \n Role May Exist Already.", "Error", "Error");
            }
        }

        public void insertMenu(string menuItem, float price, int catID,Int64 status,Image im)
        {
            //it is use to catch logical error
            try
            {
                MemoryStream ms = new MemoryStream();
                im.Save(ms, ImageFormat.Jpeg);
                byte[] arr = ms.ToArray();
                SqlCommand cmd = new SqlCommand("st_insertMenu", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", menuItem);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@image", arr);

                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(menuItem + "added to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void insertOrder(DateTime date,Int64 custID,Int16 orderType,Int16 floorID,int tableID,float amouPaid,float amouRet,float totAmou,float groosTot,Int16 status,Int16 taxType,float taxAmoun)
        {
            //it is use to catch logical error
            try
            {
               
                SqlCommand cmd = new SqlCommand("st_insertOrder", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@custID", custID);
                cmd.Parameters.AddWithValue("@orderType", orderType);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                cmd.Parameters.AddWithValue("@tableID", tableID);
                cmd.Parameters.AddWithValue("@amountPaid", amouPaid);
                cmd.Parameters.AddWithValue("@amountReturn", amouRet);
                cmd.Parameters.AddWithValue("@totAmount", totAmou);
                cmd.Parameters.AddWithValue("@grossTot", groosTot);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@taxType", taxType);
                cmd.Parameters.AddWithValue("@taxAmount", taxAmoun);

                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage( "Order Placed to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static int insertOrderDetails(Int64 orderID,int proID,Int16 quan)
        {
            int res = 0;
            //it is use to catch logical error
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertOrderDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
                MainClass.con.Open();
                 res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
        

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
            return res;
        }


        public static void insertTax(string TaxType, float taxValue)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertTax", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", TaxType);
                cmd.Parameters.AddWithValue("@value", taxValue);
            
            
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage( " TAX added to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }
    }
}
