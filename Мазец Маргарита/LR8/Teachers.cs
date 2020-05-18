using System;
using System.Collections.Generic;
using System.Text;

namespace lr6
{
    class Teachers
    {
        Teacher[] teacher;

        public Teachers()
        {
            teacher = new Teacher[Count];
        }

        public int Count { get=> 3; } 

        public Teacher this[int index]
        {
            get=> teacher[index];
            set =>teacher[index] = value;
        }
    }
}
