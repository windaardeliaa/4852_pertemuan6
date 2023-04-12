using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4852_tugas6
{
    class Member
    {
        private string name;
        private int line;

        public Member(string n, int l)
        {
            name = n;
            line = l;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Line
        {
            get { return line; }
            set { line = value; }
        }


    }
}
