using AspNetCoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace AspNetCoreMVC.Data;

public partial class LibraryDbCopyContext : DbContext
{
    public LibraryDbCopyContext()
    {
    }

    public LibraryDbCopyContext(DbContextOptions<LibraryDbCopyContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=library_db_copy;Username=postgres;Password=postgres");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public virtual DbSet<Book> Books { get; set; }
}
