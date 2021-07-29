using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class Child : Base
    {
        public Child()
        {
            this.protectedField = 5;
        }
    }
}
