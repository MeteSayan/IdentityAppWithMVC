using System.ComponentModel.DataAnnotations;

namespace IdentityAppWithMVC.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
