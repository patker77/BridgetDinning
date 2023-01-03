using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BridgetDinning.Application.Common.Interfaces.Authentication;

namespace BridgetDinning.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

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
            //check if user exit
            // create new user
            //create jwt token
            Guid userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId,FirstName,LastName);

            return new AuthenticationResult(
                Guid.NewGuid(),
                FirstName,
                LastName,
                Email,
                Password,
                token);
        }
    }
}