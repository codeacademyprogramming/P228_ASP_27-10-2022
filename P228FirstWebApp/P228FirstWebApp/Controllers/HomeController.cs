using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228FirstWebApp.Controllers
{
    public class HomeController
    {
        public string Index(int? id, string name,string surname)
        {
            if (id == null)
                return $"P228 First Controller a = deyeri yoxdur {name} {surname}";
            return $"P228 First Controller {id} {name} {surname}";
        }

        public string Test()
        {
            Index(name:"", id:545, surname:"");

                
            return "Hoome Test";
        }
    }
}
