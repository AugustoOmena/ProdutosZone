using ProdutosZone.Models;

namespace ProdutosZone.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<ProdutoDevice> ProdutoDevice { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutoDevice>()
                .HasKey(e => new { e.ProdutoId, e.DeviceId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
