using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit263Chapter11
{
    public class UniversityMember : Object
    {
        private string first_name;
        private string last_name;
        private string muid;

        public string First_name { get { return first_name; } set { first_name = value; } }
        public string Last_name { get { return last_name; } set { last_name = value; } }
        public string MUID { get { return muid; } set { muid = value; } }

        public UniversityMember(string f, string l, string m)
        {
            MUID = m;
            First_name = f;
            Last_name = l;
        }
        public override string ToString()
        {
            string result = first_name + " " + last_name + " " + muid;
            return result;
        }
    }
}
