namespace live.Models
{
    public class Status
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public Categorie Categorie { get; set; }
        public Address Address { get; set; }
        public CellPlan CellPlan { get; set; }
        public Location Localtion  { get; set; }
        public Product Product { get; set; }
        public Store Store { get; set; }
        public User User { get; set; }
    }
}
