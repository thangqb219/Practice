namespace MovieCenter.Models.Domain
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameOfAuthor { get; set; }
        public string Description { get; set; }
        public DateTime DateOfRelease { get; set; }
        public double PriceOfTicket { get; set; }

    }
}
