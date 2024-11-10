using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    // The base Duck class that defines common behaviors
    abstract class Duck
    {
        // Declare variables for the fly and quack behaviors
        protected IFlyBehaviour flyBehaviour;
        protected IQuackBehaviour quackBehaviour;

        // Each duck will perform its flying behavior based on the strategy it holds
        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        // Each duck will perform its quacking behavior based on the strategy it holds
        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        // This allows changing the fly behavior dynamically at runtime
        public void SetFlyBehaviour(IFlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        // Abstract method for displaying the duck (each subclass will implement this)
        public abstract void Display();
    }
