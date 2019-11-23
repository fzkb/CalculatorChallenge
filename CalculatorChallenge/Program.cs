using System;

namespace CalculatorChallenge
{
    class Program
    {
        public static void Main()
        {

            ConsoleKeyInfo keyInfo;
            // Establish an event handler to process key press events.
            Console.CancelKeyPress += new ConsoleCancelEventHandler(exitHandler);

            Console.WriteLine(@"CTRL+C to Cancel");

            Console.WriteLine("########################################################");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("Enter your numbers array seprated by (,) for Arithmatic operation:");
                var array = Console.ReadLine();

                Calculator calc = new Calculator(array);

                var result = calc.validateNumber();

                if (result == "valid")
                {
                    var sum = calc.addNumber();

                    Console.WriteLine(sum);
                }
                else
                {
                    Console.WriteLine(result);
                }

                keyInfo = Console.ReadKey(true);
            }
        }

        protected static void exitHandler(object sender, ConsoleCancelEventArgs args)
        {
            if (args.SpecialKey.ToString().ToLower() == "controlc")
            {
                Console.WriteLine("\nThe arthimatic operation has been interrupted.");
                args.Cancel = true;
                Environment.Exit(0);
            }

        }
    }
}
