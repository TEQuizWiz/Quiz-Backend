using System.ComponentModel.DataAnnotations;

namespace Quiz.Model
{
    public class AuthenticateRequest
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
