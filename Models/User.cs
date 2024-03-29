﻿using System.ComponentModel.DataAnnotations.Schema;

namespace live.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string Email { get; set; }
        public string ?Telephon { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("StatusId")]

        public virtual Status Status { get; set; }    
        public virtual ICollection< CellPlan> ?CellPlans { get; set; }  
        public ICollection<Store> ?Stores { get; set; }
        public bool IsConfirmSms { get; set; }
        public bool IsConfirmEmail { get; set; }

    }
}
