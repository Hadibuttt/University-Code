using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebA
{
    public class dbcon
    {
        SqlConnection sqlcon;
        public dbcon(string con)
        {
            sqlcon = new SqlConnection(con);
        }

        public bool UDI(string query)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            bool check = (cmd.ExecuteNonQuery() > 0);
            sqlcon.Close();
            return check;
        }

        public DataTable Search(string query)
        {
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcon.Close();
            return dt;
        }
    }
}