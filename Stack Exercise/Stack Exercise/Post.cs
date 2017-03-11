using System;

namespace Stack_Exercise
{
    public class Post
    {
        public Post(string title)
        {
            
            var creationDate = DateTime.Now;
        }

        private int _upvote;
        private void UpVote()
        {
            _upvote++;
        }

        public int GetUpVote()
        {
            return _upvote;
        }

        private int _downvote;
        private void DownVote()
        {
            _downvote++;
        }

        public int GetDownVote()
        {
            return _downvote;
        }

        public void CountVotes(string input)
        {
            if (input == "+")
                UpVote();
            else if (input == "-")
                DownVote();
            else 
                Console.WriteLine("Unexpected input. Please try again.");
        }

        public int GetVotes()
        {
            return GetUpVote() - GetDownVote();
        }

    }
}