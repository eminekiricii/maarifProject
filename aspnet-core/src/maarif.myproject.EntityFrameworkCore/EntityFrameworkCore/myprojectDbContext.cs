using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using maarif.myproject.Authorization.Roles;
using maarif.myproject.Authorization.Users;
using maarif.myproject.MultiTenancy;

namespace maarif.myproject.EntityFrameworkCore
{
    public class myprojectDbContext : AbpZeroDbContext<Tenant, Role, User, myprojectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public myprojectDbContext(DbContextOptions<myprojectDbContext> options)
            : base(options)
        {
        }
    }
}
