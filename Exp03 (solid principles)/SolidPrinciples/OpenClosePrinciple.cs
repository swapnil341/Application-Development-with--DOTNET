using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    internal class OpenClosePrinciple
    {
        public OpenClosePrinciple() { 
            SuperCar s = new SuperCar();
            s.PrintCar();
        }
    }

    abstract class Car
    {
        public abstract void PrintCar();
    }

    class SuperCar : Car
    {
        public override void PrintCar()
        {
            Console.WriteLine("This is the Super Car");
        }

    }

}
