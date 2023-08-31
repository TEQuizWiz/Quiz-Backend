using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Quiz.Authorization;
using Quiz.Model;
using Quiz.Services;

namespace Quiz.Controller
{
    [ApiController]
   // [Authorize]
    [Route("api/auth/")]
    public class AuthController : ControllerBase
    {
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
           _userService = userService;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Register(SignupRequest user)
        {
            try
            {
                var response = await _userService.RegistrNewUser(user);
                if (response)
                    return Ok($"User {user.Username} is register successfully");
                return BadRequest(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       // [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate(AuthenticateRequest user) 
        {
            try
            {
                var response = await _userService.Authenticate(user);
                if (response != null)
                    return Ok(response);

                return BadRequest(new { message = "Username or password is incorrect" });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
     }
}
