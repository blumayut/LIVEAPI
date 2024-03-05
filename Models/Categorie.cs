namespace live.Models
{
    public class Categorie
    {
        public Guid Id { get; set; }
        public string NameCategorie { get; set; }
        public Categorie IdfatherCategorie { get; set; }
        public bool IsActive { get; set; }
        public Status Status { get; set; }


    }
}
