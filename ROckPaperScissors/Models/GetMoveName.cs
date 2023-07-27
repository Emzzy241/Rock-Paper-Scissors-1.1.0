using System;
using System.Collections.Generic;



namespace RockPaperScissors.Models
{


    // For getting the move name --> a string method
    // don't forget here; I also need to make use of the public access modifier.. there are other access modifiers like the protected internal, internal, private, private protected, protected
    // An access modifier controls how a class or a member of a class(int this case mathod) can be accessed


    public class GettingMoveNameClass
    {
        public string GetMoveName(int move)
        {
            switch (move)
            {
                case 1:
                    Console.WriteLine();
                    return "Rock";

                case 2:
                    Console.WriteLine();
                    return "Paper";

                case 3:

                    Console.WriteLine();
                    return "Scissors";

                default:
                    return "Unknown";
            }
        }

    }
}