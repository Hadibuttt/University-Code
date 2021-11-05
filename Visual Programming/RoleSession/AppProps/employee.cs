using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class employee
    {
        private string name;
        private string email;
        private string password;
        private string accesslevel;
        private string cnic;
        private string gender;
        private string age;

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Accesslevel { get => accesslevel; set => accesslevel = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Age { get => age; set => age = value; }
    }
}
