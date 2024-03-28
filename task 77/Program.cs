namespace task_77
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new book(1, 15.99, "Book1", "Criminal"));
            library.AddBook(new book(2, 12.49, "Book2", "Detective"));
            library.AddBook(new book(3, 9.99, "Book3", "Science Fiction"));

            Console.WriteLine("Bütün kitablar:");
            library.ShowAllBooks();

            Console.WriteLine("\nJanr üzre seçilmiş kitablar:");
            book[] filteredByGenre = library.GetFilteredBooks("Criminal");
            for (int i = 0; i < filteredByGenre.Length; i++)
            {
                filteredByGenre[i].ShowInfo();
            }

            Console.WriteLine("\nVerilmiş qirmet araliğina göre seçilmiş kilablar:");
            book[] filteredByPrice = library.GetFilteredBooks(10, 20);
            for (int i = 0; i < filteredByPrice.Length; i++)
            {
                filteredByPrice[i].ShowInfo();
            }
        }
    }
}
