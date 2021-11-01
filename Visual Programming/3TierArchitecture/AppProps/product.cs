using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class product
    {
        private string name;
        private string price;
        private string vendor;
        private string stock;
        private string status;
        private string description;
        private string category;

        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
        public string Vendor { get => vendor; set => vendor = value; }
        public string Stock { get => stock; set => stock = value; }
        public string Status { get => status; set => status = value; }
        public string Description { get => description; set => description = value; }
        public string Category { get => category; set => category = value; }
    }
}
