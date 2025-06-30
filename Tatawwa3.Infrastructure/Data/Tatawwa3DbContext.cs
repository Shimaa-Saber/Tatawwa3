
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
        public DbSet<VolunteerInvitation> VolunteerInvitations {  get; set; }








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
                IsVerified = true
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

            //modelBuilder.Entity<VolunteerProfile>().HasData(new VolunteerProfile
            //{
            //    Id ="Vol-profile2",
            //    UserID = "1b5b5731-bcf1-4178-87ad-cf43dac0bbeb",
            //    TotalHours = 6,
            //    Rating = 9,
            //    Interests = "[\"برمجة\",رسم\"\"]",
            //    IsVerified = false
            //});
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
            },
             new VolunteerOpportunity
             {
                 Id = "opp-4",
                 Title = "programing",
                 Description = "Teach basic coding to adults in underserved communities.",
                 Location = "Assiut",
                 StartDate = DateTime.UtcNow.AddDays(10),
                 EndDate = DateTime.UtcNow.AddDays(20),
                 RequiredVolunteers = 15,
                 Status = OpportunityStatus.Published,
                 Image = "coding-kids.png",
                 CreatedAt = DateTime.UtcNow,
                 CategoryID = "cat-edu-1",
                 OrganizationID = "org-user-1",
                 TeamId = "cf0cf8e1-5a62-4315-9c90-3f8b727b8251"
             }
        );

     modelBuilder.Entity<Application>().HasData(
    new Application
    {
        Id = "app-1",
        OpportunityID = "opp-1",              
        VolunteerID = "vol-user-1",          
        Status = ApplicationStatus.Pending,
        Note = "Looking forward to this opportunity.",
        ApplicationDate = new DateTime(2025, 6, 1),
        MotivationLetter = "I am passionate about helping children learn.",
        HasRequiredSkills = true,
        AttachmentPath = null,
        CreatedAt = DateTime.UtcNow
    },
    new Application
    {
        Id = "app-2",
        OpportunityID = "opp-2",
        VolunteerID = "vol-user-1",
        Status = ApplicationStatus.Accepted,
        Note = "Excited to participate.",
        ApplicationDate = new DateTime(2025, 6, 15),
        MotivationLetter = "I have prior experience in similar events.",
        HasRequiredSkills = true,
        AttachmentPath = "attachments/volunteer_cv.pdf",
        CreatedAt = DateTime.UtcNow
    },

    new Application
    {
        Id = "app-3",
        OpportunityID = "opp-1",
        VolunteerID = "vol_prof2",
        Status = ApplicationStatus.Pending,
        Note = "Excited to participate.",
        ApplicationDate = new DateTime(2025, 6, 15),
        MotivationLetter = "I have prior experience in similar events.",
        HasRequiredSkills = true,
        AttachmentPath = "attachments/volunteer_cv.pdf",
        CreatedAt = DateTime.UtcNow
    },
     new Application
     {
         Id = "app-4",
         OpportunityID = "opp-4",
         VolunteerID = "vol_prof2",
         Status = ApplicationStatus.Pending,
         Note = "Excited to participate.",
         ApplicationDate = new DateTime(2025, 6, 15),
         MotivationLetter = "I have prior experience in similar events.",
         HasRequiredSkills = true,
         AttachmentPath = "attachments/volunteer_cv.pdf",
         CreatedAt = DateTime.UtcNow
     }
);

            modelBuilder.Entity<Participation>().HasData(
           new Participation
           {
               Id = "participation-1",
               ApplicationID = "app-1",
               OpportunityId = "opp-1",
               VolunteerID = "vol-user-1",
               TotalAttendedHours = 12.5f,
               FirstCheckIn = new DateTime(2025, 6, 10, 9, 0, 0),
               LastCheckOut = new DateTime(2025, 6, 12, 17, 0, 0),
               Status = ParticipationStatus.Completed,
               CreatedAt = DateTime.UtcNow
           },
           new Participation
           {
               Id = "participation-2",
               ApplicationID = "app-2",
               OpportunityId = "opp-2",
               VolunteerID = "vol-user-1",
               TotalAttendedHours = 8.0f,
               FirstCheckIn = new DateTime(2025, 6, 15, 10, 0, 0),
               LastCheckOut = new DateTime(2025, 6, 15, 18, 0, 0),
               Status = ParticipationStatus.Completed,
               CreatedAt = DateTime.UtcNow
           },
           new Participation
           {
               Id = "participation-3",
               ApplicationID = "app-3",
               OpportunityId = "opp-1",
               VolunteerID = "vol_prof2",
               TotalAttendedHours = 12.5f,
               FirstCheckIn = new DateTime(2025, 6, 10, 9, 0, 0),
               LastCheckOut = new DateTime(2025, 6, 12, 17, 0, 0),
               Status = ParticipationStatus.Completed,
               CreatedAt = DateTime.UtcNow
           },
            new Participation
            {
                Id = "participation-4",
                ApplicationID = "app-4",
                OpportunityId = "opp-4",
                VolunteerID = "vol_prof2",
                TotalAttendedHours = 12.5f,
                FirstCheckIn = new DateTime(2025, 6, 10, 9, 0, 0),
                LastCheckOut = new DateTime(2025, 6, 12, 17, 0, 0),
                Status = ParticipationStatus.Completed,
                CreatedAt = DateTime.UtcNow
            }
       );

    modelBuilder.Entity<Certificate>().HasData(
    new Certificate
    {
        Id = "cert-1",
        ParticipationID = "participation-1",
        VolunteerID = "vol-user-1",
        CertificateNumber = "CERT-2025-001",
        Title = "Coding for Kids Participation",
        Issuer = "Seeded Org",
        IssueDate = new DateTime(2025, 6, 20),
        TotalHours = 12.5f,
        FileUrl = null,
        IsVerified = true,
        VerificationCode = "VERIF123",
        CreatedAt = DateTime.UtcNow
    },
    new Certificate
    {
        Id = "cert-2",
        ParticipationID = "participation-3",
        VolunteerID = "vol_prof2",
        CertificateNumber = "CERT-2025-001",
        Title = "Coding for Kids Participation",
        Issuer = "Seeded Org",
        IssueDate = new DateTime(2025, 6, 20),
        TotalHours = 12.5f,
        FileUrl = null,
        IsVerified = true,
        VerificationCode = "VERIF123",
        CreatedAt = DateTime.UtcNow
    }
);

















        }



    }
}
