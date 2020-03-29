using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace rmsDB
{
    class deletions
    {
        public  void deleteData( string procedure, string param,int value=0,Int64 value2 = 0)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if(value !=0)
                {
                    cmd.Parameters.AddWithValue(param, value);
                }
                else if (value2 != 0)
                {
                    cmd.Parameters.AddWithValue(param, value2);
                }
  

                MainClass.con.Open();
              int res=  cmd.ExecuteNonQuery();
                MainClass.con.Close();
                if (res > 0)
                {
                    MainClass.showMessage("data deleted successfully", "Success", "Success");
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
