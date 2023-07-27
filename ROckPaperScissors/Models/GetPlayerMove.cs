using System;
using System.Collections.Generic;

// The Model for my Application(this can also be the business logic of my C# app)

namespace RockPaperScissors.Models
{

    public class GetPlayerMoveClass
    {

        // This file will be for generating both the Player and Computers move

        

        public int GetPlayerMove()
        {

            // Tring to add scores now for both computer and the user
            // int compScore;

            // int userScore;


            // Running the while loop here helps me ensure that my user is still in the game; without getting out of the console with(ctrl+c)
            // THe int.TryParse() method takes in a string as an argument and then it outputs an integer for us
            // Before, the way I would naturally do that would have been to first store Console.ReadLine()
            // a string method) and then later, I will now have to write another variable again that will convert the string to integer using(int.Parse()) but with the int.TryParse() I am able to dry my code by one line


            while (true)
            {



                // The below if statemet first I parse the string COnsole.ReadLine() would be returning for me into an integer
                // next, I told C# that if the range of the integer(move) value is 0-3, then return me that move value
                // But if its not, give the user a 2nd chance and then run it again
                // Its like a loop that will only progress forward when my user enters a value thats between 0 and 3 inclusive

                if (int.TryParse(Console.ReadLine(), out int move) && (move >= 0 && move <= 3))
                {
                    return move;
                }
                Console.WriteLine("Invalid input. Please choose a valid move.");
            }
        }


        // Writing a method for counting scores
        // public int CountingScore(int userScore, int computerScore)
        // {
        //     userScore = 0;
        //     computerScore = 0;


        //     RPSGenerator myWinnerDeterminer = new RPSGenerator();
            
        //     if()
        // }

    }

}




// The below can be regarded as a function but since I want to carry out a separation of concern(logic)
// I would now be writing it as a public method on the class RPSGenerator, and access it via my Entry Point file(Program.cs ---> the one housing my Main() function)


// static int GetPlayerMove()
// {
//     // Running the while loop here helps me ensure that my user is inputting what I want
//     // THe int.TryParse() method takes in a string as an argument and then it outputs an integer for us
//     // Before, the way I would naturally do that would have been to first store Console.ReadLine(
//     // a string method) and then later, I will now have to write another variable again that will convert the string to integer using(int.Parse()) but with the int.TryParse() I am able to dry my code by one line


//     while (true)
//     {
//         if (int.TryParse(Console.ReadLine(), out int move) && (move >= 0 && move <= 3))
//         {
//             return move;
//         }
//         Console.WriteLine("Invalid input. Please choose a valid move.");
//     }
// }


// C# doesn;t really have functions because there is no return statement here; 
// But C# has methods with which we can write for our classes and call those method 