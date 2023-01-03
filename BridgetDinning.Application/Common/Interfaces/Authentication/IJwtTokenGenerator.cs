using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgetDinning.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(Guid userId,string FirstName,string LastName);
    }
}