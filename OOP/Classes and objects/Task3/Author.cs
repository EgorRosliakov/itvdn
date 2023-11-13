namespace Task3
{
    class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine("Author: " + author);
        }
    }
}
