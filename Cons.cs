using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Cons
    { 
        Cons()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
        public static void Main(string[] args)
        {
            Cons e1 = new Cons();
            Cons e2 = new Cons();
        }
    }
}
