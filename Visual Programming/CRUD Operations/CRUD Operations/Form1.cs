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

namespace CRUD_Operations
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Create_Click(object sender, EventArgs e)
		{
            string email = txte.Text;
            string name = txtn.Text;
            string query = "Insert into info (name,email) values('" + name + "','" + email + "')";
            string con = "Data Source=DESKTOP-GS75OSF;Initial Catalog=User;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            sqlcon.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Record Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Error");

            }
            sqlcon.Close();

        }

		private void Update_Click(object sender, EventArgs e)
		{
            string email = txte.Text;
            string name = txtn.Text;
            string query = "UPDATE info SET name = '" + name + "' WHERE email = '" + email + "';";
            string con = "Data Source=DESKTOP-GS75OSF;Initial Catalog=User;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            sqlcon.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Record Updated Successfully");

            }
            else
            {
                MessageBox.Show("Error");

            }
            sqlcon.Close();

        }

		private void Read_Click(object sender, EventArgs e)
		{
            string email = txte.Text;
            string name = txtn.Text;
            string query = "Select * from info where email ='" + email + "'";
            string con = "Data Source=DESKTOP-GS75OSF;Initial Catalog=User;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            if (dt.Rows.Count > 0)
            {
                txtn.Text = dt.Rows[0]["name"].ToString();
                txte.Text = dt.Rows[0]["email"].ToString();
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
        }

		private void Delete_Click(object sender, EventArgs e)
		{
            string email = txte.Text;
            string query = "DELETE FROM info WHERE email = '" + email +"';";
            string con = "Data Source=DESKTOP-GS75OSF;Initial Catalog=User;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            sqlCon.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Record Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
            sqlCon.Close();
        }
	}
}
