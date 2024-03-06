﻿namespace live.Models
{
    public class CellPlan
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string ?Description { get; set; }
        public float Price { get; set; }
        public User User { get; set; }
        public Guid ?DurationTime { get; set; }
        public Guid LocationId { get; set; }
}