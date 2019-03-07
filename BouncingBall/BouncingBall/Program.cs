using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBall
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double height = Convert.ToDouble(Console.ReadLine());
            double bounceRate = Convert.ToDouble(Console.ReadLine());
            double windowHeight = Convert.ToDouble(Console.ReadLine());

            int windowBounces = BallBounces(height, bounceRate, windowHeight);
            Console.WriteLine(windowBounces);
            Console.ReadLine();

        }

        // how many times will someone at a window see a ball bounce from height 
        static int BallBounces(double height, double bounceRate, double windowHeight)
        {
            // How many times will the mother see the ball pass in 
            // front of her window (including when it's falling and bouncing?)
            // set to 1 for the "fall" 
            int windowBounces = 1;

            // height is > 0, greater than window
            if (height < 0 || height <= windowHeight)
                return -1;

            //bounce can't be less than 0 or greater than 1
            if (bounceRate <= 0 || bounceRate >= 1)
                return -1;

            double bounceHeight = bounceRate * height;
            while (bounceHeight > windowHeight)
            {    
                bounceHeight *= bounceRate;
                windowBounces +=2;
            }
            return windowBounces;
        }
    }
}
