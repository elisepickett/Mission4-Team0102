// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// this is Mission 4 for group 0102, Emily Peterson, Elise Pickett, Lindsey Gordon, Patrick Nieves

using Mission4;
using System;

class Program
{
    static void Main()
    {
        //Welcome them into the game
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        //Create game board array
        int[] game_board_array = new int[9]

        //Ask each play for their choice and update the game board array
        choice = Console.Readline("Please enter your move (1-9):")

        //checking if choice has already been guessed
        int numberToCheck = choice;

        if (IsNumberAlreadyGuessed(game_board_array, numberToCheck))
        {
            Console.WriteLine($"Number {numberToCheck} has already been guessed.");
        }
        else
        {
            Console.WriteLine($"Number {numberToCheck} has not been guessed yet.");
            //Update gameboard array
            for (i = 0; int < 9 : i++)
            {
                if (choice == i)
                {
                    game_board_array[choice - i]++;
                }
            }

        }
        // Create an instance of the supporting class
        TicTacToeGame game = new TicTacToeGame();

        // Loop for each turn until there's a winner or the board is full
        while (!game.IsGameOver())
        {
            // Print the current state of the board
            game.PrintBoard();

            // Get the current player's choice and update the board
            game.TakeTurn();

            // Check for a winner
            if (game.CheckForWinner())
            {
                // Print the final state of the board
                game.PrintBoard();

                // Announce the winner
                Console.WriteLine($"Player {game.GetCurrentPlayer()} wins!");
                return; // Exit the game
            }

            // Switch to the next player for the next turn
            game.SwitchPlayer();
        }

        // If the loop completes and there is no winner, it's a tie
        Console.WriteLine("It's a tie! The board is full.");
    }
}