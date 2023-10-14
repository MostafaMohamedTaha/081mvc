// Ignore Spelling: Ef

using coreEfMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace coreEfMvc.data;

public partial class CoreEfMvcContext : DbContext
{
    public CoreEfMvcContext()
    {
    }

    public CoreEfMvcContext(DbContextOptions<CoreEfMvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("data source=.;initial catalog=CoreEfMvc; Trusted_Connection=yes; TrustServerCertificate=True");
    //=> optionsBuilder.UseSqlServer(_context);


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC071A7FD465");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC0792352058");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC0765B4A2CE");

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasConstraintName("ProductCategoryIdFk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
