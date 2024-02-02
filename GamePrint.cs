using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Mission4
{
    public class GamePrint
    {
        // Method to print the current state of the game board
        public void PrintBoard(int[] gameBoardArray)
        {
            Console.WriteLine("Current Game Board:");
            Console.WriteLine("-------------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    int index = i * 3 + j;
                    Console.Write($"{GetSymbol(gameBoardArray[index])} | ");
                }
                Console.WriteLine("\n-------------");
            }
        }

        // Method to update the game board array with player's move
        public void UpdateBoard(int[] gameBoardArray, int choice, int player)
        {
            gameBoardArray[choice - 1] = player; // Update game board with player's move
        }

        // Method to check if the game board is full
        public bool IsBoardFull(int[] gameBoardArray)
        {
            foreach (int cell in gameBoardArray)
            {
                if (cell == 0) // If any cell is empty, board is not full
                    return false;
            }
            return true; // If no empty cell found, board is full
        }

        // Method to check if there's a winner
        public bool CheckForWinner(int[] gameBoardArray)
        {
            // Check rows, columns, and diagonals for a win
            for (int i = 0; i < 3; i++)
            {
                if (gameBoardArray[i] != 0 &&
                    gameBoardArray[i] == gameBoardArray[i + 3] &&
                    gameBoardArray[i] == gameBoardArray[i + 6])
                {
                    return true; // Check rows
                }

                if (gameBoardArray[i * 3] != 0 &&
                    gameBoardArray[i * 3] == gameBoardArray[i * 3 + 1] &&
                    gameBoardArray[i * 3] == gameBoardArray[i * 3 + 2])
                {
                    return true; // Check columns
                }
            }

            if (gameBoardArray[0] != 0 &&
                gameBoardArray[0] == gameBoardArray[4] &&
                gameBoardArray[0] == gameBoardArray[8])
            {
                return true; // Check diagonal (top-left to bottom-right)
            }

            if (gameBoardArray[2] != 0 &&
                gameBoardArray[2] == gameBoardArray[4] &&
                gameBoardArray[2] == gameBoardArray[6])
            {
                return true; // Check diagonal (top-right to bottom-left)
            }

            return false;
        }

        // Method to get the current player
        public int GetCurrentPlayer(int turn)
        {
            // Assuming there are two players, alternate between player 1 and player 2
            return turn % 2 == 0 ? 1 : 2;
        }

        // Method to switch to the next player for the next turn
        public void SwitchPlayer(ref int turn)
        {
            turn++; // Increment turn to switch to the next player
        }

        // Method to check if the game is over
        public bool IsGameOver(int[] gameBoardArray)
        {
            // Check for a winner or if the board is full
            return CheckForWinner(gameBoardArray) || IsBoardFull(gameBoardArray);
        }

        // Method to convert player number to symbol (X or O)
        private char GetSymbol(int player)
        {
            return player == 1 ? 'X' : (player == 2 ? 'O' : ' ');
        }
    }
}
