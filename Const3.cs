using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Emp
    {
        public Emp()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
    }
    class Const3
    {
        public static void Main(string[] args)
        {
            Emp e1 = new Emp();
            Emp e2 = new Emp();
            Console.Read();
        }
    }
}