using System;

namespace SelectionStatementsSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Tell me what is your favorite class.");
                string userSubject = Console.ReadLine();

                switch (userSubject.ToLower())
                {
                    case "math":
                        Console.WriteLine("Math - very square");
                        break;
                    case "geology":
                        Console.WriteLine("Geology  - rock N' roll");
                        break;
                    case "English":
                        Console.WriteLine("English - that's poetic");
                        break;
                    case "scinece":
                        Console.WriteLine("Science - how explosive!");
                        break;
                    case "world history":
                        Console.WriteLine("World History - very intriguing");
                        break;
                    case "computer science":
                        Console.WriteLine("Computer Science - arrrggghhhhhh");
                        break;
                    default:
                        Console.WriteLine("Whatever!  Take a real class!");
                        break;
                }

            }
        }
}
