using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry point Method
        //static means no instance object were reffereing to the method itself;void means it doesn't return anything
        static void Main(string[] args)
        {

            GetAppInfo();
            GreetUser();

            while (true)
            {
                //Set correct number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {

                    string temp = Console.ReadLine();
                    if (!int.TryParse(temp, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "It's not a number, please insert number");
                        continue;
                    }
                    guess = Int32.Parse(temp);
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong, try again");                       
                    }
                }
                
                PrintColorMessage(ConsoleColor.Yellow, "You are correct");
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "N")
                    return;
                
            }

        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sergios";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{1}: Version {2} by {0}", appAuthor, appName, appVersion);
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game.", input);
        }

        static void PrintColorMessage(ConsoleColor color, string inp)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(inp);
            Console.ResetColor();
        }

    }
    
}
