using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            Exercise5();

            Console.ReadLine();
        }

        /*
        1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
        Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or 
        "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        */
        public static void Exercise1()
        {
            Console.WriteLine("Enter a few numbers, separated with hyphens (ex: 12-23-34): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));
            // Sort the numbers first to see if they are incremented by 1
            numbers.Sort();
            // Set to true, so loop can break if NOT consecutive
            var isConsecutive = true;

            for (var i = 1; i < numbers.Count; i++)

            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine("These numbers are '{0}'", message);

        }

        /*
        2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
        If the user simply presses Enter, without supplying an input, exit immediately; otherwise, 
        check to see if there are duplicates. If so, display "Duplicate" on the console.
        */
        public static void Exercise2()
        {
            Console.WriteLine("Enter a few numbers, separated with hyphens (ex: 12-23-34): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;
         
            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));
          
            var uniqueNums = new List<int>();
            var hasDuplicate = false;
            foreach (var number in numbers)
            {
                if (uniqueNums.Contains(number))
                {
                    hasDuplicate = true;
                    break;
                }
                else
                    uniqueNums.Add(number);
                
            }
            if(hasDuplicate)
                Console.WriteLine("Duplicate within numbers");
        }


        /*
        3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
        A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        */
        public static void Exercise3()
        {
            Console.WriteLine("Enter a time value in the 24-hour format (e.g. 19:00): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            else if(input.Length != 5)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var validTime = input.Split(':');
            var hours = Convert.ToInt32(validTime[0]);
            var minutes = Convert.ToInt32(validTime[1]);

            if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid Time");
        }


        /*
        4- Write a program and ask the user to enter a few words separated by a space. Use the words to create 
        a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". 
        Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program 
        should still display "NumberOfStudents".
        */
        public static void Exercise4()
        {
            Console.WriteLine("Enter a few words, separated by spaces: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;
            else
            { 
                //input.ToLower();
                string makeFirstCapital = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
                string PascalCase = makeFirstCapital.Replace(" ", "");
                Console.WriteLine(PascalCase);
            }
        }

        /*
        5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. 
        So, if the user enters "inadequate", the program should display 6 on the console.
        */
        public static void Exercise5()
        {
            Console.WriteLine("Enter an English word: ");
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

            var count = 0;
            foreach (char c in input)
            {
                if (vowels.Contains(c))
                    count++;
                else
                    continue;
            }

            if (count == 0)
                Console.WriteLine("There are no vowels in your word.");
            else if (count == 1)
                Console.WriteLine("There is {0} vowel in your word.", count);
            else
                Console.WriteLine("There are {0} vowels in your word.", count);

        }
    }
}
