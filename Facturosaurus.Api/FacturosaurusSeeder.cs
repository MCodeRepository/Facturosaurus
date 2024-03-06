using Facturosaurus.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturosaurus.Api
{
    public class FacturosaurusSeeder
    {
        FacturosaurusDbContext _dbContext;
        public FacturosaurusSeeder(FacturosaurusDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Roles.Any())
                {
                    var roles = GetRoles();
                    _dbContext.Roles.AddRange(roles);
                    _dbContext.SaveChanges();
                }

                if (!_dbContext.Users.Any())
                {
                    var user = GetUsers();

                    if (user != null)
                    {
                        _dbContext.Users.AddRange(user);
                        _dbContext.SaveChanges();
                    }
                }
            }
        }

        private List<Role> GetRoles()
        {
            var roles = new List<Role>()
            {
                new Role() { Name="Administrator" },
                new Role() { Name="Użytkownik" }
            };

            return roles;
        }

        private List<User> GetUsers()
        {
            var role = _dbContext.Roles.Where(r => r.Name == "Administrator").FirstOrDefault();

            if (role != null)
            {
                var users = new List<User>()
                    {
                        new User() {
                            FirstName = "admin",
                            LastName="admin",
                            CreatedDate=DateTime.Now,
                            Email="admin@admin.pl",
                            PhoneNumber="+48111111111",
                            PasswordHash="",
                            RoleId= role.Id,
                            Active=true,
                        }
                    };
                return users;
            }
            return null;
        }
    }
}