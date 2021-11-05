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
    public partial class EmpR : System.Web.UI.Page
    {
        EmpBLL eBLL = new EmpBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            AppProps.employee emp = new AppProps.employee();
            emp.Name = name.Text;
            emp.Email = email.Text;
            emp.Password = password.Text;
            emp.Accesslevel = "1";
            emp.Cnic = cnic.Text;
            emp.Age = age.Text;
            emp.Gender = gender.Text;

            if (eBLL.EmpInsertBLL(emp))
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                ResultLabel.Text = "An Unknown Error Occured!";
            }

        }
    }
}