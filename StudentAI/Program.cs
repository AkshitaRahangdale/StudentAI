using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StudentAI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Create c1=new Create();
            c1.Name = "John";
            c1.Roll = 12;
            c1.Percent = 78;

            Console.WriteLine(c1.Name + "" + c1.Percent);
            Console.WriteLine(c1);

            Create c2= new Create{ Roll = 12, Name = "John", Percent = 78 };
            Console.WriteLine(c1);
        }
    }
}
