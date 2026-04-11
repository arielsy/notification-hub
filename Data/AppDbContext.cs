using Microsoft.EntityFrameworkCore;

namespace NotificationHub.Data;
public class AppDbContext : DbContext
{
    public DbSet<NotificationEntity> Notifications => Set<NotificationEntity>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NotificationEntity>(entity => {
            entity.ToTable("Notifications");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.ChannelType).HasMaxLength(50).IsRequired();
            entity.Property(e => e.ChannelFrom).HasMaxLength(256).IsRequired();
            entity.Property(e => e.ChannelTo).HasMaxLength(256).IsRequired();
            entity.Property(e => e.NotificationType).HasMaxLength(50).IsRequired();
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.Body).HasMaxLength(4000);
        });
    }
}