using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Board newBoard = new Board();
            newBoard.DrawGameBoard();
            Game newGame = new Game();

            Console.ReadLine();
        }
    }
}
