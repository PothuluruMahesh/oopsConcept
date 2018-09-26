using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    interface Task1
    {
        void show();
        void run();
    }
   public class Abc : Task1
    {
       public void show()
        {
            Console.WriteLine("from show()");
        }
        public void show(int i)
        {
            Console.WriteLine("from show(int i)");
        }
        public void show(int i,int j)
        {
            Console.WriteLine("from show(int i,int j)");
        }
        public void run()
        {
            Console.WriteLine("From run()");
        }
        public void run(int i)
        {
            Console.WriteLine("From run(int i)");
        }
        public void run(int i,int j)
        {
            Console.WriteLine("From run(int i,int j)");
        }
        static void Main(string[] args)
        {
            Abc obj = new Abc();
            obj.show();
            obj.show(10);
            obj.show(10,20);
            Abc obj1 = new Abc();
            obj1.run();
            obj1.run(10);
            obj1.run(10,20);
            Console.Read();
        }
    }
}
