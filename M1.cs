using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class M1
    {
        public int id;
        public String name;
    }
    class TestStudent
    {
        public static void Main(string[] args)
        {
            M1 s1 = new M1();
            s1.id = 101;
            s1.name = "Sonoo Jaiswal";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);
            Console.Read();
        }
    }
}
