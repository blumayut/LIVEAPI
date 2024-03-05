﻿namespace live.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid StatusId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string Email { get; set; }
        public bool ?IsEmailConfirmed { get; set; }
        public string ?Telphon { get; set; }
        

      
        
       
       
    }
}
