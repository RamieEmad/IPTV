using Iptv.Domain;
using Iptv.Domain.Leads;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Iptv.EntityFrameworkCore.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class IptvDbContext : AbpDbContext<IptvDbContext>
{
    public DbSet<Lead> Leads { get; set; }

    public IptvDbContext(
        DbContextOptions<IptvDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Lead>(b =>
        {
            b.ToTable("Leads");

            b.HasKey(x => x.Id);

            b.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            b.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(30);

            b.Property(x => x.Message)
                .HasMaxLength(1000);
        });
    }
}