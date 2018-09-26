using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Main
    {
        int id;
        string name;
        int age;
        string address;
        public Main()
        {
            this.id = 101;
            this.name = "mahesh";
            this.age = 23;
            this.address = "bangalor";
        }
        public void Display()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
            Console.WriteLine(this.address);
        }
    }
    class Cons1
    {
        static void Main(string[] args)
        {
            Main obj = new Main();
            obj.Display();
            Console.Read();
        }
    }
}
