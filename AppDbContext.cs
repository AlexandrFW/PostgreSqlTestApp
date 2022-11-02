using Microsoft.EntityFrameworkCore;

namespace PostgreSqlTestApp;

internal class AppDbContext : DbContext
{
    public DbSet<User>? Users { get; set; } = null;

    //public AppDbContext()
    //{
    //    Database.EnsureCreated();
    //}

    protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
    {
        contextOptionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb2;Username=postgres;Password=здесь_указывается_пароль_от_postgres");
    }
}