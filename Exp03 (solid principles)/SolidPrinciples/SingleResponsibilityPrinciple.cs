using System;
using System.Collections.Generic;
using System.Text;

// #01 SINGLE RESPONSIBILITY PRINCIPLE

namespace SolidPrinciples
{

    internal class SingleResponsibilityPrinciple
    {
        public SingleResponsibilityPrinciple()
        {
            CarUser c = new CarUser();
            c.GeneratingMap();

            TrainUser t = new TrainUser();
            t.GeneratingMap();

            BusUser bus = new BusUser();
            bus.GeneratingMap();
        }

    }

    public interface IGenerateMap
    {
        void GeneratingMap();
    }

    class CarUser : IGenerateMap
    {
        public void GeneratingMap()
        {
            Console.WriteLine("Generating Map for Car Users");
        }
    }

    class TrainUser : IGenerateMap
    {
        public void GeneratingMap()
        {
            Console.WriteLine("Generating Map for Train Users");
        }

    }

    class BusUser : IGenerateMap
    {
        public void GeneratingMap()
        {
            Console.WriteLine("Generating Map for Bus users");
        }
    }

}
