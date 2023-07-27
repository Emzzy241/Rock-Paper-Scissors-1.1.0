using System;
using System.Collections.Generic;


namespace RockPaperScissors.Models
{
    public class GetComputerMoveClass
    {
        
        // Moving the GetComputerMove() & DetermineWInner() method here... I no longer want everything on a single file; thats why I am putting it in this class


        // Making use of just the static access modifier; this method would be inaccessible in other files(i.e only in this file will access be granted to this method)
        // But thanks to the public access modifier, I can ensure my method is accessible accross everywhere in my application

        public int GetComputerMove()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

    }
}