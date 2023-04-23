namespace BookFinder.Domain
{
    public class Book
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public Book(int id, string Title, string Author, string Description)
        {
            Id = id;
            this.Title = Title;
            this.Author = Author;
            this.Description = Description;
        }

    }
}
