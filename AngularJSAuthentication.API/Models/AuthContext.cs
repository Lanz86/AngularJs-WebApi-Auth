using Microsoft.AspNet.Identity.EntityFramework;

namespace AngularJSAuthentication.API.Models
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext() : base("AuthContext")
        {
            
        }
    }
}