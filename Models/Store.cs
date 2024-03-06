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
        public Guid CategorieId { get; set; }
        public Guid SecondCategorieId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public bool ?IsShipping { get; set; }
    }
}
