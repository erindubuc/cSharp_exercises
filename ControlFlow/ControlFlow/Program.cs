using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //var num = Convert.ToInt32(Console.ReadLine());
            //Validate();
            //MaxNumber();
            //imageOrientation();
            SpeedCamera();

            Console.ReadLine();
        }

        /*
         *User enters a number between 1-10
         * Is it valid or invalid?
        */
        public static void Validate()
        {
            var num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1 && num <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        /*
        Take 2 numbers from console and display the maximum of the 2
        */
        public static void MaxNumber()
        {
            var input1 = Convert.ToInt32(Console.ReadLine());
            var input2 = Convert.ToInt32(Console.ReadLine());
            if (input1 > input2)
                Console.WriteLine(input1);
            else
                Console.WriteLine(input2);

        }

        /*
        Ask user to enter a height and width of an image.  Then tell if the image is 
        in landscape or portrait
        */
        public static void imageOrientation()
        {
            Console.WriteLine("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            var orientation = (height > width) ? ImageOrientation.portrait : ImageOrientation.landscape;
            Console.WriteLine("Your image is of {0} orientation.", orientation);
        }
        public enum ImageOrientation
        {
            portrait,
            landscape
        }

        /*
        Write a program for a speed camera. Write a program that asks the user to enter the speed limit. 
        Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, 
        program should display Ok on the console. If the value is above the speed limit, the program should 
        calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be 
        incurred and displayed on the console. If the number of demerit points is above 12, the program should 
        display License Suspended.
        */

        public static void SpeedCamera()
        {
            Console.WriteLine("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How fast were you going? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed > speedLimit)
            {
                var diff_in_speed = carSpeed - speedLimit;
                var penalty = 5;
                var demeritPoints = diff_in_speed / penalty;
                if (demeritPoints > 12)
                    Console.WriteLine("Lincense Suspended");
                else
                    Console.WriteLine("You have {0} Demerit Points.", demeritPoints);
                
            }
            else
                Console.WriteLine("Ok");

        }

    }
}
