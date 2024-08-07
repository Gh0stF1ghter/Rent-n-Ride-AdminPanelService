using Microsoft.AspNetCore.Authorization;

namespace AdminPanel.API.Utilities.Authorization;

public class HasScopeHandler : AuthorizationHandler<HasScopeRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HasScopeRequirement requirement)
    {
        if (context.User.HasClaim(c => c.Type == "permissions"))
        {
            var permission = context.User.FindFirst(c => c.Type == "permissions" && c.Value == requirement.Permission);

            if (permission is not null)
            {
                context.Succeed(requirement);
            }
        }

        return Task.CompletedTask;
    }
}