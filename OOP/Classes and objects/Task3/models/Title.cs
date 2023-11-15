namespace Task3.models
{
    public class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        public string Show() => $"{prefix}{title}";

        private string prefix = "Title: ";
    }
}
