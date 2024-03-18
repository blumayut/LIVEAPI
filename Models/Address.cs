using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace live.Models
{
    public class Address
    {
        [Key,ForeignKey("Conection")]
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
