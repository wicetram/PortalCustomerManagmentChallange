﻿namespace MVC.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthYear { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TCKN { get; set; }
        public bool? TCKNCheck { get; set; }
    }
}
