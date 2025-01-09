using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Post
    {
        private string _title;
        private string _description;
        private DateTime _created;
        private int _votes;
        public Post(string title, string description)
        {
            this._title = title;
            this._description = description;
            this._created = DateTime.Now;
        }
        public void UpVote()
        {
            _votes++;
        }
        public void DownVote()
        {
            _votes--;
        }
        public void Display()
        {
            Console.WriteLine("Title: " + _title);
            Console.WriteLine("Description: " + _description);
            Console.WriteLine("Created: " + _created);
            Console.WriteLine("Votes: " + _votes);
        }
    }
}
