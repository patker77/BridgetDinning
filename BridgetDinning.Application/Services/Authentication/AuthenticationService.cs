using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgetDinning.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResult Login(string Email, string Password)
        {
            return new AuthenticationResult(
                Guid.NewGuid(),
                "FirstName",
                "LastName",
                Email,
                Password,
                "Token");
        }

        public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
        {
            return new AuthenticationResult(
                Guid.NewGuid(),
                FirstName,
                LastName,
                Email,
                Password,
                "Token");
        }
    }
}