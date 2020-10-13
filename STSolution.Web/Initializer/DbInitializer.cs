using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using STSolution.Web.Services;

namespace STSolution.Web.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(AppDbContext appDbContext, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initialize()
        {
            try
            {
                if (_appDbContext.Database.GetPendingMigrations().Count() > 0)
                {
                    _appDbContext.Database.Migrate();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            if (_appDbContext.Roles.Any(r=>r.Name == Role.Administrator)) return;

            _roleManager.CreateAsync(new IdentityRole(Role.Administrator)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(Role.Subscriber)).GetAwaiter().GetResult();

            _userManager.CreateAsync(new IdentityUser
            {
                UserName = "admin@live.com",
                Email = "admin@live.com",
            }, "admin").GetAwaiter().GetResult();

            IdentityUser user = _appDbContext.Users.Where
                (u => u.Email == "admin@live.com").FirstOrDefault();

            _userManager.AddToRoleAsync(user, Role.Administrator).GetAwaiter().GetResult();
        }
    }
}