namespace live.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public float ?Price { get; set; }
        public int ?Count { get; set; } 
        public bool ?IsActive   { get; set; }
        public Guid Status { get; set; }    

    }
}
