using System;
using System.Collections.Generic;

// importing my C# business logic file
using RockPaperScissors.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Rock Paper Scissors Game designed by Dynasty");
        Console.WriteLine();
        Console.WriteLine();


        // How the game works, the user can enter in any of the moves below
        // The computer move is generated by working with the C# in-built Random move, and we also made use of .Next() that takes in 2 arguments(the min and the max that we want)

        // The while(true here) is saying that while the game is on i.e user hasnt enterred the ctrl+c that kills the console, then the game can continue playing
        while (true)
        {


            // Tring to add scores now for both computer and the user
            // int compScore = 0;
            // int userScore = 0;



            Console.WriteLine("\nChoose your move:");
            Console.WriteLine("1 - Rock");
            Console.WriteLine("2 - Paper");
            Console.WriteLine("3 - Scissors");
            Console.WriteLine("0 - Quit");

            Console.WriteLine();


            // What I need to hear now is to ensure reinstantiate my newly written C# class in business logic file to ensure I can call the GetPlayerMove() method

            GetPlayerMoveClass GetMePlayerMove = new GetPlayerMoveClass();



            int playerMove = GetMePlayerMove.GetPlayerMove();
            // Since the Above generates no error; I have successfully been able to separate concerns(i.e separating business logic and UI logic code into different files)
            if (playerMove == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Thanks for playing! Goodbye!");
                break;
                // No switch-case statement and this break sworks to help us kill our console

            }

            // Making a new instance of the class I created so it can help me call my newly written 

            // Making a new instance of my class here so I can be able to make use of the 2 methods(DetermineWinner() and GetComputerMove())
            GetComputerMoveClass ComputerMove = new GetComputerMoveClass();
            int myComputerMove = ComputerMove.GetComputerMove();

            // since the string method GetMoveName has been moved to my business MOdels directory(business logic code) I also need to make changes here and tell C# how to get to the method

            Console.WriteLine();
            GettingMoveNameClass NewMove = new GettingMoveNameClass();
            Console.WriteLine($"Computer chose: {NewMove.GetMoveName(myComputerMove)}");
            Console.WriteLine();


            // I Have to keep reinstanting just so I am able to understand that I am talking about 2 methods
            // I can still use the GettingCompMove object I reinstantiated above here but I want to be able to separate concern; because using GettingCompMove for getting computer move and determining winner might not be understnadable for me


            DetermineWInnerClass DeterminingTheWinner = new DetermineWInnerClass();
            int result = DeterminingTheWinner.DetermineWinner(playerMove, myComputerMove);
            if (result == 0)
            {
                Console.WriteLine("=======> It's a tie! <=======");
                Console.WriteLine("Lets GO Again");

            }
            else if (result == 1)
            {

                Console.WriteLine("=======> Congratulations! You win! :) <=======");


                // int newCompScore = compScore;
                // int newUserScore = userScore + 1;



                // Console.WriteLine($"Computer : {newCompScore} and User: {newUserScore}");
                // Console.WriteLine();

            }

            else
            {
                Console.WriteLine("=======> Sorry, you lose! :( <=======");
            }
        }
    }
}