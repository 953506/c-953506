using System;
using System.Collections.Generic;
using System.Text;

namespace lr6
{
    interface ITeacher
    {
        public string Classes { get; set; }
        public string AcademicRang { get; set; }
        void PutAnAverageMark(Student student);
    }
}
