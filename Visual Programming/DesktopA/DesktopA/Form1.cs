﻿using System;
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
    public partial class Product : Form
    {
        string con = "Data Source=DESKTOP-GS75OSF;Initial Catalog=ecommerce;Integrated Security=True";
        public void show()
        {
            dbcon dbcon = new dbcon(con);
            string query = "Select * from product";
            DataTable dt = dbcon.Search(query);
            if (dt.Rows.Count > 0)
            {
                this.pgrid.DataSource = dt;
            }            
        }

        public Product()
        {
            InitializeComponent();
            show();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            string description = this.description.Text;
            string category = this.category.Text;
            string price = this.price.Text;
            string stock = this.stock.Text;
            string vendor = this.vendor.Text;
            string status = this.status.Text;

            
            dbcon dbcon = new dbcon(con);

            string query = "Insert into product (name,price,stock,vendor,description,category,status) values('" + name + "', '" + price + "','" + stock + "','" + vendor + "','" + description + "','" + category + "','" + status + "')";

            if (dbcon.UDI(query))
            {
                MessageBox.Show("Product Added Successfully!");
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
            string query = "Select * from product where name ='" + name + "'";
            DataTable dt = dbcon.Search(query);
            this.pgrid.DataSource = dt;

            if(dt.Rows.Count > 0)
            {
                this.name.Text = dt.Rows[0]["name"].ToString();
                this.description.Text = dt.Rows[0]["description"].ToString();
                this.category.Text = dt.Rows[0]["category"].ToString();
                this.price.Text = dt.Rows[0]["price"].ToString();
                this.stock.Text = dt.Rows[0]["stock"].ToString();
                this.vendor.Text = dt.Rows[0]["vendor"].ToString();
                this.status.Text = dt.Rows[0]["status"].ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Product Name!");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            string description = this.description.Text;
            string category = this.category.Text;
            string price = this.price.Text;
            string stock = this.stock.Text;
            string vendor = this.vendor.Text;
            string status = this.status.Text;
            dbcon dbcon = new dbcon(con);
            string query = "UPDATE product SET name = '" + name + "', price = '" + price + "', stock = '" + stock + "', vendor = '" + vendor + "', description = '" + description + "', category = '" + category + "', status = '" + status + "' WHERE name = '" + name + "'";
            if (dbcon.UDI(query))
            {
                MessageBox.Show("Product Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            dbcon dbcon = new dbcon(con);
            string query = "DELETE FROM product WHERE name = '" + name + "'";
            if (dbcon.UDI(query))
            {
                MessageBox.Show("Product Deleted Successfully!");
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
            this.description.Text = null;
            this.category.Text = null;
            this.price.Text = null;
            this.stock.Text = null;
            this.vendor.Text = null;
            this.status.Text = null;
            show();
        }
    }
}
