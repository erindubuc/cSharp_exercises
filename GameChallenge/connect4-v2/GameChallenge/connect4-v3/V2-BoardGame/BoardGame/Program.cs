using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Height of board: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Width of board: ");
            int width = Convert.ToInt32(Console.ReadLine());
            */

            //Board board = new Board();
            ConnectFourGame game = new ConnectFourGame();
            while (ConnectFourGame.MovesCounter < 42)
            {
                Console.WriteLine("Enter a column from 0-6");
                int column = Convert.ToInt32(Console.ReadLine());

               
                game.ApplyMove(column);

                Console.WriteLine();
            }

            Console.ReadLine();
        }
        

    }
}
