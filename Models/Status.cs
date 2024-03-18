using System.ComponentModel.DataAnnotations.Schema;

namespace live.Models
{
    public class Status
    {

        public Guid StatusId { get; set; }
        public string Type { get; set; }
      //  [ForeignKey("CategorieId")]

       // public virtual Categorie Categorie { get; set; }
        public virtual Address Address { get; set; }
        public virtual CellPlan CellPlan { get; set; }

        public virtual Location Localtion  { get; set; }
        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
    }
}
