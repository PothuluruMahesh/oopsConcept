using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Program
    {
        public class Student
        {
            int id;//data member (also instance variable)    
            String name;//data member(also instance variable)    

            public static void Main(string[] args)
            {
                Student s1 = new Student();//creating an object of Student    
                s1.id = 101;
                s1.name = "MAHESH";
                Console.WriteLine(s1.id);
                Console.WriteLine(s1.name);
                Console.Read();
            }
        }
    }
}
