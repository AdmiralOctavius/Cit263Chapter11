using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit263Chapter11
{
    public class Faculty: Employee
    {
        public string department;
        public Faculty(string f, string l, string m, decimal s, string d): base(f, l, m, s)
        {
            department = d;
        }
        public override string ToString()
        {
            string result = base.ToString() + " " + department;
            return result;
        }
    }
}
