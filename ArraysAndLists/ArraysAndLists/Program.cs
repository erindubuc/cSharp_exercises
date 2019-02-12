using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            Exercise4();
            Console.ReadLine();
        }

        /*
        Write a program and continuously ask the user to enter different names, 
        until the user presses Enter (without supplying a name).
        Depending on the number of names provided, display a message based on the above pattern.
        */
        public static void Exercise1()
        {
            var likes = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name, or press Enter without a name: ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                likes.Add(input);
            }
            if (likes.Count == 1)
                Console.WriteLine("{0} likes your post.", likes[0]);
            else if (likes.Count == 2)
                Console.WriteLine("{0} and {1} like your post.", likes[0], likes[1]);
            else if (likes.Count > 2)
                Console.WriteLine("{0}, {1}, and {2} like your post.", likes[0], likes[1], likes[2]);
            else
                Console.WriteLine();
        }

        /*
        2- Write a program and ask the user to enter their name. Use an array to reverse the name and 
        then store the result in a new string. Display the reversed name on the console.
        */
        public static void Exercise2()
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            var nameArray = name.ToCharArray(0, name.Length);
            Array.Reverse(nameArray);

            foreach (char c in nameArray)
                Console.WriteLine(c);

        }


        /*
        3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, 
        display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, 
        sort them and display the result on the console.
        */
        public static void Exercise3()
        {

            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number: ");
                int newNum = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(newNum))
                {
                    Console.WriteLine("Oops! You already entered {0}.  Try again: ", newNum);
                    continue;
                }

                numbers.Add(newNum);

            }
            numbers.Sort();
            foreach (int number in numbers)
                Console.WriteLine(number);
        }


        /*
        4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
        The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        */
        
        public static void Exercise4()
        {

            var numbers = new List<int>();
            
            while(true)
            {
                Console.WriteLine("Enter a number, or type \"Quit\": ");
                var input = Console.ReadLine();

                if (input == "Quit" || input == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniqueNums = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniqueNums.Contains(number))
                    uniqueNums.Add(number);
            }
            Console.WriteLine("The unique numbers are: ");
            foreach (var number in uniqueNums)
                Console.WriteLine(number);
             
        }
 


    }
}

