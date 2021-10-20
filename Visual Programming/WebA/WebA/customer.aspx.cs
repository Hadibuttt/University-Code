using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebA
{
    public partial class customer : System.Web.UI.Page
    {
        string con = "Data Source=DESKTOP-GS75OSF;Initial Catalog=ecommerce;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon dbcon = new dbcon(con);
            string query = "Select * from customer";
            DataTable dt = dbcon.Search(query);
            if (dt.Rows.Count > 0)
            {
                this.cGrid.DataSource = dt;
                this.cGrid.DataBind();
            }
        }

        protected void create_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            string email = this.email.Text;
            string address = this.address.Text;
            string city = this.city.Text;
            string gender = this.gender.Text;
            string cnic = this.cnic.Text;
            string phone = this.phone.Text;


            dbcon dbcon = new dbcon(con);

            string query = "Insert into customer (name,email,cnic,address,city,gender,phone) values('" + name + "', '" + email + "','" + cnic + "','" + address + "','" + city + "','" + gender + "','" + phone + "')";

            if (dbcon.UDI(query))
            {
                this.msg.Text = "Customer Added Successfully!";
            }
            else
            {
                this.msg.Text = "Error!";
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            string email = this.email.Text;
            string address = this.address.Text;
            string city = this.city.Text;
            string gender = this.gender.Text;
            string cnic = this.cnic.Text;
            string phone = this.phone.Text;
            dbcon dbcon = new dbcon(con);
            string query = "UPDATE customer SET name = '" + name + "', email = '" + email + "', address = '" + address + "', city = '" + city + "', gender = '" + gender + "', cnic = '" + cnic + "', phone = '" + phone + "' WHERE name = '" + name + "'";
            if (dbcon.UDI(query))
            {
                this.msg.Text = "Customer Updated Successfully!";
            }
            else
            {
                this.msg.Text = "Error!";
            }
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            dbcon dbcon = new dbcon(con);
            string query = "DELETE FROM customer WHERE name = '" + name + "'";
            if (dbcon.UDI(query))
            {
                this.msg.Text = "Customer Deleted Successfully!";
            }
            else
            {
                this.msg.Text = "Error!";
            }
        }

        protected void select_Click(object sender, EventArgs e)
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
                this.address.Text = dt.Rows[0]["address"].ToString();
                this.gender.Text = dt.Rows[0]["gender"].ToString();
                this.city.Text = dt.Rows[0]["city"].ToString();
                this.cnic.Text = dt.Rows[0]["cnic"].ToString();
                this.phone.Text = dt.Rows[0]["phone"].ToString();
            }
            else
            {
                this.msg.Text = "Please Enter a Valid Customer Name!";
            }
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            this.name.Text = null;
            this.city.Text = null;
            this.gender.Text = null;
            this.phone.Text = null;
            this.cnic.Text = null;
            this.email.Text = null;
            this.address.Text = null;
        }
    }
}