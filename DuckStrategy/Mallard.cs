using DuckStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Mallard class inheriting from Duck
class Mallard : Duck
{
    // Constructor for setting specific behaviors for Mallard
    public Mallard()
    {
        flyBehaviour = new FlyWithWings();  // Mallard can fly with wings
        quackBehaviour = new Quacks();       // Mallard quacks
    }

    public override void Display()
    {
        Console.WriteLine("I'm a Mallard duck.");
    }
}
