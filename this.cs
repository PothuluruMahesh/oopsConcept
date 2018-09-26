using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
   
        public class emp5
        {
            public int id;
            public String name;
            public float salary;
            public emp5(int id, String name, float salary)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;
            }
            public void display()
            {
                Console.WriteLine(id + " " + name + " " + salary);
            }
        }
        class This
        {
            public static void Main(string[] args)
            {
                emp5 e1 = new emp5(101, "Sonoo", 890000f);
                emp5 e2 = new emp5(102, "Mahesh", 490000f);
                e1.display();
                e2.display();
            Console.Read();
            }
        }
}
