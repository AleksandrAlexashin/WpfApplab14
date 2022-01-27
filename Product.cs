using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplab14

{
    public enum ProductTypes
    { Food, Appliances }
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string Image { get; set; }
        public ProductTypes ProductTypes { get; set;}
    }
}


