
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Infrastructure.Data
{
    public class Tatawwa3DbContext:IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public Tatawwa3DbContext(DbContextOptions<Tatawwa3DbContext> options) : base(options) { }

      
        public DbSet<VolunteerProfile> VolunteerProfiles { get; set; }
        public DbSet<OrganizationProfile> OrganizationProfiles { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<VolunteerOpportunity> VolunteerOpportunities { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Participation> Participations { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<VolunteerAchievement> VolunteerAchievements { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
