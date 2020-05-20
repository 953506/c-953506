using System;

namespace Pudge
{
    class GroupOfStudents : Student
    {
        string[] names = { "Stas", "Misha", "Gosha", "Masha", "Olega", "Katya" };
        Student[] students;

        public GroupOfStudents(int amount)
        {
            students = new Student[amount];
        }

        public Student this[int index]
        {
            get
            {
                return students[index];
            }
            set
            {
                students[index] = value;
            }
        }

        private int GetRandomMark()
        {
            Random rnd = new Random();

            return rnd.Next(1, 11);
        }

        private string GetRandomName()
        {
            Random rnd = new Random();
            int randNameIndex = rnd.Next(6);

            return names[randNameIndex];
        }

        public void FillRandomStudents()
        {
            for(int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(GetRandomName(), GetRandomMark());
            }
        }

        public delegate bool MarkCondition(int x);

        public void ShowStudents(MarkCondition condition)
        {
            foreach(Student st in students)
            {
                if(condition(st.AverageMark))
                {
                    Console.WriteLine($"{st.Name} - {st.AverageMark}");
                }
            }
        }

        public void ShowStudents()
        {
            foreach(Student st in students)
            {
                Console.WriteLine($"{st.Name} - {st.AverageMark}");
            }
        }
    }
}
