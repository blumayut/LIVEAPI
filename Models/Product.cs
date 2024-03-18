using System.ComponentModel.DataAnnotations.Schema;

namespace live.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public float ?Price { get; set; }
        public int ?Count { get; set; } 
        public bool ?IsActive   { get; set; }
        public string ?img { get; set; }
        public Guid CategorieId { get; set; }


        [ForeignKey("CategorieId")]

        public Categorie Categorie { get; set; }
        [ForeignKey("StatusId")]

        public virtual Status Status { get; set; }    
         
    }
}
