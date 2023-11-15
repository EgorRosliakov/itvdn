namespace Task3.dto
{
    public class BookDTO
    {
        public BookDTO(string title, string author, string content)
        {
            Title = title;
            Author = author;
            Content = content;
        }
        public string Title { get; }
        public string Author { get; }
        public string Content { get; }
    }
}
