using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wanna play a game?");
            Console.WriteLine("Choose your difficulty level:");
            Console.WriteLine("Press 1: Easy Peasy Lemon Squeezy");
            Console.WriteLine("Press 2: Sure, Jan");
            Console.WriteLine("Press 3: Difficult Difficult Lemon Difficult");
            Console.WriteLine("Press 4: So you have chosen death");
            string level = Console.ReadLine();

            switch (level) {
                case "1": 
                gameTime(8);
                break;
                case "2":
                gameTime(6);
                break;
                case "3":
                gameTime(4);
                break;
                case "4":
                Console.WriteLine("Cheater Cheater Pumpkin Eater");
                gameTime(99);
                break;
                default:
                Console.WriteLine("USELESS");
                break;
            };
            
            //guess secret number
            //prompt for user's guess
            //take input and save as variable
            //display user's guess
            //variable secret number 42
            //Compare secret number vs number they guessed
            //success or failure message
            //Give users four chances to guess
            //Contine to display success or failure message
            //Display current number of guesses
            //end loop early if they guess correctly 
            //use a random number between 1 and 100
            //prompt should display number of guesses they have left
            //tell if guess is too high or too low
            //prompt the user for difficulty level: Easy 8, Medium 6, Hard 4
            //cheater level --- until they guess correctly
           void gameTime (int attempts) {
             
            int i = 0;
            int secretNumber = new Random().Next(0, 100);
            while (i < attempts) {            
            Console.WriteLine("Please guess the secret number.");
            Console.WriteLine($"Guesses remaining {attempts - i}");
            string userInput = Console.ReadLine();
            int parsedUserInput = int.Parse(userInput);

            // Console.WriteLine($"You guessed {userInput}.");

            
            
            if (parsedUserInput == secretNumber)
            {
                Console.WriteLine($"The answer to the universe is {secretNumber}");
                break;
            }
            else
            {
                string help = parsedUserInput > secretNumber ? "The rent is too damn high" : "Too low. Cockroaches for sure.";
                Console.WriteLine($"WRONG-O! {help}");
                if (attempts != 99) {
                    i++;
                }
                
            }
            }
            }
        }
        
    }
}