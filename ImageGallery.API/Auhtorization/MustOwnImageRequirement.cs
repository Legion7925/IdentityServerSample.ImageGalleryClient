using Microsoft.AspNetCore.Authorization;

namespace ImageGallery.API.Auhtorization;

public class MustOwnImageRequirement : IAuthorizationRequirement
{
    public MustOwnImageRequirement()
    {
        
    }
}
