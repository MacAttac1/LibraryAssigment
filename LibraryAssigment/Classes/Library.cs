namespace LibraryAssigment.Classes
{
    internal class Library
    {
        public List<Book> Books = new() { }; // Create an empty list of books

        /// <summary>
        /// Generate a list of all books in the library 
        /// </summary>
        public void DisplayAllBooks()
        {
            Console.Clear();
            Console.WriteLine("(1) VISA ALLA BÖCKER\n");

            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine($"Bok {i + 1} -----------------");
                Console.WriteLine("Titel: " + Books[i].Title);
                Console.WriteLine("Författare: " + Books[i].Author);
                Console.WriteLine("ISBN-nummer: " + Books[i].ISBN);
                if (Books[i].IsAvailable)
                {
                    Console.WriteLine("Tillgänglig: Ja\n");
                }
                else
                {
                    Console.WriteLine("Tillgänglig: Nej\n");
                }

            }
            Console.WriteLine("Tryck på valfi tangent för att fortsätta...");
            Console.ReadKey();
        }

        /// <summary>
        /// Recieve input from user, create and add a new book to the library
        /// </summary>
        public void AddBook()
        {
            Console.Clear();
            Console.WriteLine("(2) LÄGG TILL NY BOK\n");
            Console.WriteLine("Vänligen ange följande information för att skapa en ny bok:\n");

            Console.WriteLine("Titel:");
            string? title = Console.ReadLine();
            Console.WriteLine("");
            if (title == null || title == "")
            {
                title = "TITEL SAKNAS";
            }

            Console.WriteLine("Författare:");
            string? author = Console.ReadLine();
            Console.WriteLine("");
            if (author == null || author == "")
            {
                author = "TITEL SAKNAS";
            }

            Console.WriteLine("ISBN-nummer:");
            string? isbn = Console.ReadLine();
            if (isbn == null || isbn == "")
            {
                isbn = "TITEL SAKNAS";
            }

            // Set book availability to true as default when creating a new book
            bool isAvailable = true;

            // Create a new Book from the Book-class based in the user input
            Book newBook = new(title, author, isbn, isAvailable);

            // Add the new Book to the library Books-list
            Books.Add(newBook);

            Console.WriteLine("");
            Console.WriteLine("Boken har lagts till!\n");
            Console.WriteLine("Tryck på valfi tangent för att fortsätta...");
            Console.ReadKey();
        }

        /// <summary>
        /// Delete a specific book in the library based on the index of the book in the books-list
        /// </summary>
        public void RemoveBook()
        {
            Console.Clear();
            Console.WriteLine("(3) TA BORT EN BOK\n");

            // Check if Books-list contains any books
            if (Books.Count == 0)
            {
                Console.WriteLine("Biblioteket innehåller inga böcker\n");
            }
            else
            {
                Console.WriteLine($"Ange numret på den bok som ska tas bort (1-{Books.Count}):\n");
                string? userInput = Console.ReadLine();

                // Check if user Input is a number
                if (int.TryParse(userInput, out int numberOfBookToDelete))
                {
                    // Check if number is within the range of available books
                    if (numberOfBookToDelete > 0 && numberOfBookToDelete <= Books.Count)
                    {
                        Books.RemoveAt(numberOfBookToDelete - 1); // Remove the book from the books-list
                        Console.WriteLine("");
                        Console.WriteLine($"Bok {numberOfBookToDelete} har tagits bort.\n");
                    }
                    else
                    {
                        Console.WriteLine("Du måste ange ett giltigt boknummer!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Du måste ange ett giltigt boknummer!\n");
                }
            }
            Console.WriteLine("Tryck på valfi tangent för att fortsätta...");
            Console.ReadKey();
        }
    }

}
