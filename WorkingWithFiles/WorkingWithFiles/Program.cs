using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    class Program
    {

        static void Main(string[] args)
        {
            var countOfWords = WordsInTextFile(@"\WorkingWithFiles.txt");
            Console.WriteLine("There are {0} words in this file.", countOfWords);
            Console.ReadLine();
        }

        /*
        1- Write a program that reads a text file and displays the number of words.
        */
        public static int WordsInTextFile(string path)
        {
            var text = File.ReadAllText(path);
            var counter = 0;

            foreach (var word in text.Split(' '))
                counter++;
            return counter;
            
        }


        /*
        2- Write a program that reads a text file and displays the longest word in the file.
        */
        //public static string LongestWordInFile(string path)
        //{

        //}
    }
}
