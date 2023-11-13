using LibraryAssigment.Classes;

namespace LibraryAssigment
{
    internal class Program
    {
        static void Main()
        {
            // Create a new library based on the library class
            Library myLibrary = new();

            // Manually created books to be added as default content to the library
            Book newBook1 = new("Under ytan", "Uno Svenningsson", "978-3-16-148410-0", true);
            Book newBook2 = new("Ovanför ytan", "Uno Svenningsson", "978-5-16-158255-0", false);
            Book newBook3 = new("Fiska med Ove", "Ove Björn", "978-2-11-533812-1", true);

            // Add books library
            myLibrary.Books.Add(newBook1);
            myLibrary.Books.Add(newBook2);
            myLibrary.Books.Add(newBook3);

            // Variables
            int selectedOption;
            bool exitApplication = false;

            // Loop over the DisplayMenu-function until the user selects option 4 (exit = true)
            while (true)
            {
                // Clear the console at the start of every loop
                Console.Clear();

                // Display the selection menu and return user selection (1-4) to be evaluated below
                selectedOption = DisplayMenu();

                // Call the different Library-methods based on the users menu selection

                if (selectedOption == -1) // Invalid selection, display error message and repeat loop
                {
                    Console.WriteLine("");
                    Console.WriteLine("Felaktigt val! Tryck på valfri tangent och försök igen...\n");
                    Console.ReadKey();
                }
                else if (selectedOption == 1) // Display all books
                {
                    myLibrary.DisplayAllBooks();
                }
                else if (selectedOption == 2) // Add book
                {
                    myLibrary.AddBook();
                }
                else if (selectedOption == 3) // Remove book
                {
                    myLibrary.RemoveBook();
                }
                else if (selectedOption == 4) // Exit the application
                {
                    //exitApplication = true;
                    return;
                }
            }
        }

        /// <summary>
        /// Displays the menu of options and validates the user input
        /// </summary>
        /// <returns>Integer of the selected option</returns>
        static int DisplayMenu()
        {
            Console.WriteLine("Välkommen till biblioteket!\n");
            Console.WriteLine("Vad vill du göra? (Skriv in siffran för det alternativ du önskar)");
            Console.WriteLine("1: Visa alla böcker");
            Console.WriteLine("2: Lägga till en bok");
            Console.WriteLine("3: Ta bort en bok");
            Console.WriteLine("4: Avsluta programmet\n");

            string? userInput = Console.ReadLine();

            // Validate the user Input to be a number within the range of options
            if (int.TryParse(userInput, out int selectedOption))
            {

                if (selectedOption > 0 && selectedOption < 5)
                {
                    return selectedOption;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}