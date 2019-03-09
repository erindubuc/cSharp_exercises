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
            var g = new Game();
            g.DrawBoard(6, 30);
        
            Console.ReadLine();
        }
    }
}
