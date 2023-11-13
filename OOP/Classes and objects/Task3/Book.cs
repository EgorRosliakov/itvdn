namespace Task3
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            title.Show();
            Console.ForegroundColor = ConsoleColor.Red;
            author.Show();
            Console.ForegroundColor = ConsoleColor.Blue;
            content.Show();
        }

        public static Book Input()
        {
            Console.WriteLine("Enter the book title: ");
            string titleBook = Console.ReadLine();
            Console.WriteLine("Enter the book author: ");
            string authorBook = Console.ReadLine();
            Console.WriteLine("Enter the book content: ");
            string contentBook = Console.ReadLine();

            return new Book(titleBook, authorBook, contentBook);
        }
    }
}