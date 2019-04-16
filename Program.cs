using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to the White House! I am President Trump ( ^ ◡ ^)");
                Console.WriteLine("You must be the new security gaurd, would you like a tour");
    
                string response = Console.ReadLine();

                
                if (response.ToLower() == "yes")
                {
                    Console.WriteLine("Would you like to see my HUGE kitchen rarely ever us? (~_^)");
                    response = Console.ReadLine();

                    if (response.ToLower() == "yes")
                    {
                        // show kitchen
                    }

                    else
                    {
                        Console.WriteLine("Yeah I don't care what you say :)");
                    }

                    Console.WriteLine("Would you like to see the dining room where all my postmates get delivered?(^_^)");
                    response = Console.ReadLine();

                    if (response.ToLower() == "yes")
                    {
                        // show dining room
                    }
                    else
                    {
                        Console.WriteLine("You still have no say in this (^_^)");
                    }

                    Console.WriteLine("Now would you like to see my briliant plan on how I am gonna make Mexico pay for my HUGE wall?");
                    response = Console.ReadLine();

                    if (response.ToLower() == "yes")
                    {
                        // show briliant plan
                    }

                    else
                    {
                        Console.WriteLine("Shhh.");
                    }

                    Console.WriteLine("Nevermind what I just said about that 'plan', I was kidding about that I am an honest person I could never take advantage of a corrupt country.(:");
                    response = Console.ReadLine();

                    if (response.ToLower() == "yes")
                    {
                        // moving on...
                    }

                    else
                    {
                        Console.WriteLine("Ooo TRAINS /(o_O)/");
                    }

                    Console.WriteLine("Now for my masterpiece *pushes Melania Trump to the side* my TRAIN COLLECTION!!!!");
                    Console.WriteLine("*runs over to the trains and says* BING BING BONG BING BING");
                    Console.WriteLine("Ok, bye now (-_^), *type Bye*");
                    response = Console.ReadLine();

                    if (response.ToLower() == "bye")
                    {
                        // goodbye
                    }
                    Console.WriteLine("Oh, forgot to mention YOU'RE FIRED!!!");
                }


            }

        }
    }
}
