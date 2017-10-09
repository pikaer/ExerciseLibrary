using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace EFDAL.Migrations
{
    public class MyHistoryContext : HistoryContext
    {
        public MyHistoryContext(
            DbConnection existingConnect,
            string defaultSchema)
            : base(existingConnect, defaultSchema)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(DefaultSchema);
            modelBuilder.Entity<HistoryRow>().ToTable(DefaultTableName);
            modelBuilder.Entity<HistoryRow>().HasKey(
                h => new
                {
                    h.MigrationId,
                    h.ContextKey
                });
            modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(512).IsRequired();
            modelBuilder.Entity<HistoryRow>().Property(h => h.Model).IsRequired().IsMaxLength();
            modelBuilder.Entity<HistoryRow>().Property(h => h.ProductVersion).HasMaxLength(255).IsRequired();
        }

      
    }
}
