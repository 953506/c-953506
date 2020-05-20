namespace Pudge
{
    interface IHuman
    {
        string Name { get;}
        string SurName { get;}
        string Gender { get; set; }
        string GetDisease { get;}
        bool IsDead { get; }
        bool IsIll { get; }
        int Age { get; }

        void GetInfo();
        void Die();
        void Resurrect();
        void BecomeIll(string illnessName);
        void ChangeGender()
        {
            Gender = (Gender == "male") ? "female" : "male";
        }
        void Shout()
        {
            System.Console.WriteLine("interface IHuman's shout");
        }
    }
}