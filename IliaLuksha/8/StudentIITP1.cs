using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StudentIITP1: StudentIITP
    {
        Marks student = new Marks(8);
        public StudentIITP1()
        {
            _faculty = "ФКСиС";
            _specialty = "Информатика и технологии программирования";
            _course = 1;
            _group = 953506;
            Marks Student = new Marks(9);
        }
        public delegate void Markss(int marks);
        public event Named IsMarks;
        public void CoutMarks()
        {
            IsMarks?.Invoke("Create a evaluation");
            student.CoutMarks();
        }
    }
}
