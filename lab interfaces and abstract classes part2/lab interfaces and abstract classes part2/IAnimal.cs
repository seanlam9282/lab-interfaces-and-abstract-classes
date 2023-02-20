using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_interfaces_and_abstract_classes_part2
{
    internal interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        double Height { get; set; }
        int Age { get; set; }

        void Eat();
        string Cry();
    }
}
