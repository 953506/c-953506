using System;

namespace programming_paradigms
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Human [] human = new Human[10];
            for(int i =0; i<10; i++) 
                if (i % 5 == 0)
                    human[i] = new Human("Max", "Chmurau");
                else if (i % 5 == 1)
                    human[i] = new StudentBSUIR("Pavel","Clybic");
                else if (i % 5 == 2)
                    human[i] = new AIStudent("Berejnov", "Danila");
                else if (i % 5 == 3)
                    human[i] = new IiTPStudent("Igar", "Karpenko");
                else if (i % 5 == 4)
                    human[i] = new ASOIStudent("I", "I");
            foreach(Human i in human)
                i.GetInfo();
            foreach (Human i in human)
                if (i is StudentBSUIR stud)
                    Console.WriteLine(stud.Specialty);
        }
    }
}