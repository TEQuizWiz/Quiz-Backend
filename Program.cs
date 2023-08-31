using Quiz.Data;
using Quiz.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quiz.Helpers;
using Quiz.Authorization;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddControllers()
.AddJsonOptions(o =>
{
    o.JsonSerializerOptions.PropertyNameCaseInsensitive = false;
});
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
//builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<UserDBContent>();
builder.Services.AddScoped<IJwtUtils, JwtUtils>();
builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddDbContext<UserDBContent>(options => 
//{
//    //options.UseNpgsql(builder.Configuration.GetConnectionString("NpgConnection"));
//});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // AddSwaggerCon();

builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();

builder.Services.ConfigNpgsql(builder.Configuration);
var app = builder.Build();
    {
    app.UseCors(x => x
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin());

    app.UseMiddleware<JwtMiddleware>();

    app.MapControllers();
    }

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Quiz")
    );; 
}

//app.UseAuthentication();
//app.UseAuthorization();
//app.MapControllers();
//app.MapGet("/", () => "Hello World!");

app.Run();
