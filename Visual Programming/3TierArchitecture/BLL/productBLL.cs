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
    public class productBLL
    {
        productDAL pDAL = new productDAL();
        public bool productInsertBLL(product p)
        {
            return pDAL.productInsertDAL(p);
        }

        public bool productUpdateBLL(product p)
        {
            return pDAL.productUpdateDAL(p);
        }

        public bool productDeleteBLL(product p)
        {
            return pDAL.productDeleteDAL(p);
        }

        public DataTable productSearchBLL(product p)
        {
            return pDAL.productSearchDAL(p);
        }

        public DataTable productGetAllBLL()
        {
            return pDAL.productGetAllDAL();
        }
    }
}