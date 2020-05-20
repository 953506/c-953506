namespace Pudge
{
    interface IStudent : IHuman
    {
        string SocialStatus { get; set; }
        int AverageMark { get; set; }
        bool IsInArmy { get;}
        bool IsKicked { get;}
        string University { get; set; }
        int Course { get; set; }
        string Faculty { get; set; }

        void GoToArmy();
    }
}