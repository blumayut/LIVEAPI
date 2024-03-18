namespace live.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string ?City { get; set; }
        
        public string ?HouseNumber { get; set; }
        //Family at the door
        public string ?FamilyDoor { get; set; }
        public string ?Floor { get; set; }
        public string ?Entrance { get; set; }
        public string ?Street { get; set; }
        public Guid ConectionId { get; set; }
        public virtual Conection Conection { get; set; }    
    }
}
