using System;

namespace Stack_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the title of the post:");

            var title = Console.ReadLine();
            var newPost = new Post(title);

            Console.WriteLine("Your post has been created!");

            Console.WriteLine("Type + to upvote and - to downvote.");
            while (true)
            {
                var input = Console.ReadLine();
                newPost.CountVotes(input);
                Console.WriteLine("Total votes:" + newPost.GetVotes() );
            }
        }
    }
}
