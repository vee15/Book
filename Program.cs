namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of book details you want to store: ");
            int numBooks = Convert.ToInt32(Console.ReadLine());

            Book[] books = new Book[numBooks];

            Console.WriteLine("\nInsert the information of books:");


            for (int i = 0; i < numBooks; i++)
            {
                Console.WriteLine($"Information of book {i + 1}:");
                Console.Write("Input name of the book: ");
                string title = Console.ReadLine();
                Console.Write("Input the author: ");
                string author = Console.ReadLine();

                books[i] = new Book { Title = title, Author = author };
                Console.WriteLine();
            }

            Console.WriteLine("Book Details are:");
            for (int i = 0; i < numBooks; i++)
            {
                Console.WriteLine($"{i + 1}: Title = {books[i].Title}, Author = {books[i].Author}");
            }
        }
    }
    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

    }
}