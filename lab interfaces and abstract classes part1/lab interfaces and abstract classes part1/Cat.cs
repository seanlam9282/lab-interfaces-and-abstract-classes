using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_interfaces_and_abstract_classes_part1
{
    internal class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.\r\n");
        }
    }
}
