namespace live.Models
{
    public class Store
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ?Logo { get; set; }
        public Guid Status  { get; set; }
        public string ?Description { get; set; }
        public User UserId { get; set; }
        public ICColection<Categorie> Categorie { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public bool ?IsShipping { get; set; }
    }
}
