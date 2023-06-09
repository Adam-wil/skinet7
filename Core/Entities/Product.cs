using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// orm storeage object enttities into the db. id is primary 

namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; } // auto generated property 
        public int Name { get; set; }
    }
}