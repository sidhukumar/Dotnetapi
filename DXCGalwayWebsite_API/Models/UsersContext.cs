using Microsoft.EntityFrameworkCore;
using DXCGalwayWebsite_API.Models;

namespace DXCGalwayWebsite_API.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<DXCGalwayWebsite_API.Models.Departments> Departments { get; set; }
    }
}