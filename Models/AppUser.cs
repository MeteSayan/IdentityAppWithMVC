using Microsoft.AspNetCore.Identity;

namespace IdentityAppWithMVC.Models
{
    public class AppUser : IdentityUser
    {
        public string NickName { get; set; }
    }
}