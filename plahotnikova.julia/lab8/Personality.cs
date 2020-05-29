using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    abstract class Personality
    {
        protected string firstname, lastname;
        protected int age, height, weight;
        protected Sex sex;
        protected DateTime birthdate;
        public abstract void CriminalRecord();
        public abstract void FamilyCondition();
    }
}