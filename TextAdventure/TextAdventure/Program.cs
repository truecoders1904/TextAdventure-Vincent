using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to the White House! I'm President Trump ( ^ ◡ ^)");
                Console.WriteLine("You must be the new security gaurd, do you want a tour?");
    
                string response = Console.ReadLine();

                if (response == "Yes")
                {
                    Console.WriteLine("Would you like to see my MASSIVE kitchen that I don't use? (~_^)");
                    response = Console.ReadLine();

                    if (response == "Yes")
                    {
                        // show kitchen
                    }

                    Console.WriteLine("Would you like to see the dining where I eat all of the fast food restraunts that I want?(^_^)");
                    response = Console.ReadLine();

                    if (response == "Yes")
                    {
                        // show dining room
                    }
                    Console.WriteLine("Now would you like to see my briliant plan on how I am gonna make Mexico pay for my massive wall? XD");
                    response = Console.ReadLine();

                    if (response == "Yes")
                    {
                        // show briliant plan
                    }
                    Console.WriteLine("Now for my final masterpiece *pushes Melania Trump to the side* my TRAIN COLLECTION!!!!");
                    Console.WriteLine("*runs over to the trains* BING BING BONG BING BING");
                    Console.WriteLine("Ok, bye now (-_^), *type Bye*");
                    response = Console.ReadLine();

                    if (response == "Bye")
                    {
                        // goodbye
                    }
                    Console.WriteLine("Forgot to mention YOU'RE FIRED!!!");
                }
                else if (response == "No")
                {
                    Console.WriteLine("YOU'RE FIRED!");
                }

            }
        }
    }
}
