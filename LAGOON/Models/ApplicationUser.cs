using Microsoft.AspNetCore.Identity;

namespace LAGOON.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}