using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
using DAL;

namespace BLL
{
    public class EmpBLL
    {
        EmpDAL eDAL = new EmpDAL();
        public bool EmpInsertBLL(employee e)
        {
            return eDAL.EmpInsertDAL(e);
        }

        public bool EmpUpdateBLL(employee e)
        {
            return eDAL.EmpUpdateDAL(e);
        }

        public bool EmpDeleteBLL(employee e)
        {
            return eDAL.EmpDeleteDAL(e);
        }

        public DataTable EmpSearchBLL(employee e)
        {
            return eDAL.EmpSearchDAL(e);
        }

        public DataTable LoginBLL(employee e)
        {
            return eDAL.LoginDAL(e);
        }

        public DataTable productGetAllBLL()
        {
            return eDAL.EmpGetAllDAL();
        }
    }
}
