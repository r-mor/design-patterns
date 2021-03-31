using System;

namespace strategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
	    Duck mallard = new MallardDuck();
	    mallard.performQuack();
            Console.WriteLine("Done!");

	    Console.WriteLine("Press enter to quit...");
	    Console.ReadLine();
        }
    }
}
