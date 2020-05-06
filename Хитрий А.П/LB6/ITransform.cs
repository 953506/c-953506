using System;
using static System.Console;

    interface ITransform <T> where T : Programmer
    {
        public static void Comparison(T a,T b)
        {
            if (a.Name != b.Name || a.SurName != b.SurName || a.Age != b.Age || a.High != b.High || a.Weight != b.Weight || a.Nationality != b.Nationality || a.Sex != b.Sex)
                 WriteLine("Класс не похож на шаблон"); 
            else WriteLine("Класс похож на шаблон");
        }
        public static void ChangeWork(T a)
        {
            a.Salary = 0;
            a.EmploymentHistory = 0;
            a.ManagerialExperience = 0;
            a.OtherAllowances = 0;
            a.DaysOfSick = 0;
            a.DaysOfVacation = 0;
            a.Award = new string[1];
            a.Award[0] = "";
            a.Penalty = new string[1];
            a.Penalty[0] = "";
            a.Languages = new string[1];
            a.Languages[0] = "";
        }
        public static void ChangeProg(T a)
        {
            a.Education = "";
            a.Specialization = "";
            a.Job = "";
            a.ProgramLanguage = new string[1];
            a.ProgramLanguage[0] = "";
        }
}
