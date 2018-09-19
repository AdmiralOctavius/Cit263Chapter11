using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit263Chapter11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Name","LName","msfsd");
            Faculty faculty1 = new Faculty("Isaac", "Bennett", "Asdfwv", 100, "Cit");
            Console.WriteLine(faculty1.ToString());
        }
    }
}
