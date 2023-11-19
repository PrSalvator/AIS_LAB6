

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AIS_LAB6.DataBase
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext() : base("TPUSchoolDB")
        {

        }
        public DbSet<Models.TPUSchool> TPUSchools { get; set; }
        public DbSet<Models.TPUDirectionOfTraining> tPUDirectionOfTrainings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.TPUSchool>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Models.TPUSchool>().HasMany(p => p.DirectionOfTrainings).WithOptional(p => p.School).HasForeignKey(p => p.SchoolId);
            modelBuilder.Entity<Models.TPUDirectionOfTraining>().Property(p => p.Id).HasMaxLength(8);
        }
    }
}
