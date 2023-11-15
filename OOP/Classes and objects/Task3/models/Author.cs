namespace Task3.models
{
    public class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }

        public string Show() => $"{prefix}{author}";

        private string prefix = "Author: ";
    }
}
