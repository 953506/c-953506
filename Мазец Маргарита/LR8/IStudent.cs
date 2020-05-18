using System;
using System.Collections.Generic;
using System.Text;

namespace lr6
{
    interface IStudent
    {
        public string Specialty { get; set; }
        public double MiddleMark { get; set; } 
        public int Course { get; }

        void WriteUniversityInformation();
        void AcademicPerformance();
    }
}
