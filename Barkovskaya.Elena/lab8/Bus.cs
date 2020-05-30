using System;
using System.Collections.Generic;
using System.Text;

namespace labr8
{
    class Bus : MarkCar, ICarInfo
    {
        string[] jobs = new string[] { "Funeral", "Organisation Bus", "School bus", "City bus"};
        public delegate void JobInformer(string message);
        public event JobInformer Notify;
        public string job;
        public int MaxSpeed { get; set; }
        public int MinSpeed { get; set; }
        public int FuelConsumption { get; set; }

        public Bus(string mark, string model, string color, string chassis_type, int country_choice, int max, int min, int fuel) : base(mark, model, color, chassis_type, country_choice)
        {
            MaxSpeed = max;
            try{
                MinSpeed = min;
                if (MinSpeed < 0)
                    throw new Exception("Inpossible variant. Minimal speed less than 0");
            }catch (Exception e){
                Console.WriteLine(e);
            }
            finally
            {
                MinSpeed = 1;
            }
            
            try{
                FuelConsumption = fuel;
                if (FuelConsumption < 0)
                    throw new Exception("Inpossible variant. Fuel Compusition less than 0");
            }catch (Exception e){
                Console.WriteLine(e);
            }
        }
        public void TakeJob(uint choice)
        {
            if (choice == 0)
                Notify?.Invoke("Without job");

            else
            {
                job = jobs[choice - 1];
                Notify?.Invoke($"You job is: {jobs[choice - 1]}");
            }
        }
        public void RemoveJob() 
        {
            Notify?.Invoke($"Now you remove your {job} job");
            job = null;
        }
        public void GetRandomJob() 
        {
            Notify?.Invoke("Now you get eandom JOB. Say \"JESUS Christ\" to up you chance to be Jesus Helper (Funeral type)");
            Random random = new Random();
            TakeJob((uint)random.Next(1, 4));
        }
    }
}
