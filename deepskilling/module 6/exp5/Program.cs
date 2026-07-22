using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


// ---------------- CORS ----------------

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});



// ---------------- JWT Authentication ----------------


string securityKey = "mysuperdupersecret";


var symmetricSecurityKey =
    new SymmetricSecurityKey(
        Encoding.UTF8.GetBytes(securityKey));



builder.Services.AddAuthentication(
    JwtBearerDefaults.AuthenticationScheme)

.AddJwtBearer(options =>
{

    options.TokenValidationParameters =
    new TokenValidationParameters
    {

        ValidateIssuer = true,

        ValidateAudience = true,

        ValidateLifetime = true,

        ValidateIssuerSigningKey = true,


        ValidIssuer = "mySystem",

        ValidAudience = "myUsers",

        IssuerSigningKey = symmetricSecurityKey

    };

});



builder.Services.AddAuthorization();



builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();



var app = builder.Build();



app.UseSwagger();

app.UseSwaggerUI();



// Enable CORS

app.UseCors("AllowAll");



// Enable Authentication

app.UseAuthentication();


app.UseAuthorization();



app.MapControllers();


app.Run();