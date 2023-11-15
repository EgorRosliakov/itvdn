namespace Task3.models
{
    public class Content
    {
        private string content;

        public Content(string content)
        {
            this.content = content;
        }

        public string Show() => $"{prefix}{content}";

        private string prefix = "Content: ";
    }
}