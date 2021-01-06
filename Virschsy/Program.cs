using System;
using System.Collections.Generic;
using Virschsy.Core.Modal;
using Virschsy.Drawing;

namespace Virshlrecsys
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var draw = new Draw<Student>();
            draw.SpreedSheet(new List<Student>() { new Student {Name="Hero",Age=20 } });
        }
    }
}
