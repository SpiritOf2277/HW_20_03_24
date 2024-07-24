using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HW_20_03_24.Models
{
    public class Invitation
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
