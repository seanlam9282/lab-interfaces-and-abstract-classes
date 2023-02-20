using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_interfaces_and_abstract_classes_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();

            Dog dog1 = new Dog();

            Console.WriteLine("What is your dog's name?");
            dog1.Name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your dog's colour?");
            dog1.Colour = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How tall (in cm) is your dog?");
            dog1.Height = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How old is your dog?");
            dog1.Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Your dog is {0}. It is {1} and {3} years old. Its height is {2} cm.", dog1.Name, dog1.Colour, dog1.Height, dog1.Age);
            dog1.Eat();
            Console.WriteLine(dog1.Cry() + "\r\n");
            animals.Add(dog1);

            Cat cat1 = new Cat();

            Console.WriteLine("What is your cat's name?");
            cat1.Name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your cat's colour?");
            cat1.Colour = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How tall (in cm) is your cat?");
            cat1.Height = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How old is your cat?");
            cat1.Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Your cat is {0}. It is {1} and {3} years old. Its height is {2} cm.", cat1.Name, cat1.Colour, cat1.Height, cat1.Age);
            cat1.Eat();
            Console.WriteLine(cat1.Cry() + "\r\n");
            animals.Add(cat1);

            Console.WriteLine("Here is the current list of animals:");
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
