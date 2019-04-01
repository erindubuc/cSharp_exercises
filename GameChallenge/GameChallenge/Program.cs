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
            BoardGame game = new BoardGame();
            game.DrawGameBoard(6, 7);
        
            Console.ReadLine();
        }
    }
}
