using AutoMapper;
using AutoMapper;
using FleetTrackerSystem.Infrastructure.Seeder;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;
using Tatawwa3.API.Mapper.AuthMapper;
using Tatawwa3.API.Mapper.Volunteer;
using Tatawwa3.Application;
using Tatawwa3.Application;
using Tatawwa3.Application.CQRS.Team.Commands;
using Tatawwa3.Application.CQRS.Team.Handlers;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Application.MappingProfiles;
using Tatawwa3.Application.Services;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Entities.MailSetting;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;
using Tatawwa3.Infrastructure.Repositorirs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IGeneric<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(GenericRepository<>)); 

builder.Services.AddAutoMapper(typeof(TeamProfile).Assembly);




builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IVolunteerService, VolunteerService>();
builder.Services.AddScoped<IPdfGenerator, PdfGenerator>();


builder.Services.AddScoped<ITeamService,TeamService>();
builder.Services.AddScoped<IApplicationService,VolunteerMangmentService>();


builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("Smtp"));
builder.Services.AddScoped<IEmailService, EmailService>();





builder.Services.AddDbContext<Tatawwa3DbContext>(options =>
    options.UseSqlServer(
            builder.Configuration.GetConnectionString("CS"),
            x => x.MigrationsAssembly("Tatawwa3.Infrastructure")
        )
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
        .LogTo(log => Debug.WriteLine(log), LogLevel.Information)
);

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(Tatawwa3.Application.AssemblyReference).Assembly));

builder.Services.AddAutoMapper(typeof(AssemblyReference).Assembly);

builder.Services.AddScoped<IOpportunity, OpportunityRepository>();

builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();

builder.Services.AddScoped<ITeamService, TeamService>();

builder.Services.AddScoped<IRecommendedOpportunityService, RecommendedOpportunityService>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<IOrganizationRepository, OrganizationRepository>();
builder.Services.AddScoped<IVolunteerProfileRepository, VolunteerProfileRepository>();
builder.Services.AddScoped<IVolunteerInvitationReprosatry, VolunteerInvitationReprosatry>();
builder.Services.AddScoped<ICertificateService, CertificateService>();












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
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
////////عشان يحول enm to string


var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<VolunteerRegMapper>();
    cfg.AddProfile<OrganizatonRegMapper>();
    cfg.AddProfile<TeamProfile>();
    cfg.AddProfile<RecommendedOpportunityProfile>();


});

builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme =
        JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme =
        JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme =
        JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new()
    {
        ValidateIssuer = true,
        ValidIssuer = builder.Configuration["JWT:Issuer"],
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
    };
});

builder.Services.AddSwaggerGen(swagger =>
{
    //This is to generate the Default UI of Swagger Documentation    
    swagger.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ASP.NET 5 Web API",
        Description = " ITI Projrcy",


    });


    // To Enable authorization using Swagger (JWT)    
    swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter 'Bearer' [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
    });
    swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                    new OpenApiSecurityScheme
                    {
                    Reference = new OpenApiReference
                    {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                    }
                    },
                    new string[] {}
                    }
                    });
});


MapperService.Mapper = config.CreateMapper();
//builder.Services.AddMediatR(typeof(IApplicationMarker).Assembly);
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(IApplicationMarker).Assembly));
builder.Services.AddScoped<IVolunteerOpportunityService, VolunteerOpportunityService>();
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<IDashboardVolunteer, VolunteerDashboardService>();
builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();
builder.Services.AddScoped<IStatisticsService, StatisticsService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{

    // Replace the problematic line with the correct configuration for MediatR

    var roleManager = scope.ServiceProvider.GetRequiredService<Microsoft.AspNetCore.Identity.RoleManager<ApplicationRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<Microsoft.AspNetCore.Identity.UserManager<ApplicationUser>>();
    await RoleSeed.SeedAsync(roleManager);
    // await UserSeeder.SeedAsync(userManager);
}









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
