using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BridgetDinning.Application.Common.Interfaces.Authentication;
using Microsoft.IdentityModel.Tokens;

namespace BridgetDinning.Infrastructure.Authentication
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        public string GenerateToken(Guid userId, string FirstName, string LastName)
        {
            var signingCredential = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes("pASsWord!-upe-se")),
                    SecurityAlgorithms.HmacSha256);
            var claims = new []
            {
                new Claim(JwtRegisteredClaimNames.Sub,userId.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName, FirstName),
                new Claim(JwtRegisteredClaimNames.FamilyName, LastName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            var securityToken = new JwtSecurityToken(
                issuer:"Joseph",
                expires:DateTime.Now.AddHours(2),
                claims:claims,
                signingCredentials:signingCredential
            );
            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}