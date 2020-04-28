namespace Pudge
{
    interface IStudent : IHuman
    {
        string SocialStatus { get; set; }
        int AverageMark { get; set; }
        bool IsInArmy { get; set; }
        bool IsKicked { get; set; }
        string University { get; set; }
        int Course { get; set; }
        string Faculty { get; set; }

        void Expel()
        {
            Faculty = University = "none";
            SocialStatus = "Kicked from university";
            IsKicked = true;
            Course = 0;
        }
        void GoToArmy();
    }
}