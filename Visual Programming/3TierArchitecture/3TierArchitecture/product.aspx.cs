using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppProps;
using BLL;

namespace _3TierArchitecture
{
    public partial class product : System.Web.UI.Page
    {
        productBLL pBLL = new productBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            AppProps.product p = new AppProps.product();
            p.Name = name.Text;
            DataTable dt = pBLL.productSearchBLL(p);
            this.pGrid.DataSource = dt;

            if (dt.Rows.Count > 0)
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
                this.ResultLabel.Text = "Please Enter a Valid Product Name!";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            AppProps.product p = new AppProps.product();
            p.Name = name.Text;
            p.Price = price.Text;
            p.Category = category.Text;
            p.Description = description.Text;
            p.Status = status.Text;
            p.Stock = stock.Text;
            p.Vendor = vendor.Text;

            if(pBLL.productInsertBLL(p))
            {
                ResultLabel.Text = "Product Saved Successfully!";
            }
            else
            {
                ResultLabel.Text = "Error!";
            }
            LoadGridView();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            AppProps.product p = new AppProps.product();
            p.Name = name.Text;
            p.Price = price.Text;
            p.Category = category.Text;
            p.Description = description.Text;
            p.Status = status.Text;
            p.Stock = stock.Text;
            p.Vendor = vendor.Text;

            if (pBLL.productUpdateBLL(p))
            {
                ResultLabel.Text = "Product Updated Successfully!";
            }
            else
            {
                ResultLabel.Text = "Error!";
            }
            LoadGridView();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            AppProps.product p = new AppProps.product();
            p.Name = name.Text;

            if (pBLL.productDeleteBLL(p))
            {
                ResultLabel.Text = "Product Deleted Successfully!";
            }
            else
            {
                ResultLabel.Text = "Error!";
            }
            LoadGridView();
        }

        private void LoadGridView()
        {
            pGrid.DataSource = pBLL.productGetAllBLL();
            pGrid.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            this.name.Text = null;
            this.description.Text = null;
            this.category.Text = null;
            this.price.Text = null;
            this.stock.Text = null;
            this.vendor.Text = null;
            this.status.Text = null;
            LoadGridView();
        }
    }
}