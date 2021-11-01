using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DAL
{
    public class productDAL
    {
        dbcon db = new dbcon();
        public bool productInsertDAL(product p)
        {
            string query = "Insert into product (name,price,stock,vendor,description,category,status) values('" + p.Name + "', '" + p.Price + "','" + p.Stock + "','" + p.Vendor + "','" + p.Description + "','" + p.Category + "','" + p.Status + "')";
            return db.UDI(query);
        }

        public bool productDeleteDAL(product p)
        {
            string query = "DELETE FROM product WHERE name = '" + p.Name + "'";
            return db.UDI(query);
        }

        public bool productUpdateDAL(product p)
        {
            string query = "UPDATE product SET name = '" + p.Name + "', price = '" + p.Price + "', stock = '" + p.Stock + "', vendor = '" + p.Vendor + "', description = '" + p.Description + "', category = '" + p.Category + "', status = '" + p.Status + "' WHERE name = '" + p.Name + "'";
            return db.UDI(query);
        }

        public DataTable productSearchDAL(product p)
        {
            string query = "Select * from product where name ='" + p.Name + "'";
            return db.Search(query);
        }

        public DataTable productGetAllDAL()
        {
            string query = "Select * from product";
            return db.Search(query);
        }
    }
}
