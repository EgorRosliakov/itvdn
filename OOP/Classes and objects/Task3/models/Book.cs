using Task3.dto;

namespace Task3.models
{
    public class Book
    {
        private Title _title;
        private Author _author;
        private Content _content;

        public Book(string title, string author, string content)
        {
            _title = new Title(title);
            _author = new Author(author);
            _content = new Content(content);
        }
        public BookDTO Show()
        {
            string title = _title.Show();           
            string author = _author.Show();           
            string content = _content.Show();

            return new BookDTO(title, author, content);
        }
    }
}