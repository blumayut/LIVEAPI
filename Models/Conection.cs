namespace live.Models
{
    public class Conection
    {
        public Guid Id { get; set; }
        public string ?Email { get; set; }
        public string ?Telphon { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool IsConfirmeSms { get; set; }
        public string ?Adress { get; set; }


    }
}
