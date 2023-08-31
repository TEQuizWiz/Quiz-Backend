using Microsoft.AspNetCore.Identity;
using Quiz.Entities;

namespace Quiz.Model
{
    public class AuthenticateResponse
    {
        public string Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string AccessToken { get; set; }


        public AuthenticateResponse(IdentityUser user, string token)
        {
            Id = user.Id;
            Username = user.UserName;
            Email = user.Email;
            AccessToken = token;
        }
    }
}
