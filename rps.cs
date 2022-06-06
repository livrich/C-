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

                // I couldn't get this form of "if" statement to work once I added the function call
                // variable = (condition) ? expressionTrue :  expressionFalse;
                // string result = (wantToPlay == "y") ? playGame() : "Ok, bye!";
                // Console.WriteLine(result);

                if (wantToPlay.ToLower() == "y")
                {
                    // call function
                    playGame();
                    // exit function back to here, then exit this loop, which ends program
                    break;
                }
                else if (wantToPlay.ToLower() == "n")
                {
                    Console.WriteLine("Ok, bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("That is not an option.");
                    Console.WriteLine("Please type y or n.\n");
                    // How long the delay will be in milliseconds
                    int myDelay = 2000;
                    // Delay program for 2 seconds
                    Thread.Sleep(myDelay);
                }
            }
        }

        // Logic for actual game
        static void playGame()
        {
            // Will keep game going until told to exit
            while (true)
            {
                // Blank line helps things look better
                Console.WriteLine("");
                // Options that can be selected
                Console.WriteLine("Options:\n" +
                                "1. Rock\n" +
                                "2. Paper\n" +
                                "3. Scissors\n" +
                                "4. Exit");
                Console.WriteLine("Pick 1, 2, 3, or 4:");
                string userPick = Console.ReadLine();

                // Say what user did
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
                    // Make sure the user picks a valid option
                    Console.WriteLine("That is not a valid option.");
                    Console.WriteLine("Please pick again.");
                    // How long the delay will be in milliseconds
                    int myDelay = 2000;
                    // Delay program for 2 seconds
                    Thread.Sleep(myDelay);
                    continue;
                }

                // How to set up getting a random number
                Random rnd = new Random();
                // Pick a random number between 1 and 3
                int computerPick = rnd.Next(1, 4);

                // Say what computer did
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

                // Different win, lose, and tie conditions
                // Tie condition
                if (userPickInt == computerPick)
                {
                    Console.WriteLine("You tied");
                    // Delay 1.5 seconds
                    int myDelay = 1500;
                    // Meant to give user time to read result
                    // before menu options are displayed again
                    Thread.Sleep(myDelay);
                    // Skip checking the rest of the loop
                    continue;
                }
                // User win conditions
                else if ((userPickInt == 1 && computerPick == 3) ||
                         (userPickInt == 2 && computerPick == 1) ||
                         (userPickInt == 3 && computerPick == 2))
                {
                    Console.WriteLine("You win!");
                    int myDelay = 1500;
                    Thread.Sleep(myDelay);
                    continue;
                }
                // User lose condition
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