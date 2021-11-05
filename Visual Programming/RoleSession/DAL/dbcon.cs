using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class dbcon
    {
        SqlConnection sqlcon;
        public dbcon()
        {
            sqlcon = new SqlConnection("Data Source=DESKTOP-GS75OSF;Initial Catalog=daraz;Integrated Security=True");
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
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
    }
}
