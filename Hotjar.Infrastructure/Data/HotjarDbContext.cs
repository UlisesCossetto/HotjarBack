using System;
using System.Collections.Generic;
using System.Reflection;
using Hotjar.Core.Entidades;
using Hotjar.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotjar.Infrastructure.Data;

public partial class HotjarDbContext : DbContext
{
    public HotjarDbContext()
    {
    }
    public HotjarDbContext(DbContextOptions<HotjarDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<BooksPerUsers> BooksPerUsers { get; set; }
    public virtual DbSet<EnjoymentForm> EnjoymentForms { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseMySql("server=127.0.0.1;user id=root;password=33286489;database=HotjarDb", Microsoft.EntityFrameworkCore.ServerVersion.Parse("11.2.2-mariadb"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
