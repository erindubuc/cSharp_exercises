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
            Exercise1();
            Console.ReadLine();
        }

        /*
        1- When you post a message on Facebook, depending on the number of people who like your post, 
        Facebook displays different information.
        If no one likes your post, it doesn't display anything.
        If only one person likes your post, it displays: [Friend's Name] likes your post.
        If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] 
        others like your post.
        Write a program and continuously ask the user to enter different names, 
        until the user presses Enter (without supplying a name).
        Depending on the number of names provided, display a message based on the above pattern.
        */
        public static void Exercise1()
        {
            var likes = new List<string>(); 

            while(true)
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
        2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
        */


        /*
        3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        */



        /*
        4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        */


    
    }
}
