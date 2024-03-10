﻿namespace live.Models
{
    public class Localtion
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public Guid Status { get; set; }
        public string? Description { get; set; }

        public int? TimeZoneId { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Importance { get; set; }
    }
}