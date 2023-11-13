namespace LibraryAssigment.Classes
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; } // Is available for loan

        public Book(string newTitle, string newAuthor, string newISBN, bool newIsAvailable)
        {
            Title = newTitle;
            Author = newAuthor;
            ISBN = newISBN;
            IsAvailable = newIsAvailable;
        }
    }
}
