using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //Run Get app info function
            GetAppInfo();

            //Ask for users name
            GreetUser();

            while (true)
            {
                // Set correct number
                //int correctNumber = 7;

                //Create new random object
                Random random = new Random();

                // Set correct number
                int correctNumber = random.Next(1, 11);

                // Initial guess variable
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //Guess not correct
                while (guess != correctNumber) {

                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess)) {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to incorrect number
                    if(guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
                //Output success message

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        //Get and display app info
        static void GetAppInfo() {
            //Setup Variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Shivom Paudel";

            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();
        }

        //Ask users name and greet
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}