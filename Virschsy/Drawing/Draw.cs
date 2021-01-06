using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virschsy.Drawing
{
    public class Draw<Row>
    {
        public void SpreedSheet(ICollection<Row> a)
        {

           
           var Headings= typeof(Row).GetProperties();

            int[] b = new int[Headings.Length];
            int i = 0;
            foreach (var item in Headings)
            {
                if (item.PropertyType.Name == typeof(Int16).Name)
                {
                    b[i] = Int16.MaxValue.ToString().Length;
                }
                else if (item.PropertyType.Name == typeof(Int32).Name)
                {
                    b[i] = Int32.MaxValue.ToString().Length;
                }
                else if (item.PropertyType.Name == typeof(Int64).Name)
                {
                    b[i] = Int64.MaxValue.ToString().Length;
                }
                else if (item.PropertyType.Name == typeof(string).Name)
                {
                    b[i] = 30;
                }
                else if (item.PropertyType.Name == typeof(bool).Name)
                {
                    b[i] = 5;
                }
                else if (item.PropertyType.Name == typeof(byte).Name)
                {
                    b[i] = byte.MaxValue.ToString().Length;
                }
                else if (item.PropertyType.Name == typeof(sbyte).Name)
                {
                    b[i] = sbyte.MaxValue.ToString().Length;
                }
                else if (item.PropertyType.Name == typeof(Single).Name)
                {
                    b[i] = Single.MaxValue.ToString().Length;
                }
                else if (item.PropertyType.Name == typeof(float).Name)
                {
                    b[i] = float.MaxValue.ToString().Length;
                }
                else if (item.PropertyType.Name == typeof(double).Name)
                {
                    b[i] = double.MaxValue.ToString().Length;
                }

                i++;
            }
            i = 0;
            for (int j = 0; j < Headings.Length; j++)
            {
                i += b[j];
            }
            i += Headings.Length+1;
            Console.Write(" -");
            for (int j = 0; j < i; j++)
            {
                Console.Write("-");
            }
            Console.WriteLine($"Value OF j ={ b[2]}");
            Console.Write("\n | ");
            i = 0;
            foreach (var item in Headings)
            {
                
                Console.Write(item.Name);
                for (int j = 0; j < b[i] - item.Name.Length; j++)
                {
                    Console.Write($" {b[i]-item.Name.Length} ");
                }
                Console.Write(" | ");
                i++;
            }
            Console.Write(" |");
                //Console.WriteLine(item.Name + "\t" +);

            }
    }
}
