using System;
using System.Collections.Generic;


namespace RockPaperScissors.Models
{
    public class DetermineWInnerClass
    {

        
        public int DetermineWinner(int playerMove, int computerMove)
        {
            // all what this integer method does is that it determines the move of a player,
            // First, it takes in 2 integer variables which are both the player and computer move; dont forget we have been able to 
            // determine both player an dcomputer moves in our GetComputerMove() and GetPlayerMove() methods respectively... The computers own we used Random object and .Next() and the players own we used a while loop


            // the else if is to handle all of the different results we can get which is 1-3
            if (playerMove == computerMove)
            {
                Console.WriteLine("");

                return 0; // Tie

            }
            else if ((playerMove == 1 && computerMove == 3) ||
                     (playerMove == 2 && computerMove == 1) ||
                     (playerMove == 3 && computerMove == 2))
            {
                return 1; // Player wins
            }

            // With the else statement we return -1 to tell C# that the user lost and computer won
            else
            {
                return -1; // Computer wins
            }
        }




        
    }
}