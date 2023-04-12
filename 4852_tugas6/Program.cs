using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4852_tugas6
{
    class Program
    {
        static void Main(string[] args)
        {
            Member m = new Member("Jae", 92);

            Console.WriteLine("======================================");
            Console.WriteLine("Name " + m.Name + ", Line " + m.Line);

            Console.WriteLine("");

            m.Name = "Brian";
            m.Line = 93;

            Console.WriteLine("Name " + m.Name + ", Line " + m.Line);
            Console.WriteLine("======================================");

            Console.WriteLine("");
        }
    }
}
