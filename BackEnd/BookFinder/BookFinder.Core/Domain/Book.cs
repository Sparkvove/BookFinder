namespace BookFinder.Core.Domain
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public Book(string Title, string Author, string Description)
        {
            this.Title = Title;
            this.Author = Author;
            this.Description = Description;
        }

    }
}
