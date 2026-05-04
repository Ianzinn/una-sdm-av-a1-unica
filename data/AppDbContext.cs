using Microsoft.EntityFrameworkCore;
using ValeAtivos324153108.Models;

namespace ValeAtivos324153108.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Equipamento> Equipamentos { get; set; }
}
