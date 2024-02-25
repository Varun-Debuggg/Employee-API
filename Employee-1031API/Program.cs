using Employee_1031API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var cs = builder.Configuration.GetConnectionString("ConSTR");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(cs));

//cors
builder.Services.AddCors(options =>
{
    options.AddPolicy(name:"AnniPolicy",
   builder =>
   {
       builder.WithOrigins("https://localhost:7009")
       .AllowAnyOrigin()
       .AllowAnyMethod()
       .AllowAnyHeader();
   
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
app.UseCors("AnniPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
