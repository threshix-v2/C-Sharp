using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> playerOne = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();


            List<int> playerTwo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            while (playerOne.Count > 0 && playerTwo.Count > 0)
            {
                int i = 0;
                if (playerOne[i] > playerTwo[i])
                {
                    playerOne.Add(playerTwo[i]);
                    playerOne.Add(playerOne[i]);

                    playerTwo.RemoveAt(i);
                    playerOne.RemoveAt(i);
                }
                else if (playerTwo[i] > playerOne[i])
                {
                    playerTwo.Add(playerOne[i]);
                    playerTwo.Add(playerTwo[i]);
                    playerOne.RemoveAt(i);
                    playerTwo.RemoveAt(i);
                }
                else
                {
                    playerOne.RemoveAt(i);
                    playerTwo.RemoveAt(i);
                }
                
            }

            RevealWinner(playerOne, playerTwo);

        }

        private static void RevealWinner(List<int> playerOne, List<int> playerTwo)
        {
            if (playerOne.Count > 0)
            {
                int playerOneTotal = playerOne.Sum();
                Console.WriteLine($"First player wins! Sum: {playerOneTotal} ");
            }
            else if (playerTwo.Count > 0)
            {
                int playerTwoTotal = playerTwo.Sum();
                Console.WriteLine($"Second player wins! Sum: {playerTwoTotal}");
            }
        }
    }
}
