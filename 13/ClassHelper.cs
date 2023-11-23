using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class ClassHelper
    {
        static public List<Service> services = new List<Service>()
        {
            new Service() { Id = 1, Date = "29.01.2003", NameClient ="Лерочка", NameService = "Ноготочки"},
            new Service() { Id = 2, Date = "29.01.2003", NameClient ="Лерочка", NameService = "Педикюр"},
            new Service() { Id = 3, Date = "29.01.2003", NameClient ="Лерочка", NameService = "Реснички"},
        };
    }
}
