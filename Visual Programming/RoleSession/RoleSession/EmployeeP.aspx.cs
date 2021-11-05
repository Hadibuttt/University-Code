using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoleSession
{
    public partial class EmployeeP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] != null)
            {
                int access = (int)Session["access_level"];
                switch (access)
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
                Response.Redirect("Login.aspx");
            }
        }
    }
}