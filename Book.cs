using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentals
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public int PublishingYear { get; set; }

        public Book() { }
        public Book(string title, string author, int publishingYear, Genre genre)
        {
            this.Title = title;
            this.Author = author;
            this.PublishingYear = publishingYear;
            this.Genre = genre;
        }

        public Book(string title)
        {
            this.Title = title;
        }

    }
}
