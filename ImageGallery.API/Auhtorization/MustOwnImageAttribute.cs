using Microsoft.AspNetCore.Authorization;

namespace ImageGallery.API.Auhtorization;

public class MustOwnImageAttribute : AuthorizeAttribute, IAuthorizationRequirementData
{
    public IEnumerable<IAuthorizationRequirement> GetRequirements()
    {
        return new[] { new MustOwnImageRequirement() };
    }
}
