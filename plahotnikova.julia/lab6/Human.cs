using System;

namespace Lab3
{
    class Human : Personality, IHuman, IEquatable<Human>
    {
        protected int criminalRecord;
        protected string familyCondition;
        protected int familySize;

        public Human(string firstname, string lastname, DateTime birthdate, Sex sex, int height, int weight, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthdate = birthdate;
            this.sex = sex;
            this.height = height;
            this.weight = weight;
            this.age = age;
        }

        public override void CriminalRecord()
        {
            Console.WriteLine("Enter the number of your convictions: ");

            criminalRecord = Convert.ToInt32(Console.ReadLine());

            if (criminalRecord == 0)
            {
                Console.WriteLine($"{firstname} {lastname} has {criminalRecord} convictions, it will be easy to find a job!");
            }
            else if (criminalRecord == 1)
            {
                Console.WriteLine($"{firstname} {lastname} has {criminalRecord} conviction, it won't be easy to find a job!");
            }
            else
            {
                Console.WriteLine($"{firstname} {lastname} has {criminalRecord} convictions, it is almost impossible to find a job!");
            }
        }

        enum FamilySize
        {
            Little = 1,
            Medium = 2,
            Large = 3
        }

        public override void FamilyCondition()
        {
            Console.WriteLine("Enter the number of children in your family: ");
            familySize = int.Parse(Console.ReadLine());

            if (familySize <= (int)FamilySize.Little)
            {
                familyCondition = "Little family with 1 or less children.";
            }
            else if (familySize == (int)FamilySize.Medium)
            {
                familyCondition = "Middle family with 2 children.";
            }
            else
            {
                familyCondition = "Large family with 3 or more children.";
            }

        }

        public int GetFullYears()
        {
            var zeroTime = new DateTime(1, 1, 1);
            var difference = DateTime.Now - birthdate;
            age = (zeroTime + difference).Year - 1;

            return age;
        }

        public double GetBodyMassIndex()
        {
            var bmi = weight / Math.Pow(height / 100D, 2);

            return bmi;
        }

        public virtual void InstitutionType() { }
        
        public bool Equals(Human other)
        {
            return this.firstname == other.firstname
                && this.lastname == other.lastname
                && this.birthdate == other.birthdate
                && this.sex == other.sex
                && this.height == other.height
                && this.weight == other.weight;
        }
    }
}



