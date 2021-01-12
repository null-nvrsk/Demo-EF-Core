using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Link_Models.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        // навигационное свойство
        public Company Manufacturer { get; set; }
    }
}
