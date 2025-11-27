using Microsoft.AspNetCore.Identity;

namespace BlondeBlazor.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class BlondeBlazorUser : IdentityUser
    {
        public string? FirstName { get ; set; }
        public string? LastName { get; set; }
    }
}
