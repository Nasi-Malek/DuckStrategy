using DuckStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ModelDuck class inheriting from Duck
class ModelDuck : Duck
{
    // Constructor for setting initial behavior (no flying)
    public ModelDuck()
    {
        flyBehaviour = new FlyNoWay();   // Model duck can't fly at first
        quackBehaviour = new Quacks();    // Model duck quacks
    }

    public override void Display()
    {
        Console.WriteLine("I'm a Model duck.");
    }
}