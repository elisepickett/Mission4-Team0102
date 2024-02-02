using System;
using Mission4;
// this is Mission 4 for group 0102, Emily Peterson, Elise Pickett, Lindsey Gordon, Patrick Nieves

class Program
{
    static void Main()
    {
        //declare GamePrint class
        GamePrint game = new GamePrint();

        //Welcome them into the game and declare game board array
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        int[] game_board_array = new int[9];
        int turn = 0;

        //while loop to print game board until false
        while (true)
        {
            //call PrintBoard method to print the board before each turn
            game.PrintBoard(game_board_array);

            int choice = 0;

            //while loop to gather users' choice
            while (true)
            {
                // Ask each player for their choice and update the game board array
                Console.Write($"Player {game.GetCurrentPlayer(turn)}, please enter your move (1-9): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    if (choice >= 1 && choice <= 9)
                    {
                        // Check if the cell is not already filled
                        if (game_board_array[choice - 1] == 0)
                        {
                            // Update game board
                            game_board_array[choice - 1] = game.GetCurrentPlayer(turn);
                            break;// Valid input, exit the loop
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

            //if statement to call GamePrint class and check if game is over; i.e. winner or all cells occupied
            if (game.IsGameOver(game_board_array))
            {
                game.PrintBoard(game_board_array);

                if (game.CheckForWinner(game_board_array))
                {
                    Console.WriteLine($"Player {game.GetCurrentPlayer(turn)} wins!");
                }
                else
                {
                    Console.WriteLine("It's a tie! The board is full.");
                }
                return;
            }

            game.SwitchPlayer(ref turn);
        }
    }
}
