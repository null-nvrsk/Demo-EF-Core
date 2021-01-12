using DemoEFCoreApp.Data;
using System;

namespace _3_Link_Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ApplicationContext db = new ApplicationContext();
            Console.Read();
        }
    }
}
