using Microsoft.EntityFrameworkCore;
using P1_AP1_HeysonPolanco.Models;

namespace P1_AP1_HeysonPolanco.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<EntradasGuacales> EntradasGuacales { get; set; }
    }
}