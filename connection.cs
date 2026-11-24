using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace project_ecommerce
{

    public class Connection
    {
        SqlConnection con;
        SqlCommand cmd;
        public Connection()
        {
            con = new SqlConnection(@"Server = DESKTOP-LF7ET7N\SQLEXPRESS;database = Userreg; integrated security = true");
        }
        public int Fn_NonQuery(string sqlq)//select,update,delete
        {
            cmd = new SqlCommand(sqlq, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            return i;
        }
        

        public string Fn_Scalar(string sqlq)
        {
            cmd = new SqlCommand(sqlq, con);
            con.Open();
            string i = cmd.ExecuteScalar().ToString();
            con.Close();

            return i;
        }
        public string Fn_scalar(string sqlq)
        {
            cmd = new SqlCommand(sqlq, con);
            con.Open();
            string o = cmd.ExecuteScalar().ToString();
            con.Close();

            return o;
        }

        public SqlDataReader Fn_SqlRead(string sqlq)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlq, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }
        public DataSet Fn_Adapter_Dataset(string sqlq)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlq, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}