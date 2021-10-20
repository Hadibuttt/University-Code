using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopA
{
    public partial class customer : Form
    {
        string con = "Data Source=DESKTOP-GS75OSF;Initial Catalog=ecommerce;Integrated Security=True";
        public void show()
        {
            dbcon dbcon = new dbcon(con);
            string query = "Select * from customer";
            DataTable dt = dbcon.Search(query);
            if (dt.Rows.Count > 0)
            {
                this.cGrid.DataSource = dt;
            }
        }
        public customer()
        {
            InitializeComponent();
            show();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            string email = this.email.Text;
            string cnic = this.cnic.Text;
            string address = this.adress.Text;
            string phone = this.phone.Text;
            string gender = this.gender.Text;
            string city = this.city.Text;


            dbcon dbcon = new dbcon(con);

            string query = "Insert into customer (name,email,cnic,address,phone,gender,city) values('" + name + "', '" + email + "','" + cnic + "','" + address + "','" + phone + "','" + gender + "','" + city + "')";

            if (dbcon.UDI(query))
            {
                MessageBox.Show("Customer Added Successfully!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            string email = this.email.Text;
            string cnic = this.cnic.Text;
            string address = this.adress.Text;
            string phone = this.phone.Text;
            string gender = this.gender.Text;
            string city = this.city.Text;
            dbcon dbcon = new dbcon(con);
            string query = "UPDATE customer SET name = '" + name + "', email = '" + email + "', cnic = '" + cnic + "', address = '" + address + "', phone = '" + phone + "', gender = '" + gender + "', city = '" + city + "' WHERE name = '" + name + "'";
            if (dbcon.UDI(query))
            {
                MessageBox.Show("Customer Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            show();
        }

        private void select_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            dbcon dbcon = new dbcon(con);
            string query = "Select * from customer where name ='" + name + "'";
            DataTable dt = dbcon.Search(query);
            this.cGrid.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                this.name.Text = dt.Rows[0]["name"].ToString();
                this.email.Text = dt.Rows[0]["email"].ToString();
                this.cnic.Text = dt.Rows[0]["cnic"].ToString();
                this.adress.Text = dt.Rows[0]["address"].ToString();
                this.phone.Text = dt.Rows[0]["phone"].ToString();
                this.gender.Text = dt.Rows[0]["gender"].ToString();
                this.city.Text = dt.Rows[0]["city"].ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Customer Name!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            dbcon dbcon = new dbcon(con);
            string query = "DELETE FROM customer WHERE name = '" + name + "'";
            if (dbcon.UDI(query))
            {
                MessageBox.Show("Customer Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            show();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.name.Text = null;
            this.email.Text = null;
            this.adress.Text = null;
            this.cnic.Text = null;
            this.phone.Text = null;
            this.gender.Text = null;
            this.city.Text = null;
            show();
        }

    }
}
