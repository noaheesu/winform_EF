using Microsoft.EntityFrameworkCore;

namespace WinFormsAppEF.Models;

public partial class WinformDbContext : DbContext
{
    public WinformDbContext()
    {
    }

    public WinformDbContext(DbContextOptions<WinformDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserInformation> UserInformations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=WinformDB;Integrated Security=False;Persist Security Info=False;Encrypt=False;User ID=sa;Password=jgx!123;");
    {
        //if (!optionsBuilder.IsConfigured)
        //{
        //    optionsBuilder.UseSqlServer(
        //        ConfigurationManager.ConnectionStrings["WinformDB"].ConnectionString);
        //}



        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = "Data Source=(local);Initial Catalog=WinformDB;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=jgx!123;Encrypt=False;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserInformation>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__User_Inf__C5B19602F1700CD4");

            entity.ToTable("User_Information");

            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.ModifiedBy).IsUnicode(false);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.RowStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.UserFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserMiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


}
