using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ilya = new Person();

            ilya.firstName = "Илья";
            ilya.lastName = "Шичкин";
            ilya.age = 17;

            ilya.Output();

            Console.ReadKey();
        }
    }
}
