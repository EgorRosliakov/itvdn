namespace Task3
{
    class Content
    {
        private string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine("Content: " + content);
        }
    }
}