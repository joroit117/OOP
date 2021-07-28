using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConstructors
{
    class FrontEndProgrammer : Programmer
    {
        public FrontEndProgrammer(string name, int salary)
            :base(name, salary, new List<string> { "JavaScript", "React"})
        {
            Console.WriteLine("In FrontEnd");
        }
    }
}
