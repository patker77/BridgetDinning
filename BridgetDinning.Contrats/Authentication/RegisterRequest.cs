using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgetDinning.Contrats.Authentication
{
    public record RegisterRequest
   (
        Guid  Id,
        string FirstName,
        string LastName,
        string Email,
        string Password
    );
}