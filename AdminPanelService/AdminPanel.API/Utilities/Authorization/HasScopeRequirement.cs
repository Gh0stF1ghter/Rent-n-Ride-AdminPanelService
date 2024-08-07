using Microsoft.AspNetCore.Authorization;

namespace AdminPanel.API.Utilities.Authorization;

public class HasScopeRequirement : IAuthorizationRequirement
{
    public string Permission { get; }

    public HasScopeRequirement(string permission)
    {
        Permission = permission ?? throw new ArgumentNullException(nameof(permission));
    }
}
