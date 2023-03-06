using MauiApp.DAL.Entities;
using MauiApp1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp.DAL;

internal class MauiAppDbContext : DbContext
{
    private readonly bool _seedDemoData;
    public MauiAppDbContext(DbContextOptions contextOptions, bool seedDemoData = false)
        : base(contextOptions) =>
        _seedDemoData = seedDemoData;

    public DbSet<UserEntity> Users => Set<UserEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>().
           HasMany(i => i.Items).
           WithOne(i => i.User);

        modelBuilder.Entity<ItemEntity>().
            HasOne(i => i.User).
            WithMany(i => i.Items);
    }
}
