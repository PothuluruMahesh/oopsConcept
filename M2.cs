using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class M2
    {
        public int id;
        public String name;
        public void insert(int i, String n)
        {
            id = i;
            name = n;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name);
        }
    }
    class TestM2
    {
        public static void Main(string[] args)
        {
            M2 s1 = new M2();
            M2 s2 = new M2();
            s1.insert(101, "Ajeet");
            s2.insert(102, "Tom");
            s1.display();
            s2.display();
            Console.Read();
        }
    }
}
