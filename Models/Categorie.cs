namespace live.Models
{
    public class Categorie
    {
        public Guid Id { get; set; }
        public string NameCategorie { get; set; }
        public Categorie Parent { get; set; }
        public bool IsActive { get; set; }
        public Guid StatusId { get; set; }
        public virtual Status Status { get; set; }
        public  ICollection<Store>  ?Store { get; set; }
        public  ICollection< Product> ?Product  { get; set; }
        public  ICollection<Categorie> Childrens { get; set; }


    }
}
