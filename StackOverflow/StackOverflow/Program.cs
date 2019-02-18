using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    /*
    Design a class called Post.This class models a StackOverflow post.It should have properties for title, 
    description and the date/time it was created. We should be able to up-vote or down-vote a post. 
    We should also be able to see the current vote value.
    In the main method, create a post, up-vote and down-vote it a few times and then display the the current vote value.
    In this exercise, you will learn that a StackOverflow post should provide methods for up-voting and down-voting.
    You should not give the ability to set the Vote property from the outside, because otherwise, you may accidentally 
    change the votes of a class to 0 or to a random number, and this is how we create bugs in our programs. 
    The class should always protect its state and hide its implementation detail.
    */

    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post
            {
                Title = "C# Classes Help",
                Description = "Confusion about when to use private and public",
            };

            post.AddDownVote();
            post.AddUpVote();
            post.AddUpVote();
            post.AddUpVote();
            post.ShowActualPost();
            Console.ReadLine();
        }

        public class Post
        {
            private string _title;
            private string _description;
            private DateTime _createdOn { get; } = DateTime.UtcNow;

            public string Title { get => _title; set => _title = value; }
            public string Description { get => _description; set => _description = value; }
            public int _upVotes { get; private set; }
            public int _downVotes { get; private set; }

            public int AddUpVote()
            {
                return _upVotes++;
            }

            public int AddDownVote()
            {
                return _downVotes++;
            }

            public int TotalVoteCount()
            {
                return _upVotes + _downVotes;
            }

            public void ShowActualPost()
            {
                Console.WriteLine("Date Posted: " + _createdOn.ToLongDateString());
                Console.WriteLine();
                Console.WriteLine("Title: " + Title);
                Console.WriteLine();
                Console.WriteLine("Brief Description: " + Description);
                Console.WriteLine();
                Console.WriteLine("Thumbs-up: {0}   Thumbs-down: {1}", _upVotes, _downVotes);
                Console.WriteLine("Total Votes for this post: {0}", TotalVoteCount());
            }
        }

    }
}
