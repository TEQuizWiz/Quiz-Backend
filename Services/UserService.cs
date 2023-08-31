using Microsoft.AspNetCore.Identity;
using Quiz.Authorization;
using Quiz.Entities;
using Quiz.Model;
using System.Security.Claims;

namespace Quiz.Services
{
    public interface IUserService
    {
        Task<AuthenticateResponse?> Authenticate(AuthenticateRequest authUser);
        Task<IdentityUser?> GetById(string id);
        Task<bool> RegistrNewUser(SignupRequest user);
    }
    public class UserService : IUserService
    {
        private readonly IJwtUtils _jwtUtils;
        UserManager<IdentityUser> _userManager;
        SignInManager<IdentityUser> _signInManager; 
        public UserService(IJwtUtils jwtUtils, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _jwtUtils = jwtUtils;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<bool>RegistrNewUser(SignupRequest user)
        {
            var identityUser = new IdentityUser()
            {
                UserName = user.Username,
                Email = user.Email
            };
            var result = await _userManager.CreateAsync(identityUser, user.Password);
            if(result.Succeeded) { return true; }

            return false;
        }
        public async Task<AuthenticateResponse?> Authenticate(AuthenticateRequest authUser)
        { 
            var result = await _signInManager.PasswordSignInAsync(authUser.Username, authUser.Password, false, true);
            if (result == null)
                return null;

            var user = await _userManager.FindByNameAsync(authUser.Username);
           
            var token = _jwtUtils.GenerateJwtToken(user);
            return new AuthenticateResponse(user, token);
        }

        public async Task<IdentityUser?> GetById(string id)
        {
            return await _userManager.FindByIdAsync(id);

        }
    }
}
