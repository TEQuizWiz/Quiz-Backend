using Quiz.Data;
using Microsoft.AspNetCore.Identity;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quiz.Entities;

namespace Quiz.Services
{
    public static  class ServiceExtention
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<IdentityUser, IdentityRole>(o =>
            {
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<UserDBContent>()
            .AddDefaultTokenProviders();
        }

        public static void ConfigNpgsql(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<UserDBContent>(
                options => options.UseNpgsql("NpgConnection"));
    }
}
