using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class A
    {
        int id;
        string name;
        float salary;
       public void data(int i, string j, float k)
        {
            id = i;
            name = j;
            salary = k;
        }
       public void Display()
        {
            Console.WriteLine("Id = {0} \n Name = {1} \n salary={2}", id, name, salary);
        }
    }
    class M4
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.data(101, "mahesh", 20200);
            obj.Display();
            Console.Read();
        }
    }
}
