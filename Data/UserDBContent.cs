using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Quiz.Entities;

namespace Quiz.Data
{
    public class UserDBContent : IdentityDbContext<IdentityUser>
    {
        protected readonly IConfiguration Configuration;
        public UserDBContent(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseNpgsql(Configuration.GetConnectionString("NpgConnection"));
            }
                // base.OnConfiguring(options);
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<User>()
            //    .HasAlternateKey(a => a.Username);

            //modelBuilder.Entity<User>()
            //    .HasAlternateKey(a => a.Email);

            //modelBuilder.Entity<Roles>().HasKey(r => r.Id);

            //modelBuilder.Entity<User_Roles>().HasKey(sc => new {sc.UserId, sc.RoleId});

            //modelBuilder.Entity<User_Roles>()
            //    .HasOne<User>(sc => sc.User)
            //    .WithMany(s => s.UserRoles)
            // .HasForeignKey(sc => sc.UserId);

            //modelBuilder.Entity<User_Roles>()
            //    .HasOne<Roles>(sc => sc.Role)
            //    .WithMany(s => s.UserRoles)
            //    .HasForeignKey(sc => sc.RoleId);

        }

        //public DbSet<User> users { get; set; }

        //public DbSet<Roles> roles { get; set; }
        //public DbSet<User_Roles> users_roles { get; set; }
    }
}
