﻿using System;
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
            var game = new BoardGame();
            game.DrawGameBoard(6, 30);
        
            Console.ReadLine();
        }
    }
}