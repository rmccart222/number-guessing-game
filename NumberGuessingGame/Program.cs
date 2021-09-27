using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates random number variable
            Random r = new Random();

            //Sets value of r variable between 10 and 100
            int winNum = r.Next(0, 100);

            //Creates Boolean true/false statement where win is defaulted to false
            bool win = false;

            /* Start of the "do" block code runs through these if else statements
            until the correct number is guessed */
            do
            {
                Console.Write("Guess a number between 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum) 
                {
                    Console.WriteLine("Too high! Guess again:");
                }

                else if (i < winNum)
                {
                    Console.WriteLine("Too Low! Guess again:");
                }

                else if (i == winNum)
                {
                    Console.WriteLine("You won!!");
                    win = true;
                }

                //Allows for breaks between guesses
                Console.WriteLine();

            } 
            
            //This while statement loops the code if the incorrect number is guessed
            while (win == false);

            //Upon winning this code runs
            Console.WriteLine("Thank you for playing the game!");
            Console.Write("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}
