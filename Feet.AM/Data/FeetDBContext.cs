using Feet.AM.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Feet.AM.Data
{
    public class FeetDbContext : DbContext
    {
        public FeetDbContext(DbContextOptions<FeetDbContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RoleMenu> RoleMenus { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //UserRole关联配置
            builder.Entity<UserRole>()
              .HasKey(ur => new { ur.UserId, ur.RoleId });

            //RoleMenu关联配置
            builder.Entity<RoleMenu>()
              .HasKey(rm => new { rm.RoleId, rm.MenuId });


            //builder.Entity<User>().HasMany(t => t.Roles).WithRequired(p => p.Company).WillCascadeOnDelete(false);
            //builder.Entity<User>().ToTable("User");
            //builder.Entity<Role>().ToTable("Role");
            //builder.Entity<Department>().ToTable("Decimal");
            //builder.Entity<Menu>().ToTable("Menu");

            base.OnModelCreating(builder);
        }
    }
}

