using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppProps;
using BLL;

namespace RoleSession
{
    public partial class Login : System.Web.UI.Page
    {
        EmpBLL eBLL = new EmpBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            AppProps.employee emp = new AppProps.employee();
            emp.Email = email.Text;
            emp.Password = password.Text;
            DataTable dt = eBLL.LoginBLL(emp);
            
            if (dt != null)
            {
                int AC = Convert.ToInt32(dt.Rows[0]["accesslevel"].ToString());
                Session["user_id"] = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                Session["access_level"] = AC;

                switch (AC)
                {
                    case 0:
                        Response.Redirect("AdminP.aspx");
                        break;
                    case 1:
                        Response.Redirect("EmpP.aspx");
                        break;
                    case 2:
                        Response.Redirect("CustomerP.aspx");
                        break;
                    case 3:
                        Response.Redirect("SupplierP.aspx");
                        break;
                }

            }
            else
            {
                this.ResultLabel.Text = "Incorrect Credentials!";
            }
        }
    }
}