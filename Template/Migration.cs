//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.IdentityModel.Tokens;
//using Template.Auth.Models;
//using Template.IoC;
//using Template.Swagger;
//using System.Text;
//using Template.CrossCutting.Auth.Models;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//builder.Services.RegisterServices(builder.Configuration);

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerConfiguration();

//var key = Encoding.ASCII.GetBytes(Settings.Secret);
//builder.Services.AddAuthentication(x =>
//{
//    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer(x =>
//{
//    x.RequireHttpsMetadata = false;
//    x.SaveToken = true;
//    x.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateIssuerSigningKey = true,
//        IssuerSigningKey = new SymmetricSecurityKey(key),
//        ValidateIssuer = false,
//        ValidateAudience = false
//    };
//});

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwaggerConfiguration();
//}

//app.UseHttpsRedirection();

//app.UseAuthentication();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
