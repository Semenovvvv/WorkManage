using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WorkManage.Data.Models;

namespace WorkManage.Data
{
    public class SeedData
    {
        public async Task InitializeAsync(ApplicationDbContext context)
        {
            var roleAdmin = new IdentityRole("Administrator");

            var roleWorker = new IdentityRole("Worker");

            await context.Roles.AddAsync(roleAdmin);
            await context.Roles.AddAsync(roleWorker);

            var user = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "email@email.ru",
                Email = "email@email.ru",
                NormalizedEmail = "EMEIL@EMAIL.RU",
                NormalizedUserName = "EMAIL@EMAIL.RU",
                LockoutEnabled = true
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            user.PasswordHash = passwordHasher.HashPassword(user, "Pass1.");

            var res = await context.Users.AddAsync(user);

            await context.SaveChangesAsync();

            var res2 = await context.UserRoles.AddAsync(
                new IdentityUserRole<string>
                {
                    RoleId = roleAdmin.Id,
                    UserId = user.Id.ToString()
                }
            );

            await context.SaveChangesAsync();
        }
    }
}
