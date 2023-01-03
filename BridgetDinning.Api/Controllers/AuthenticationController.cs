using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BridgetDinning.Application.Services.Authentication;
using BridgetDinning.Contrats.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BridgetDinning.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request){

            var result = _authenticationService.Register(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password
            );
              var reponse = new AuthenticationResponse(
                result.Id,
                result.FirstName,
                result.LastName,
                result.Email,
                result.Password,
                result.Token
            );
            return Ok(reponse);
        }
        [HttpPost("login")]
         public IActionResult Login(LoginRequest request){
            
             var result = _authenticationService.Login(
                request.Email,
                request.Password
            );
                 var reponse = new AuthenticationResponse(
                result.Id,
                result.FirstName,
                result.LastName,
                result.Email,
                result.Password,
                result.Token
            );
            return Ok(reponse);
        }
        }
    }
