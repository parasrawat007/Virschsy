using System.Data.Entity.ModelConfiguration;
using Virschsy.Core.Modal;

namespace Virschsy.Persistence.EntityConfiguration
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            HasKey(s => s.Id);
            Property(s => s.Name).IsRequired().HasMaxLength(30);
            Property(s => s.Age).HasColumnType("tinyint").IsRequired();


            HasMany(s => s.Subject).WithMany(s => s.Students).Map(c=> {
                c.MapLeftKey("StudentId");
                c.MapRightKey("SubjectId");
                c.ToTable("StudentsSubject");
                });
            
        }
    }
}
