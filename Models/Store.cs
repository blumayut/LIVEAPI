namespace live.Models
{
    public class Store
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ?Logo { get; set; }
        public Status ?Status  { get; set; }
        public string ?description { get; set; }
        public User UserId { get; set; }
        public Categorie CategorieId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public Guid CategorieId { get; set; }
    }
}
