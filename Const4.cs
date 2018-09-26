using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Emp1
    {
        int id;
        String name;
        float salary;
        public Emp1(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class Const4
    {
        public static void Main(string[] args)
        {
            Emp1 e1 = new Emp1(101, "Sonoo", 890000f);
            Emp1 e2 = new Emp1(102, "Mahesh", 490000f);
            e1.display();
            e2.display();
            Console.Read();
        }
    }
}