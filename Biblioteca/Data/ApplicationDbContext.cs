using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<EmprestimoModel> Emprestimos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmprestimoModel>(entity =>
        {
            entity.Property(e => e.DataAtualizacao)
                .HasColumnType("datetime2");
        });

        base.OnModelCreating(modelBuilder);
    }
}
