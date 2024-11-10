using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Interface for quacking behavior
public interface IQuackBehaviour
{
    void Quack();
}

// Quack class implementing the quacking behavior interface
public class Quacks : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Quack!");
    }
}

// Squeak class for ducks that squeak instead of quacking
public class Squeak : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Squeak!");
    }
}

// MuteQuack class for ducks that don't make any sound
public class MuteQuack : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}

