using System;

namespace DuckStrategy
{
    // Program class to run the main logic
    class Program
    {
        static void Main(string[] args)
        {
            // Mallard
            Duck myMallard = new Mallard();           // Creates a Mallard duck
            myMallard.PerformFly();                   // Mallard performs flying behavior
            myMallard.PerformQuack();                 // Mallard performs quacking behavior
            myMallard.Display();                      // Displays the Mallard duck
            Console.WriteLine();                      // Newline for formatting output

            // RubberDuck
            Duck myRubberDuck = new RubberDuck();     // Creates a Rubber duck
            myRubberDuck.PerformFly();                // Rubber duck performs flying behavior (likely no fly)
            myRubberDuck.PerformQuack();              // Rubber duck performs quacking behavior (likely squeak)
            myRubberDuck.Display();                   // Displays the Rubber duck
            Console.WriteLine();                      // Newline for formatting output

            // ModelDuck
            Duck myModelDuck = new ModelDuck();       // Creates a Model duck
            myModelDuck.PerformFly();                 // Initially the model duck can't fly
            myModelDuck.SetFlyBehaviour(new FlyRocketPowered());   // Change flying behavior to rockets
            myModelDuck.PerformFly();                 // Now the model duck flies with rockets
            myModelDuck.PerformQuack();               // Model duck performs quacking behavior
            myModelDuck.Display();                    // Displays the Model duck
        }
    }
}
