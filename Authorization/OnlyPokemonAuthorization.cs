using Microsoft.AspNetCore.Authorization;

namespace IdentityAppWithMVC.Authorization
{
    public class OnlyPokemonAuthorization : AuthorizationHandler<OnlyPokemonAuthorization>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OnlyPokemonAuthorization requirement)
        {
            if (context.User.IsInRole("Pokemon"))
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }
            return Task.CompletedTask;
        }
    }
}
