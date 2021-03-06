using Microsoft.EntityFrameworkCore;

namespace WebGame.Components.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options) { }
    }
}