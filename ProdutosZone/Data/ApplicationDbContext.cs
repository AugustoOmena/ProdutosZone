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
        public DbSet<Device> Devices { get; set; }
        public DbSet<ProdutoDevice> ProdutoDevice { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(new Category[]
                {
                    new Category { Id = 1, Name = "Profissionais de Obras"},
                    new Category { Id = 2, Name = "Materiais de construção"},
                    new Category { Id = 3, Name = "Acabamentos finos"},
                    new Category { Id = 4, Name = "Cursos"},
                    new Category { Id = 5, Name = "Eletricista"},
                    new Category { Id = 6, Name = "Encanador"},
                });

            modelBuilder.Entity<Device>()
                .HasData(new Models.Device[]
                {
                    new Device { Id = 1, Name = "Ouro", Icon = "bi bi-playstation" },
                    new Device { Id = 2, Name = "Prata", Icon = "bi bi-xbox" },
                    new Device { Id = 3, Name = "Bronze", Icon = "bi bi-nintendo-switch" },
                    new Device { Id = 4, Name = "Ruby", Icon = "bi bi-pc-display" }
                });

            modelBuilder.Entity<ProdutoDevice>()
                .HasKey(e => new { e.ProdutoId, e.DeviceId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
