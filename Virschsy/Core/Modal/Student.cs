using System.Collections.ObjectModel;

namespace Virschsy.Core.Modal
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }

        virtual public Collection<Subject> Subject { get; set; }
    }
}
