using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace authmvc.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
    }
}
