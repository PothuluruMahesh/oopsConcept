using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Data
    {
        int id;
        string name;
        int age;
        string address;

        public void GetData()
        {
            Console.WriteLine("Enter Emp details :");
            this.id = Convert.ToInt32(Console.ReadLine());
            this.name = Convert.ToString(Console.ReadLine());
            this.age = Convert.ToInt32(Console.ReadLine());
            this.address = Convert.ToString(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("emp id :{0}",this.id);
            Console.WriteLine("emp name :{0}", this.name);
            Console.WriteLine("emp age :{0}", this.age);
            Console.WriteLine("emp address :{0}", this.address);
        }
    }
    public class Encap
    {
        static void Main(string[] args)
        {
            Data obj = new Data();
            obj.GetData();
            obj.Display();
            Console.Read();
        }
    }
}
