using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {   
            var runningTotal = 0.0;

            // prompt user for minutes exercised
            // loop until users says stop
            while (true) 
            {
                Console.Write("Enter how many minutes have you exercised or type \"quit\" to exit: ");
                var response = Console.ReadLine();

                if (response.ToLower() == "quit")
                {
                    break;
                }
                try
                {
                    var minutes = double.Parse(response);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable answer");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("You should exercise more.");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Not bad. Try harder next time.");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("Great job!");
                    }
                    else
                    {
                        Console.WriteLine("Wow. You're a lean mean exercising machine!");
                    }
                    // add minutes to total
                    runningTotal += minutes; 
                    
                    // display total minutes exercised to the screen
                    Console.WriteLine("You have exercised " + runningTotal + " minutes thus far!");
                }
                catch
                {
                    Console.WriteLine("Invalid entry");
                    continue;
                }
            }
            Console.WriteLine("Goodbye");
         }
    }
}
