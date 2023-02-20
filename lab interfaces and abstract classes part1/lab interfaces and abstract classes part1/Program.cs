using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_interfaces_and_abstract_classes_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();

            Console.WriteLine("What is your dog's name?");
            dog1.Name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your dog's colour?");
            dog1.Colour = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How old is your dog?");
            dog1.Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Your dog is {0}. It is {1} and {2} years old.", dog1.Name, dog1.Colour, dog1.Age);
            dog1.Eat();

            Cat cat1 = new Cat();

            Console.WriteLine("What is your cat's name?");
            cat1.Name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your cat's colour?");
            cat1.Colour = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How old is your cat?");
            cat1.Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Your cat is {0}. It is {1} and {2} years old.", cat1.Name, cat1.Colour, cat1.Age);
            cat1.Eat();
        }
    }
}
