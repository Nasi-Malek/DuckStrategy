using DuckStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// RubberDuck class inheriting from Duck
class RubberDuck : Duck
{
    // Constructor for setting specific behaviors for RubberDuck
    public RubberDuck()
    {
        flyBehaviour = new FlyNoWay();   // Rubber duck can't fly
        quackBehaviour = new Squeak();   // Rubber duck squeaks instead of quacking
    }

    public override void Display()
    {
        Console.WriteLine("I'm a Rubber duck.");
    }
}
