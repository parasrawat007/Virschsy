using System;

namespace Virschsy.Core.Modal
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }

        public int SubjectId { get; set; }
        virtual public Subject Subject { get; set; }
    }
}
