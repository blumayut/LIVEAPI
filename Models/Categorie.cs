namespace live.Models
{
    public class Categorie
    {
        public Guid Id { get; set; }
        public string NameCategorie { get; set; }
        public Categorie fatherCategorie { get; set; }
        public bool IsActive { get; set; }
        public Status Status { get; set; }
        public virtual Store ?Store { get; set; }
        public virtual Product ?Product  { get; set; }


    }
}
