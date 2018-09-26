using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{ 
    class Class3
    {
        int id;
        string name;
        int age;
        string address;
        public Class3(int s1,string s2,int s3,string s4)
        {
            this.id = s1;
            this.name = s2;
            this.age = s3;
            this.address = s4;
        }
        public void Display()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
            Console.WriteLine(this.address);
        }
    }
    class Class2
    {
        static void Main(string[] args)
        {
            Class3 obj = new Class3(101,"mahi",23,"bang");
            Class3 obj1 = new Class3(101, "mahimahi", 23, "bangalor");
            obj.Display();
            obj1.Display();
            Console.Read();
        }
    }

}
