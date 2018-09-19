using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit263Chapter11
{
    public class Employee : UniversityMember
    {
        public decimal salary;

        public Employee(string f, string l, string m, decimal s) : base(f, l, m)
        {
            Salary = s;

        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override string ToString()
        {
            string result = base.ToString() + " " + salary;
            return result;
        }

        
    }
}
