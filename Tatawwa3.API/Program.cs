using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Tatawwa3DbContext>(options =>
    options.UseSqlServer(
            builder.Configuration.GetConnectionString("CS"),
            x => x.MigrationsAssembly("Tatawwa3.Infrastructure")
        )
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
        .LogTo(log => Debug.WriteLine(log), LogLevel.Information)
);


builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
               .AddEntityFrameworkStores<Tatawwa3DbContext>()
               .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
