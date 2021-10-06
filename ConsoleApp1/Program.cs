using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;

            Console.WriteLine("Hello! Welcome to the number analyzer, what is your name?");
            string name = Console.ReadLine();

            while (cont == true)
            {
                

                bool askAgain = true;
                int answer = 0;
                while (askAgain == true)
                {
                    Console.WriteLine($"{name} please input a number between 1 and 100");
                    answer = int.Parse(Console.ReadLine());
                    if (1 <= answer && answer <= 100)
                    {
                        askAgain = false;
                    }
                    else
                    {
                        askAgain = true;
                        Console.WriteLine($"Oops {name} that is not a valid response");
                    }
                }

                if (answer % 2 != 0)
                {
                    Console.WriteLine($"{answer} and Odd");
                }
                else
                {
                    if (answer >= 2 && answer <= 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (answer >= 26 && answer <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (answer > 60)
                    {
                        Console.WriteLine($"{answer} and Odd");
                    }
                }
                bool secondAskAgain = true;
                while (secondAskAgain == true)
                {

                    Console.WriteLine($"{name} would you like to continue? (Y/N)");
                    string response = Console.ReadLine().ToLower();
                    if (response == "y")
                    {
                        cont = true;
                        secondAskAgain = false;
                    }
                    else if (response == "n")
                    {
                        cont = false;
                        secondAskAgain = false;
                    }

                    else
                    {
                        Console.WriteLine("Invalid Entry");
                        secondAskAgain = true;
                    }
                }

            }
            Console.WriteLine($"Thank you for playing {name}!!");
        }
    }
}
