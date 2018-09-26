using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Mahesh420
    {
        static void Main(string[] args)
        {
            Mahi obj = new Mahi();
            obj.ID = "101";
            obj.Name = "Mahesh";
            obj.Email = "pmahesh6343@gamil.com";

            Console.WriteLine("ID = " + obj.ID);
            Console.WriteLine("Name = " + obj.Name);
            Console.WriteLine("Email = " + obj.Email);
            Console.Read();
        }
    }
}
