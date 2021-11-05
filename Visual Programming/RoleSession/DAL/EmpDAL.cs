using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DAL
{
    public class EmpDAL
    {
        dbcon db = new dbcon();
        public bool EmpInsertDAL(employee e)
        {
            string query = "Insert into users (name,email,password,accesslevel,cnic,gender,age) values('" + e.Name + "', '" + e.Email + "','" + e.Password + "','" + e.Accesslevel + "','" + e.Cnic + "','" + e.Gender + "','" + e.Age + "')";
            return db.UDI(query);
        }

        public bool EmpDeleteDAL(employee e)
        {
            string query = "DELETE FROM users WHERE email = '" + e.Email + "'";
            return db.UDI(query);
        }

        public bool EmpUpdateDAL(employee e)
        {
            string query = "UPDATE users SET name = '" + e.Name + "', email = '" + e.Email + "', password = '" + e.Password + "', accesslevel = '" + e.Accesslevel + "', cnic = '" + e.Cnic + "', gender = '" + e.Gender + "', age = '" + e.Age + "' WHERE email = '" + e.Email + "'";
            return db.UDI(query);
        }

        public DataTable EmpSearchDAL(employee e)
        {
            string query = "Select * from users where email ='" + e.Email + "'";
            return db.Search(query);
        }

        public DataTable LoginDAL(employee e)
        {
            string query = "Select * from users where email ='" + e.Email + "' AND password ='" + e.Password + "'";
            return db.Search(query);
        }

        public DataTable EmpGetAllDAL()
        {
            string query = "Select * from users";
            return db.Search(query);
        }

    }
}