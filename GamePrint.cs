using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class GamePrint
    {
        public void PrintBoard()
        {
            //for loops to print board depending on boardSize variable
            //needs to be updated to receive the userInput array
            int boardSize = 3;
            for(int i = 0; i < boardSize; i++)
            {
                for(int j = 0; j < boardSize; j++)
                {
                    Console.Write("X");
                    Thread.Sleep(400);
                }
                Console.WriteLine("");
            }
        }
        public void CheckForWinner()
        {
            //figure out combinations to determine a winner
            //use variables in combinations; variable inputs here depend on how Program.cs input is received
            string xInput = "";
            string oInput = "";
        }
    }
}
