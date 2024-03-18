namespace live.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string Email { get; set; }
        public string ?Telephon { get; set; }
        public bool IsActive { get; set; }
        public Guid StatusId { get; set; }

        public Status Status { get; set; }    
        public ICollection< CellPlan> ?CellPlans { get; set; }  
        public ICollection<Store> ?Stores { get; set; }
        public Conection Conection { get; set; }
    }
}
