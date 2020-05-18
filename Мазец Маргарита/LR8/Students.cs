using System;
using System.Collections.Generic;
using System.Text;

namespace lr6
{
    class Students : IComparer<IStudent>
    {
        Student[] student;

        public Students()
        {
            student = new Student[Count];
        }

        public int Count { get =>10; } 

        public Student this[int index]
        {
            get =>student[index];
            set =>student[index] = value;
        }
        
        public int Compare(IStudent s1, IStudent s2)
        {
            if (s1.MiddleMark > s2.MiddleMark)
                return 1;
            else if (s1.MiddleMark < s2.MiddleMark)
                return -1;
            else
                return 0;
        }

        public void Rating()
        {
            for (int i = 1; i < 10; i++)
                for (int j =0; j < 9; j++)
                    if (Compare(student[j+1], student[j]) == 1)
                    {
                        Student st = (Student)student[j].Clone();
                        student[j] = (Student)student[j + 1].Clone();
                        student[j + 1] = (Student)st.Clone();
                    }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{student[i].Name} {student[i].SurName} ------------{student[i].MiddleMark}");
            }
        }
    }
}
