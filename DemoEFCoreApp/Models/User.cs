using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEFCoreApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
        //public string Position { get; set; }    // Новое свойство - должность пользователя
    }
}
