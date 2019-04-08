using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class ConnectFourGame : Board
    {
        //int player1;
        //int player2;
        //int[] redCheckers;
        //int[] yellowCheckers;
        //string[] moves;
        public static int MovesCounter { get; private set; }
        private State[,] _board = new State[6, 7];

        public ConnectFourGame() 
        {

            for (int row = 0; row < _board.GetLength(0); row++)
            {
                for (int column = 0; column < _board.GetLength(1); column++)
                {
                    _board[row, column] = State.empty;
                }
                    
            }
        }

        // want to change this to just accept the yCoordinate - only need to worry about the column
        public void ApplyMove(int xCoordinate, int yCoordinate)
        {
                       
            if (xCoordinate < 0 || xCoordinate > 6)
            {
                Console.WriteLine("You can only choose an x-coordinate from 0-6");
                throw new ArgumentOutOfRangeException();
            }

            if (yCoordinate < 0 || yCoordinate > 5)
            {
                Console.WriteLine("You can only choose a y-coordinate from 0-5");
            }

            
            if (_board[xCoordinate, yCoordinate] != State.empty)
            {
                Console.WriteLine("Oops! This spot is already taken. Please try again.");

            }
            
            // if spot below chosen spot is empty
            if (_board[xCoordinate, yCoordinate + 1] == State.empty)
            {
                Console.WriteLine("There can't be an empty spot below your chosen spot! Gravity takes over! Please try again.");
            }
            
             _board[xCoordinate,yCoordinate] = MovesCounter % 2 == 0 ? State.X : State.O;
            Console.WriteLine($"{_board[xCoordinate, yCoordinate]}, you moved to {xCoordinate}, {yCoordinate}");

            MovesCounter++;
        }

        public State GetStateOfCoordinate(int xCoordinate, int yCoordinate)
        {
           
            return _board[xCoordinate, yCoordinate];
        }
       

    }

}