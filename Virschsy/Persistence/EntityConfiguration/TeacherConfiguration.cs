using System.Data.Entity.ModelConfiguration;
using Virschsy.Core.Modal;

namespace Virschsy.Persistence.EntityConfiguration
{
    public class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            HasKey(t => t.Id);
            Property(t => t.Name).IsRequired().HasMaxLength(30);
            Property(t => t.Age).HasColumnType("tinyint").IsRequired();

            HasRequired(t => t.Subject).WithMany(s => s.Teachers).HasForeignKey(t => t.SubjectId);
                
        }
    }
}
