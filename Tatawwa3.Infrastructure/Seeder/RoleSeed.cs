using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;

namespace FleetTrackerSystem.Infrastructure.Seeder
{
    public static class RoleSeed
    {
        public static async Task SeedAsync(RoleManager<ApplicationRole> roleManager)
        {
            var roleCount =  roleManager.Roles.Count();
            if (roleCount <= 0)
            {

                await roleManager.CreateAsync(new ApplicationRole() { Name = "Volunteer" });
                await roleManager.CreateAsync(new ApplicationRole() { Name = "Organization" });
                await roleManager.CreateAsync(new ApplicationRole() { Name = "Admin" });
            }
        }
    }
}
