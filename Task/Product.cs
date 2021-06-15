using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Product
    {
        public string Name { get; set; }
        public string OriginCountry { get; set; }
        public double Cost { get; set; }
        public override string ToString()
        {
            return $"Name : {Name}   OriginCountry : {OriginCountry}   Cost : {Cost}";
        }
        public Product()
        {

        }
    }
}
