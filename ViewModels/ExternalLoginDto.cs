namespace IdentityAppWithMVC.ViewModels
{
    public class ExternalLoginDto
    {
        public string ReturnUrl { get; set; }
        public string ProviderDisplayName { get; set; }
        public string Error { get; set; }
    }
}
