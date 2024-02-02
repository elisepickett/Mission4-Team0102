// See https://aka.ms/new-console-template for more information
using Mission4;

GamePrint gp = new GamePrint();

Console.WriteLine("Hello, World!");


// this is Mission 4 for group 0102, Emily Peterson, Elise Pickett, Lindsey Gordon, Patrick Nieves

using Mission4;
using System;

using System;

class Program
{
    static void Main()
    {
        //Welcome them into the game
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // Create game board array
        int[] game_board_array = new int[9];

        int choice = 0;

        while (true)
        {
            // Ask each player for their choice and update the game board array
            Console.Write("Please enter your move (1-9): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                if (choice >= 1 && choice <= 9)
                {
                    if (game_board_array[choice - 1] == 0) // Check if the cell is not already filled
                    {
                        game_board_array[choice - 1] = 1; // Update game board
                        break; // Valid input, exit the loop
                    }
                    else
                    {
                        Console.WriteLine($"Cell {choice} is already occupied. Please choose an empty cell.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine("Valid input received. Proceeding with the game...");

        // Checking if choice has already been guessed
        int numberToCheck = choice;

        // Assuming IsNumberAlreadyGuessed is defined elsewhere
        if (IsNumberAlreadyGuessed(game_board_array, numberToCheck))
        {
            Console.WriteLine($"Number {numberToCheck} has already been guessed.");
        }
        else
        {
            Console.WriteLine($"Number {numberToCheck} has not been guessed yet.");

            // Update gameboard array
            for (int i = 0; i < 9; i++)
            {
                if (choice == i)
                {
                    game_board_array[choice - i]++;
                }
            }
        }

        // Create an instance of the supporting class (assuming TicTacToeGame is defined elsewhere)
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

    // Placeholder for the IsNumberAlreadyGuessed function
    static bool IsNumberAlreadyGuessed(int[] game_board_array, int numberToCheck)
    {
        // Implementation logic here
        return false; // Placeholder return value
    }
}
