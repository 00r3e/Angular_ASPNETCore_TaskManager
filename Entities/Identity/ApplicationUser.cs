using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Entities.Identity
{
    public class ApplicationUser: IdentityUser<Guid>
    {
        public string? PersonName {get; set; }  

        public string? RefreshToken {get; set; }

        public DateTime? RefreshTokenExpirationDateTime { get; set; }
    }
}
