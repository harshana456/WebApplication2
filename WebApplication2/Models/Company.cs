﻿namespace WebApplication2.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; } = false;
    }
}
