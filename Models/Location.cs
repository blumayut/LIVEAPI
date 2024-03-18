namespace live.Models
{
    public class Location
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
         public virtual Status Status { get; set; }
        public string? Description { get; set; }

        public int? TimeZoneId { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Importance { get; set; }
        public ICollection<CellPlan>  CellPlans { get; set; }

    }
}
