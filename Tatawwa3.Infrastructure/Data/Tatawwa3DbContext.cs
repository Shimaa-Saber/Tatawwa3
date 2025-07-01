
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Entities.MailSetting;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Infrastructure.Data
{
    public class Tatawwa3DbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
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
        public DbSet<JoinRequest> JoinRequests { get; set; }


        public DbSet<Review> Reviews { get; set; }

        public DbSet<PasswordResetToken> passwordResetTokens { get; set; }








        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
           .HasOne(u => u.OrganizationProfile)
           .WithOne(o => o.User)
           .HasForeignKey<OrganizationProfile>(o => o.UserID)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(u => u.VolunteerProfile)
                .WithOne(v => v.User)
                .HasForeignKey<VolunteerProfile>(v => v.UserID)
                .OnDelete(DeleteBehavior.Cascade);



            var orgUserId = "org-user-1";
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = orgUserId,
                UserName = "org@example.com",
                Email = "org@example.com",
                PhoneNumber = "01000000000",
                NationalID = "12345678901234",
                City = "Cairo",
                CreatedAt = DateTime.UtcNow,
                Role = UserType.Organization,
                NormalizedUserName = "ORG@EXAMPLE.COM",
                NormalizedEmail = "ORG@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEO6fBKgYj6nRAiD3F6jHUWfXeCmgVi+e3kq9a+vZ7O9GsG2vEMiRKzLskroIfvHHng==", // كلمة السر Org@123
                SecurityStamp = Guid.NewGuid().ToString()
            });

            modelBuilder.Entity<OrganizationProfile>().HasData(new OrganizationProfile
            {
                Id = "org-profile-1",
                UserID = orgUserId,
                OrganizationName = "Seeded Org",
                CommercialRegistration = "REG123456",
                IsVerified = true,
                City = "minya"
            });


            var volunteerUserId = "vol-user-1";
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = volunteerUserId,
                UserName = "volunteer@example.com",
                Email = "volunteer@example.com",
                PhoneNumber = "01111111111",
                NationalID = "98765432109876",
                City = "Assiut",
                CreatedAt = DateTime.UtcNow,
                Role = UserType.Volunteer,
                NormalizedUserName = "VOLUNTEER@EXAMPLE.COM",
                NormalizedEmail = "VOLUNTEER@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEO6fBKgYj6nRAiD3F6jHUWfXeCmgVi+e3kq9a+vZ7O9GsG2vEMiRKzLskroIfvHHng==", // كلمة السر Vol@123
                SecurityStamp = Guid.NewGuid().ToString()
            });

            modelBuilder.Entity<VolunteerProfile>().HasData(new VolunteerProfile
            {
                Id = volunteerUserId,
                UserID = volunteerUserId,
                TotalHours = 0,
                Rating = 0,
                Interests = "[\"Education\",\"Health\"]",
                IsVerified = false
            });

            modelBuilder.Entity<VolunteerProfile>().HasData(new VolunteerProfile
            {
                Id = "vol_prof2",
                UserID = "1b5b5731-bcf1-4178-87ad-cf43dac0bbeb",
                TotalHours = 0,
                Rating = 0,
                Interests = "[\"Education\",\"Health\"]",
                IsVerified = false
            });


           

            var categoryId = "cat-edu-1";
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = categoryId,
                Name = "Education",
                Description = "Educational programs and initiatives",
                Icon = "education.png",
                CreatedAt = DateTime.UtcNow
            });

            modelBuilder.Entity<Team>().HasData(
            new Team
            {
                Id = "team-1",
                OrganizationID = "org-profile-1",
                CategoryId = "cat-edu-1",
                Name = "Education Support Team",
                Description = "Team responsible for organizing educational initiatives.",
                Status = TeamStatus.Active,
                CreationDate = DateTime.UtcNow.AddDays(-15),
                City = "Cairo",
                IsLinkedToOpportunity = true,
                MaxMembers = 20,
                InternalNotes = "Priority team for large campaigns",
                JoinPermission = TeamJoinPermission.Anyone,
                CreatedAt = DateTime.UtcNow
            }
         );


            modelBuilder.Entity<TeamMember>().HasData(
            new TeamMember
            {
                Id = "member-1",
                TeamID = "team-1",
                VolunteerID = "vol-user-1",
                JoinDate = DateTime.UtcNow.AddDays(-5),
                Role = "Leader",
                CreatedAt = DateTime.UtcNow
            }
         );


            modelBuilder.Entity<VolunteerOpportunity>().HasData(
            new VolunteerOpportunity
            {
                Id = "opp-1",
                OrganizationID = "org-user-1",
                CategoryID = "cat-edu-1",
                Title = "Teaching Kids English",
                Description = "Help young children learn basic English skills.",
                Location = "Cairo",
                StartDate = DateTime.UtcNow.AddDays(10),
                EndDate = DateTime.UtcNow.AddDays(40),
                RequiredVolunteers = 10,
                Status = OpportunityStatus.Published,
                Image = "english-teaching.png",
                CreatedAt = DateTime.UtcNow
            },
            new VolunteerOpportunity
            {
                Id = "opp-2",
                OrganizationID = "org-user-1",
                CategoryID = "cat-edu-1",
                Title = "Reading Club Facilitator",
                Description = "Lead a reading club for teenagers.",
                Location = "Assiut",
                StartDate = DateTime.UtcNow.AddDays(5),
                EndDate = DateTime.UtcNow.AddDays(25),
                RequiredVolunteers = 5,
                Status = OpportunityStatus.Published,
                Image = "reading-club.png",
                CreatedAt = DateTime.UtcNow
            },
            new VolunteerOpportunity
            {
                Id = "opp-3",
                Title = "Coding for Kids",
                Description = "Teach basic coding to children in underserved communities.",
                Location = "Jeddah",
                StartDate = DateTime.UtcNow.AddDays(10),
                EndDate = DateTime.UtcNow.AddDays(20),
                RequiredVolunteers = 15,
                Status = OpportunityStatus.Published,
                Image = "coding-kids.png",
                CreatedAt = DateTime.UtcNow,
                CategoryID = "cat-1",
                OrganizationID = "org-user-1",
                TeamId = "team-1"
            }
        );














        }



    }
}
