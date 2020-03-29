using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace rmsDB
{
    class updation
    {
        public void updateRoles(string role, Int16 roleID)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateRoles", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", role);
                cmd.Parameters.AddWithValue("@rid", roleID);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(role + "updated to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void updateUsers(int userID, string name, string uname, string phone, string address, string pass, Int16 roleID)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@roleID", roleID);
                cmd.Parameters.AddWithValue("@userID", userID);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + "updated to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void updateCustomers(Int64 cid, string name, string phone, string address)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCustomer", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cID", cid);
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

        public void updateFloors(Int16 FloorID, string name, Int16 number)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateFloors", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@floor", name);
                cmd.Parameters.AddWithValue("@floornumber", number);
                cmd.Parameters.AddWithValue("@floorID", FloorID);

                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(name + "updated to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void updateTables(int tableID, int tablenum, Int16 chairs, Int16 floorid)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateTables", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableNumber", tablenum);
                cmd.Parameters.AddWithValue("@chairs", chairs);
                cmd.Parameters.AddWithValue("@floorID", floorid);
                cmd.Parameters.AddWithValue("@tableID", tableID);

                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(tablenum + "updated to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public void updateCategory(int id, string Category)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Category);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(Category + "updated to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMessage("Unable to save role.\nPossible error : \n Role May Exist Already.", "Error", "Error");
            }
        }

        public void updateMenu(int menuID, string menuItem, float price, int catID, Int64 status, Image im)
        {
            //it is use to catch logical error
            try
            {
                MemoryStream ms = new MemoryStream();
                im.Save(ms, ImageFormat.Jpeg);
                byte[] arr = ms.ToArray();
                SqlCommand cmd = new SqlCommand("st_updateMenu", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", menuItem);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@mid", menuID);
                cmd.Parameters.AddWithValue("@image", arr);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(menuItem + "updated to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static int updateOrder(Int64 orderID,  float amouPaid, float amouRet, Int16 status, Int16 taxType, float taxAmoun)
        {
            int res = 0;
            //it is use to catch logical error
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateOrder", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@amountPaid", amouPaid);
                cmd.Parameters.AddWithValue("@amountReturn", amouRet);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@taxType", taxType);
                cmd.Parameters.AddWithValue("@taxAmount", taxAmoun);

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

        public static int updateOrderAmount(Int64 orderID, double Amt)
        {
            int res = 0;
            //it is use to catch logical error
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateOrderAmount", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@amount", Amt);
                

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

        public static void updateOrderStatus(Int64 orderID, Int16 status)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateOrderStatus", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(" order status updated to the system successfully", "Success", "Success");
                }

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "Error", "Error");
            }
        }

        public static void updateTax(Int16 taxID, float taxValue, string TaxType)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateTax", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@taxID", taxID);
                cmd.Parameters.AddWithValue("@value", taxValue);
                cmd.Parameters.AddWithValue("@type", TaxType);

                MainClass.con.Open();
                int res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage(" TAX updated to the system successfully", "Success", "Success");
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
