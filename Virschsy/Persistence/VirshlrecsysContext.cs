using System.Data.Entity;
using Virschsy.Core.Modal;
using Virschsy.Persistence.EntityConfiguration;

namespace Virschsy.Persistence
{
    public class VirshlrecsysContext:DbContext
    {
        public VirshlrecsysContext():base("TestDb")
        {

        }
     
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new TeacherConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
