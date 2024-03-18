using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace live.Models
{
    public class Conection
    {
        [Key]
        public Guid Id { get; set; }
        public string ?Email { get; set; }
        public string? Telephone { get; set; }
        public string? SecondTelephone { get; set; }
        public bool IsConfirmSms { get; set; }
        public bool IsConfirmEmail { get; set; }

        public Guid StoreId { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
        public Guid AddressId { get; set; }

        [ForeignKey("StoreId")]

        public virtual Store Store { get; set; }

    }
}
