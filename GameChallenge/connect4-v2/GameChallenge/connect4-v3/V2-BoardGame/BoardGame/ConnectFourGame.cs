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

        public void ApplyMove(int column)
        {
            State state = MovesCounter % 2 == 0 ? State.X : State.O;
            for (int row = _board.GetLength(0) - 1; row >= 0; row--)
            {
                if (_board[row, column] < 0)
                {
                    Console.WriteLine("You can only choose a column from 0-6");
                    continue;
                }

                if (_board[0, column] != State.empty)
                {
                    Console.WriteLine("Oops!This spot is already taken!");
                    continue;
                }

                else
                {
                    _board[row, column] = state;
                    Console.WriteLine($"{_board[row, column]} you moved to {column}");



                }
            }

            MovesCounter++;
        }

        //public State GetStateOfCoordinateint yCoordinate)
        //{
           
        //    return _board[xCoordinate, yCoordinate];
        //}
       

    }

}