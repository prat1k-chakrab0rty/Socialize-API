using Microsoft.EntityFrameworkCore;
using Socialize.Domain.EntityModel;

namespace Socialize.DB
{
    public class SocializeContext : DbContext
    {
        public SocializeContext(DbContextOptions<SocializeContext> options) : base(options)
        { }


        public DbSet<User> Users { get; set; }
    }
}
