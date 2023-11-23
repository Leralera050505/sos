using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class ClassHelper
    {
        public static List<Product> book = new List<Product>()
        {
            new Product (){ IdBook=1 ,Name = "Name1",Cost =23},
            new Product (){ IdBook=2 ,Name = "Name2",Cost =20},
            new Product (){ IdBook=3  ,Name = "Name3",Cost =54},
            new Product (){ IdBook=4 ,Name = "Name4",Cost =454},
            new Product (){ IdBook=5 ,Name = "Name5",Cost =43},
            new Product (){ IdBook=6 ,Name = "Name6",Cost =233},
        };
    }
}
