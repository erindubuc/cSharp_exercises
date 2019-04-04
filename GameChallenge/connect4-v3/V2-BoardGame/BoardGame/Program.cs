using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    // Brittney: BoardGame Code Review

    // Program works correctly, it was just not checking for height and width = 30
    // Program is very well Objectified, it has separate class file
    // Found usage of var in place of int, mentioned to Brittney about the same
    // Usage of proper variable names for DrawBoard, DrawTopBorder and DrawCells 
    // methods (in place of variables like 'i' and 'j') 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Height of board: ");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Width of board: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Board board;

            if (IsHeightAndWidthValid(height, width))
                board = new Board(height, width);
            else
                Console.WriteLine("Height and width must be between 2 and 30.\n");

            Console.ReadLine();
        }

        public static bool IsHeightAndWidthValid(int height, int width)
        {
            return height > 2 && height <= 30 && width > 2 && width <= 30;
        }    
    }
}
