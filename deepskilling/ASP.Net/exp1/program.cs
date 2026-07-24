using WebAPIProject.Services;

var builder = WebApplication.CreateBuilder(args);


// Add Controller Services

builder.Services.AddControllers();


// Dependency Injection

builder.Services.AddSingleton<ProductService>();


// Swagger

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();



var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}



app.UseHttpsRedirection();


app.UseAuthorization();


app.MapControllers();


app.Run();