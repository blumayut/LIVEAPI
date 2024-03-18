using System.ComponentModel.DataAnnotations.Schema;

namespace live.Models
{
    public class Store
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ?Logo { get; set; }
        [ForeignKey("StatusId")]

        public virtual Status Status  { get; set; }
        public string ?Description { get; set; }
        public User User { get; set; }
        public ICollection <Categorie> Categorie { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public bool ?IsShipping { get; set; }
        public virtual Conection Conection { get; set; }
    }
}
