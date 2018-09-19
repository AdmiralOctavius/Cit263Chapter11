using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit263Chapter11
{
    public class Student : UniversityMember
    {
        public Student(string f, string l, string m): base(f, l, m)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
