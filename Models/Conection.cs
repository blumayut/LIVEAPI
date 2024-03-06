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
        
        public bool IsEmailConfirmed { get; set; }
        public bool IsConfirmeSms { get; set; }
        public Guid ?AdressId { get; set; }


    }
}
