using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Song
    {
        private string name;
        private string author;
        private Song prev;
        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public void SetPrev(Song prev)
        {
            this.prev = prev;
        }
        public string Title()
        {
            return name + " " + author;
        }
        public override bool Equals(object d)
        {
            return (d != null) && (name.Equals(((Song)d).name)) && (author.Equals(((Song)d).author));
        }
    }
}
