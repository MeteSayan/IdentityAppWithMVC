using Microsoft.AspNetCore.Authorization;

namespace IdentityAppWithMVC.Authorization
{
    public class NicknameRequirement : IAuthorizationRequirement
    {
        public string Name { get; set; }
        public NicknameRequirement(string name)
        {
            Name = name;
        }
    }
}
