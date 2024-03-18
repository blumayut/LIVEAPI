namespace live.Models
{
    public class Conection
    {
        public Guid Id { get; set; }
        public string ?Email { get; set; }
        public string? Telephone { get; set; }
        public string? SecondTelephone { get; set; }
        public bool IsConfirmSms { get; set; }
        public bool IsConfirmEmail { get; set; }
        
   

        public virtual Address Address { get; set; }
        public virtual Store Store { get; set; }

    }
}
