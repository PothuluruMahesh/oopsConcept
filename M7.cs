using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
    }
    class M7
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Console.Read();
        }
    }
}
