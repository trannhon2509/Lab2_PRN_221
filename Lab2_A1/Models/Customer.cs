using Lab2_A1.Binding;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab2_A1.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Customer name is required!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The length of the customer from 3 - 20 characters")]
        [ModelBinder(BinderType = typeof(CheckNameBinding))]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Customer email is required!")]
        [EmailAddress]
        [Display(Name = "Customer email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Year of birth is required!")]
        [Display(Name = "Year of birth")]
        [Range(1960, 2000, ErrorMessage ="1960-2000")]
        public int? YearOfBirth { get; set; }
    }
}
