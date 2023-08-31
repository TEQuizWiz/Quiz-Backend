using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Quiz.Entities
{
    //public class User : IdentityUser
    //{
    //    private string _id;
    //    [Key]
    //    [Column("id")]
    //    public string Id
    //    {
    //        get { return _id; }
    //        set { _id = Guid.NewGuid().ToString(); }
    //    }

    //    [Column("username")]
    //    [Required]
    //    [StringLength(20)]
    //    public string Username { get; set; }

    //    [Column("password")]
    //    [Required]
    //    [StringLength(50)]
    //    [JsonIgnore]
    //    public string Password { get; set; }

    //    [Column("email")]
    //    [Required]
    //    [StringLength(50)]
    //    public string Email { get; set; }

    //    // public  IList<User_Roles> UserRoles { get; set; }
    //}
}
