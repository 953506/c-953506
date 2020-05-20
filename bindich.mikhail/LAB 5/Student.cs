using System;

namespace _5
{
    public class Student : Human
    {
        public int course;
        public int facultyID;
        public string faculty;
        public string speciality;

        // Перечисление
        enum faculties
        {
            FKP = 1,
            FITU,
            FRE,
            FKSIS,
            FITR
        }

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            course = 0;
            facultyID = 2;
            faculty = getFaculty(facultyID);
            speciality = "";
        }        

        public float getAverageMark()
        {
            return 0;
        }

        public string getFaculty(int faculty)
        {
            switch (faculty)
            {
                case (int)faculties.FITR: return ("FACULTY OF INFORMATION TECHNOLOGIES AND ROBOTICS");
                case (int)faculties.FKP: return ("FACULTY OF COMPUTER-AIDED DESIGN");
                case (int)faculties.FITU: return ("FACULTY OF INFORMATION TECHNOLOGIES AND CONTROL");
                case (int)faculties.FKSIS: return ("FACULTY OF COMPUTER SYSTEMS AND NETWORKS");
                case (int)faculties.FRE: return ("FACULTY OF RADIOENGINEERING AND ELECTRONICS");
                default: return ("");
            }
        }

        new public void doWork()
        {
            int tmp = goToUniversity();
            if (tmp == 0)
            {
                tmp = doStudy();
            }
            if (tmp == 0)
            {
                getStipend();
            }
        }

        private int goToUniversity()
        {
            return 0;
        }

        private int doStudy()
        {
            return 0;
        }

        private int getStipend()
        {
            return 0;
        }

        public void studentPrintInfo()
        {
            Console.WriteLine("= = = = = = = = = =\nPerson\n= = = = = = = = = =");
            Console.WriteLine($"First name     || {this.firstName}");
            Console.WriteLine($"Last name      || {this.lastName}");
            Console.WriteLine($"Height         || {this.height}");
            Console.WriteLine($"Weight         || {this.weight}");
            Console.WriteLine($"Course         || {this.course}");
            Console.WriteLine($"Faculty        || {this.faculty}");
            Console.WriteLine($"Speciality     || {this.speciality}");
            Console.WriteLine("= = = = = = = = = =");
        }
    }
}
