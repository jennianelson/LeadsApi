using System;
using System.ComponentModel.DataAnnotations;

namespace LeadsApi.Models

{
    public class Person
    {
        public long Id {get; set;}

        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName {get; set;}
        
        [Required(ErrorMessage = "LastName is required")]
        public string LastName {get; set;}

        [Required(ErrorMessage = "Email is required")]
        public string Email {get; set;}
        public string Company {get; set;}

        [Required(ErrorMessage = "PhoneNumber is required")]
        public string PhoneNumber {get; set;}
        public int PostCode {get; set;}
        public DateTime DateCreated {get; set;}
    }
}