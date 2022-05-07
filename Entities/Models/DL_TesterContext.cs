using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Entities.Models
{
    public partial class DL_TesterContext : DbContext
    {
        public DL_TesterContext()
        {
        }

        public DL_TesterContext(DbContextOptions<DL_TesterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DataSchedual> DataScheduals { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<MonitorList> MonitorLists { get; set; }
        public virtual DbSet<OutputType> OutputTypes { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<SpecialHeader> SpecialHeaders { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ValuesTime> ValuesTimes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-68N1I5V\\SQLEXPRESS;Initial Catalog=DL_Tester;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<DataSchedual>(entity =>
            {
                entity.HasKey(e => e.SchedId);

                entity.Property(e => e.SchedId).HasColumnName("SchedID");

                entity.Property(e => e.MonitorsVal)
                    .IsRequired()
                    .HasColumnName("monitorsVal");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<Destination>(entity =>
            {
                entity.Property(e => e.DestinationId).HasColumnName("DestinationID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .HasColumnName("IPaddress");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ProtocolType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SrvPassword).HasMaxLength(30);

                entity.Property(e => e.SrvUser).HasMaxLength(20);

                entity.Property(e => e.VirtualPath).HasMaxLength(80);
            });

            modelBuilder.Entity<MonitorList>(entity =>
            {
                entity.HasKey(e => e.MonListId);

                entity.Property(e => e.MonListId).HasColumnName("MonListID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<OutputType>(entity =>
            {
                entity.Property(e => e.OutputTypeId).HasColumnName("OutputTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DestinationId).HasColumnName("DestinationID");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.MonitorListId).HasColumnName("MonitorListID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.OutputTypeId).HasColumnName("OutputTypeID");

                entity.Property(e => e.SpecHeaderId).HasColumnName("SpecHeaderID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ValTimesId).HasColumnName("ValTimesID");

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.DestinationId)
                    .HasConstraintName("FK_Sessions_Destinations");

                entity.HasOne(d => d.MonitorList)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.MonitorListId)
                    .HasConstraintName("FK_Sessions_MonitorLists");

                entity.HasOne(d => d.OutputType)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.OutputTypeId)
                    .HasConstraintName("FK_Sessions_OutputTypes");

                entity.HasOne(d => d.SpecHeader)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.SpecHeaderId)
                    .HasConstraintName("FK_Sessions_SpecialHeaders");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Sessions_users");
            });

            modelBuilder.Entity<SpecialHeader>(entity =>
            {
                entity.HasKey(e => e.SpecHeaderId);

                entity.Property(e => e.SpecHeaderId)
                    .ValueGeneratedNever()
                    .HasColumnName("SpecHeaderID");

                entity.Property(e => e.Line1).HasMaxLength(200);

                entity.Property(e => e.Line2).HasMaxLength(200);

                entity.Property(e => e.Line3).HasMaxLength(200);

                entity.Property(e => e.Line4).HasMaxLength(200);

                entity.Property(e => e.Line5).HasMaxLength(200);

                entity.Property(e => e.Line6).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ValuesTime>(entity =>
            {
                entity.HasKey(e => e.ValTimesId)
                    .HasName("PK_ValuesTimes_1");

                entity.Property(e => e.ValTimesId).HasColumnName("ValTimesID");

                entity.Property(e => e.MonFrom).HasMaxLength(250);

                entity.Property(e => e.MonListId).HasColumnName("MonListID");

                entity.Property(e => e.MonNames).HasMaxLength(250);

                entity.Property(e => e.MonTo).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(25);

                entity.HasOne(d => d.MonList)
                    .WithMany(p => p.ValuesTimes)
                    .HasForeignKey(d => d.MonListId)
                    .HasConstraintName("FK_ValuesTimes_MonitorLists");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
