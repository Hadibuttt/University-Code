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
    public partial class supplier : Form
    {
        string con = "Data Source=DESKTOP-GS75OSF;Initial Catalog=ecommerce;Integrated Security=True";
        public void show()
        {
            dbcon dbcon = new dbcon(con);
            string query = "Select * from supplier";
            DataTable dt = dbcon.Search(query);
            if (dt.Rows.Count > 0)
            {
                this.sGrid.DataSource = dt;
            }
        }
        public supplier()
        {
            InitializeComponent();
            show();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            string email = this.email.Text;
            string cnic = this.cnic.Text;
            string address = this.address.Text;
            string phone = this.phone.Text;

            dbcon dbcon = new dbcon(con);

            string query = "Insert into supplier (name,email,cnic,address,phone) values('" + name + "', '" + email + "','" + cnic + "','" + address + "','" + phone + "')";

            if (dbcon.UDI(query))
            {
                MessageBox.Show("Supplier Added Successfully!");
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
            string address = this.address.Text;
            string phone = this.phone.Text;

            dbcon dbcon = new dbcon(con);
            string query = "UPDATE supplier SET name = '" + name + "', email = '" + email + "', cnic = '" + cnic + "', address = '" + address + "', phone = '" + phone + "' WHERE name = '" + name + "'";
            if (dbcon.UDI(query))
            {
                MessageBox.Show("Supplier Updated Successfully!");
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
            string query = "Select * from supplier where name ='" + name + "'";
            DataTable dt = dbcon.Search(query);
            this.sGrid.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                this.name.Text = dt.Rows[0]["name"].ToString();
                this.email.Text = dt.Rows[0]["email"].ToString();
                this.cnic.Text = dt.Rows[0]["cnic"].ToString();
                this.address.Text = dt.Rows[0]["address"].ToString();
                this.phone.Text = dt.Rows[0]["phone"].ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Supplier Name!");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            dbcon dbcon = new dbcon(con);
            string query = "DELETE FROM supplier WHERE name = '" + name + "'";
            if (dbcon.UDI(query))
            {
                MessageBox.Show("Supplier Deleted Successfully!");
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
            this.address.Text = null;
            this.cnic.Text = null;
            this.phone.Text = null;
            show();
        }

    }
}
