using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
    
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  =>
                      {
                        policy.WithOrigins("*")
                        .SetIsOriginAllowedToAllowWildcardSubdomains()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.UseRouting();

app.UseCors(MyAllowSpecificOrigins);

//app.UseEndpoints(endpoints => { endpoints.MapControllers().RequireCors(MyAllowSpecificOrigins); });

app.Run();
