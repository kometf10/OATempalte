using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OA.DataAccess;
using OA.Domin.Administration;
using OA.Domin.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedsController : ControllerBase
    {

        private readonly AppDbContext DbContext;
        private readonly UserManager<User> UserManager;
        public SeedsController(AppDbContext dbContext, UserManager<User> userManager)
        {
            DbContext = dbContext;
            UserManager = userManager;
        }

        [HttpGet("SeedIdentity")]
        public async Task<IActionResult> SeedIdentity()
        {
            //Seed Claims
            var existedPermissions = DbContext.PermissionClaims.Any();
            if (!existedPermissions)
            {
                var permissions = new List<PermissionClaim>()
                {
                    new PermissionClaim{ Name = "Administration Roles", Type = "Permission",  Value = "administration-roles"},
                    new PermissionClaim{ Name = "Administration Users", Type = "Permission",  Value = "administration-users"},
                    new PermissionClaim{ Name = "Control App Settings", Type = "Permission",  Value = "app-settings-control"},
                    new PermissionClaim{ Name = "Access Audit Log", Type = "Permission",  Value = "audeting-access"},
                    new PermissionClaim{ Name = "Access Error Log", Type = "Permission",  Value = "error-log-access"},
                    new PermissionClaim{ Name = "Control Push Notification", Type = "Permission",  Value = "push-notification-control"},
                    new PermissionClaim{ Name = "Control Reporting, Type", Type = "Permission",  Value = "reporting-control"},
                };

                DbContext.PermissionClaims.AddRange(permissions);
                DbContext.SaveChanges();
            }

            //Seed Admin User
            var existedRols = DbContext.Roles.Any();
            if (!existedRols)
            {
                var adminRole = new IdentityRole { Name = "Admin" };
                DbContext.Roles.Add(adminRole);
                DbContext.SaveChanges();

                var existedUser = DbContext.Users.Any();
                if (!existedUser)
                {
                    var adminUser = new User { Email = "Admin@app.com", UserName = "Administrator", ConfirmedAccount = true, FirstUse = false };
                    var createdUser = await UserManager.CreateAsync(adminUser, "Admin@123");
                    if (createdUser.Succeeded)
                    {
                        DbContext.UserRoles.Add(new IdentityUserRole<string>() { UserId = adminUser.Id, RoleId = adminRole.Id });
                        DbContext.SaveChanges();
                    }
                }
            }

            return Ok();

        }

        [HttpGet("SeedSettings")]
        public IActionResult SeedSettings()
        {
            var existedPermissions = DbContext.AppSettings.Any();
            if (!existedPermissions)
            {
                var permissions = new List<AppSetting>()
                {
                    new AppSetting{ Key = "ForceChangePasswordEvery", Value = "0"},
                    new AppSetting{ Key = "ForceChangePasswordFirstUse", Value = "false"},
                    new AppSetting{ Key = "PasswordChangePoicy", Value = "false"},
                    new AppSetting{ Key = "Profiling", Value = "true"},
                    new AppSetting{ Key = "Registration", Value = "true"},
                    new AppSetting{ Key = "RegistrationAdminConfirm", Value = "true"},
                    new AppSetting{ Key = "ResetPasswordPassed", Value = "false"},
                };

                DbContext.AppSettings.AddRange(permissions);
                DbContext.SaveChanges();
            }

            return Ok();
        }

    }
}
