using Microsoft.EntityFrameworkCore;
using MvcRestApiCore3_Commander.Models;

namespace MvcRestApiCore3_Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> options):base(options)
        {
        }
        
        public DbSet<Command> Commands { get; set; }
    }
}