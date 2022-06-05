using System;
using System.Threading;
 
namespace RockPaperScissors
{
    class Game {         
        static void Main(string[] args)
        {
            // Display intro message
            Console.WriteLine("A Game of Rock Paper Scissors");

            while (true)
            {
                // Question user will see
                Console.WriteLine("Do you want to play? (y/n):");
                // Capture keyboard input from user and save it to variable
                string wantToPlay = Console.ReadLine();

                // variable = (condition) ? expressionTrue :  expressionFalse;
                // string result = (wantToPlay == "y") ? playGame() : "Ok, bye!";
                // Console.WriteLine(result);
                if (wantToPlay == "y")
                {
                    playGame();
                    break;
                }
                else if (wantToPlay == "n")
                {
                    Console.WriteLine("Ok, bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("That is not an option.");
                    Console.WriteLine("Please type y or n.\n");
                    int myDelay = 2000;
                    Thread.Sleep(myDelay);
                }
            }
        }

        static void playGame()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Options:\n" +
                                "1. Rock\n" +
                                "2. Paper\n" +
                                "3. Scissors\n" +
                                "4. Exit");
                Console.WriteLine("Pick 1, 2, 3, or 4:");
                string userPick = Console.ReadLine();

                if (userPick == "1")
                {
                    Console.WriteLine("You picked Rock");
                }
                else if (userPick == "2")
                {
                    Console.WriteLine("You picked Paper");
                }
                else if (userPick == "3")
                {
                    Console.WriteLine("You picked Scissors");
                }
                else if (userPick == "4")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid option.");
                    Console.WriteLine("Please pick again.");
                    // How long the delay will be in milliseconds
                    int myDelay = 2000;
                    // Delay program for 2 seconds
                    Thread.Sleep(myDelay);
                    continue;
                }

                Random rnd = new Random();
                int computerPick = rnd.Next(1, 4);

                if (computerPick == 1)
                {
                    Console.WriteLine("Computer picked Rock");
                }
                else if (computerPick == 2)
                {
                    Console.WriteLine("Computer picked Paper");
                }
                else if (computerPick == 3)
                {
                    Console.WriteLine("Computer picked Scissors");
                }
                else
                {
                    Console.WriteLine("Umm... somehow the computer cheated!");
                }

                // Convert string to int
                int userPickInt = Int16.Parse(userPick);

                if (userPickInt == computerPick)
                {
                    Console.WriteLine("You tied");
                    int myDelay = 1500;
                    Thread.Sleep(myDelay);
                    continue;
                }
                else if ((userPickInt == 1 && computerPick == 3) ||
                         (userPickInt == 2 && computerPick == 1) ||
                         (userPickInt == 3 && computerPick == 2))
                {
                    Console.WriteLine("You win!");
                    int myDelay = 1500;
                    Thread.Sleep(myDelay);
                    continue;
                }
                else
                {
                    Console.WriteLine("You lose");
                    int myDelay = 1500;
                    Thread.Sleep(myDelay);
                    continue;
                }
            }
        }
    }
}


// to run type csc rps.cs
// that will make an .exe (executable) version of the file
// C# needs to compile every time changes are made
// Thus, when changes are made, need to run csc rps.cs again
// then type .\rps.exe
// you should see program run within the console


/* Questions I have:
- How do you ask for input on the same line as the question?
- Can I make text display as bold?
- How does the "if statement on one line" work?
    * Do the true/false options hve to be simple strings?
 */


 /* URLs I've Used
 - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
 - https://www.codegrepper.com/code-examples/csharp/c%23+randomly+generate+numbers+between+1+and+3
 - https://www.delftstack.com/howto/csharp/how-to-make-a-dealy-in-csharp/
 - https://www.geeksforgeeks.org/program-to-print-a-new-line-in-c-sharp/#:~:text=By%20using%3A%20%5Cn%20%E2%80%93%20It,)%20%E2%80%93%20It%20prints%20new%20line.
 - https://www.w3schools.com/cs/cs_type_casting.php 
 */