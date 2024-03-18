namespace live.Models
{
    public class Store
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ?Logo { get; set; }
        public Guid StatusId { get; set; }

        public Status Status  { get; set; }
        public string ?Description { get; set; }
        public User User { get; set; }
        public ICollection <Categorie> Categorie { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public bool ?IsShipping { get; set; }
    }
}
