using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Interface for flying behavior
public interface IFlyBehaviour
{
    void Fly();
}

// FlyWithWings class implementing the flying behavior interface
public class FlyWithWings : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with wings!");
    }
}

// FlyNoWay class for ducks that can't fly
public class FlyNoWay : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("I can't fly.");
    }
}

// FlyRocketPowered class for ducks flying with rockets
public class FlyRocketPowered : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }
}
