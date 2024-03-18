using System.ComponentModel.DataAnnotations.Schema;

namespace live.Models
{
    public class CellPlan
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        [ForeignKey("StatusId")]
         public virtual Status  Status { get; set; }
        public virtual ICollection<User>?  Users { get; set; }
        public DateTime? LimidetTime { get; set; }
        public Guid LocationId { get; set; }
        [ForeignKey("LocatioId")]
        public Location Location { get; set; }
    }
}
