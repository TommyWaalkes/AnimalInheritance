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
            Animal a = new Animal("Jeff");

            a.PrintFood();
            Console.WriteLine(a.GetColor());
            Console.WriteLine();

            Dog d = new Dog("Borkins");
            d.PrintFood();
            Console.WriteLine(d.GetColor());

            Console.WriteLine();
            Cat c = new Cat(false, "McFluffy");
            c.PrintFood();
            Console.WriteLine(c.GetColor());

            List<Animal> animals = new List<Animal>();

            animals.Add(a);
            animals.Add(d);
            animals.Add(c);

            foreach(Animal ans in animals)
            {
                ans.PrintFood();
            }
        
        }
    }
}
