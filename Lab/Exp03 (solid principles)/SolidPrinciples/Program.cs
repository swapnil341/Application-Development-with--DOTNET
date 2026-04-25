namespace SolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solid Principles Implementation");

            //01 Single Responsibility Principle
            SingleResponsibilityPrinciple solidPrinciple = new SingleResponsibilityPrinciple();


            //02 Open Close Principle
            OpenClosePrinciple openClosePrinciple = new OpenClosePrinciple();
            
        }
    }
}
