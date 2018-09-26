using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
  
        public class Emp2
        {
            public Emp2()
            {
                Console.WriteLine("Constructor Invoked");
            }
            ~Emp2()
            {
                Console.WriteLine("Destructor Invoked");
                Console.Read();
             }
        }
        class Dis
        {
            public static void Main(string[] args)
            {
                Emp2 e1 = new Emp2();
                Emp2 e2 = new Emp2();
            }
        }
}
