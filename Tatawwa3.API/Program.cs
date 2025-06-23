using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Tatawwa3.Application.CQRS.Team.Commands;
using Tatawwa3.Application.CQRS.Team.Handlers;
using Tatawwa3.Application.MappingProfiles;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;
using Tatawwa3.Infrastructure.Repositorirs;
using FluentValidation;
using FluentValidation.AspNetCore;
using Tatawwa3.Application.CQRS.teams.Validators;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IGeneric<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(GenericRepository<>)); // لو بتستخدمه مباشر

builder.Services.AddAutoMapper(typeof(TeamProfile).Assembly);
//builder.Services.AddMediatR(opts=>opts.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(CreateTeamCommandHandler).Assembly));

builder.Services.AddControllers()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateTeamCommandValidator>());



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
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();
app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();
app.MapGet("/", () => Results.Ok("🚀 Tatawwa3 API is running"));

app.Run();
