using System;
using Microsoft.AspNetCore.Identity;

namespace MtRoseConsultingWebsite.Data
{
	public class DatabaseSeeder
	{
        public static void CreateAdminUserAndRole(ApplicationDbContext context)
        {
            var Admin = context.Users.FirstOrDefault(a => a.Email.Equals("admin@mtrose"));
            if (Admin == null)
            {
                context.Users.Add(new Models.User
                {
                    Id = "eec345fa-120d-4281-8525-58b485ac3016",
                    FirstName = "Mount",
                    LastName = "Rose",
                    CompanyName = "MountRose",
                    UserName = "admin@mtrose",
                    NormalizedUserName = "ADMIN@MTROSE",
                    Email = "admin@mtrose",
                    NormalizedEmail = "ADMIN@MTROSE",
                    EmailConfirmed = true,
                    // Password = Password1!
                    PasswordHash = "AQAAAAEAACcQAAAAEP6p6aFLr8AIyxv1XigK+KMKVv/RXU6gMMHg87kG5PoWr7+Mz1oeDX6ohqYM2Y9hKQ==",
                    SecurityStamp = "EN2HO6HMVXP6N7ZT4CQRXIW7CT3WLX56",
                    ConcurrencyStamp = "dba8beca-485d-468a-b992-e100363b0eb1",
                    PhoneNumber = "(555) 555-5555",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                });
            }

            var adminRole = context.Roles.FirstOrDefault(r => r.NormalizedName == "ADMIN");
            if (adminRole == null)
            {
                context.Roles.Add(new IdentityRole
                {
                    Id = "4ab953b9-47ac-43ad-803a-e5bfd25f2ea1",
                    Name = "admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "49501a2a-62b0-4b90-8e46-177de83302c7"
                });
            }

            var userRole = context.UserRoles.FirstOrDefault(r => r.RoleId == "4ab953b9-47ac-43ad-803a-e5bfd25f2ea1" && r.UserId == "eec345fa-120d-4281-8525-58b485ac3016");
            if (userRole == null)
            {
                context.UserRoles.Add(userRole = new IdentityUserRole<string>
                {
                    RoleId = "4ab953b9-47ac-43ad-803a-e5bfd25f2ea1",
                    UserId = "eec345fa-120d-4281-8525-58b485ac3016"
                });
            }


            context.SaveChanges();
        }


        public DatabaseSeeder()
		{
		}
	}
}

