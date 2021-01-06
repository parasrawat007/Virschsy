using System.Collections.ObjectModel;

namespace Virschsy.Core.Modal
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Collection<Teacher> Teachers { get; set; }
        public virtual Collection<Student> Students { get; set; }
        
    }
}
