using MMSalesBoard.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MMSalesBoard.Models.Identity;

namespace MMSalesBoard.DataAccess.EntityFrameworkCore
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }

        public DbSet<AppAbout> Abouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO burada database ile tablolar ilişkili şekilde koyulacaktır.


            base.OnModelCreating(modelBuilder);
        }
    }
}
