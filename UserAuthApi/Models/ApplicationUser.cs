using Microsoft.AspNetCore.Identity;

namespace UserAuthApi.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        // Add any additional properties here, if needed
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}