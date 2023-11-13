namespace Task3
{
    class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine("Title: " + title);
        }
    }
}
