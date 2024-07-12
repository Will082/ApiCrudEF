using ApiCrud.Estudantes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ApiCrud.Data
{
    public class AppDbContext : DbContext
    {
        DbSet<Estudante> Estudantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                @"Server=locahost, 1433;Database=ApiCrud;User Id=sa;Password=MgtsP@4152;",
                options => options.EnableRetryOnFailure());
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}