using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class M3
    {
        static int id;
        static string name;
        static void putName(int i,string j)
        {
            id = i;
            name = j;
        }
        static void display()
        {
            Console.WriteLine("Id is : {0} and Name is :{1}",id,name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start.........");
            putName(101,"mahesh");
            display();
            Console.WriteLine("Main End............");
            Console.Read();
        }
    }
}
