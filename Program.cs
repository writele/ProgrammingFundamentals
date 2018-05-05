using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRUD: CREATE READ UPDATE DELETE

            //CREATE

            //Create a list of genres
            List<Genre> genres = CreateGenres();

            // ****** How can we create a new genre to include in our library?
            
            //Create a library which passes in our list of genres
            List<Book> library = CreateLibrary(genres);
        
            //READ
            //Iterate through list to output library information on the screen
            ReadLibrary(library);
            Console.ReadKey();

            //UPDATE
            //Add book to library

            // Create the new book
            Book newBook = new Book("The Martian", "Andy Weir", 2011, genres.Where(x => x.Title == "Science Fiction").FirstOrDefault());

            // Add book to the library
            library = AddBook(library, newBook);

            // Output new information to screen
            Console.Clear();
            Console.WriteLine("ADDING BOOK TO LIBRARY....");
            ReadLibrary(library);
            Console.ReadKey();

            //DELETE
            //Remove book from library
            library = RemoveBook(library, library.Where(x => x.Title == "The Handmaid's Tale").FirstOrDefault());
            Console.Clear();
            Console.WriteLine("REMOVING BOOK FROM LIBRARY....");
            ReadLibrary(library);

            Console.ReadKey();

        }

        public static List<Genre> CreateGenres()
        {
            // Here we create a list of Genres, populate the list, and return the list
            List<Genre> genres = new List<Genre>();
            var genre1 = new Genre() { Title = "Science Fiction", ID = 0 };
            var genre2 = new Genre() { Title = "Fantasy", ID = 1 };
            var genre3 = new Genre() { Title = "Nonfiction", ID = 2 };

            genres.Add(genre1);
            genres.Add(genre2);
            genres.Add(genre3);

            return genres;
        }

        public static List<Book> CreateLibrary(List<Genre> genres)
        {
            // Here we are creating a new library
            List<Book> library = new List<Book>();

            // We will need genres to create books with genres. We have a collection of genres we passed into this method.
            // There are multiple ways to find an item in a collection
            Genre scienceFiction = genres[0]; 
            Genre fantasy = genres.Find(x => x.ID == 1);
            Genre nonFiction = genres.Where(x => x.Title == "Nonfiction").FirstOrDefault();

            // There are multiple ways you can create (or instantiate) an object
            var book1 = new Book();
            book1.Title = "The Handmaid's Tale";
            book1.Author = "Margaret Atwood";
            book1.PublishingYear = 1985;
            book1.Genre = scienceFiction;
            var book2 = new Book() { Title = "Packing For Mars", Author = "Mary Roach", PublishingYear = 2010, Genre = nonFiction };
            var book3 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 1997, fantasy);
            var book4 = new Book("Of Mice and Men");
            book4.Genre = fantasy;


            // Adding books to our collection
            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Add(book4);

            // This method returns our collection of books
            return library;

        }

        public static void ReadLibrary(List<Book> library)
        {
            foreach (var book in library)
            {
                Console.WriteLine(book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Publishing Year: " + book.PublishingYear);
                Console.WriteLine("Genre: " + book.Genre.Title);
                Console.WriteLine("------------------");
            }
        }

        public static List<Book> AddBook(List<Book> library, Book book)
        {
            library.Add(book);
            return library;
        }

        public static List<Book> RemoveBook(List<Book> library, Book book)
        {
            library.Remove(book);
            return library;
        }

    }
}
