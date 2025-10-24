using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TranDucThinh_231230917_de01.models;

public partial class TranDucThinh231230917De01Context : DbContext
{
    public TranDucThinh231230917De01Context()
    {
    }

    public TranDucThinh231230917De01Context(DbContextOptions<TranDucThinh231230917De01Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TranDucThinhComputer> TranDucThinhComputers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=TRANDUCTHINH\\SQL2022;Initial Catalog=TranDucThinh_231230917_de01;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TranDucThinhComputer>(entity =>
        {
            entity.HasKey(e => e.TranDucThinhComId).HasName("PK__TranDucT__59D338ED2EE4D6C1");

            entity.ToTable("TranDucThinhComputer");

            entity.Property(e => e.TranDucThinhComId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TranDucThinhComImage).HasMaxLength(255);
            entity.Property(e => e.TranDucThinhComName).HasMaxLength(100);
            entity.Property(e => e.TranDucThinhComPrice).HasColumnType("decimal(12, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
