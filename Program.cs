using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("Jefferey");

            a.PrintFood();
            Console.WriteLine(a.GetColor());
            Console.WriteLine();

            Dog d = new Dog("Borkins");
            d.PrintFood();
            Console.WriteLine(d.GetColor());
        }
    }
}
