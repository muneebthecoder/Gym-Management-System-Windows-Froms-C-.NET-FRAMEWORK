using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GymManagementSystem
{
    public class DBHelper
    {
        string constr = @"Data Source=DESKTOP-NF1C7NA\SQLEXPRESS; initial catalog=GymManagementSystem ;integrated security=true;";
        SqlConnection con;
        SqlCommand cmd;
        public DBHelper()
        {
            con = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        private void OpenCon()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public int IDU(string q)
        {
            OpenCon();
            cmd.CommandText = q;
            cmd.Connection = con;
            return cmd.ExecuteNonQuery();
        }
        public SqlDataReader GetReader(String q)
        {
            OpenCon();
            cmd.CommandText = q;
            cmd.Connection = con;
            return cmd.ExecuteReader();
        }
     
    }
}
