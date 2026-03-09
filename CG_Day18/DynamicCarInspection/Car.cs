using System;
using System.Reflection;
using System.Linq;

namespace CarInspectionFramework
{
    class Car
    {
        public string Model{get;set;}
        public int ManufacturingYear{get;set;}
        public bool HasValidInsurance{get;set;}
        public bool EngineHealthy{get;set;}
        public bool BrakesHealthy{get;set;}

        public int Age
        {
            get {
                 int time=DateTime.Now.Year - ManufacturingYear; 
                 return time;
                 }
        }
    }
    class ServiceResult
    {
        public bool IsSuccess{get;set;}
        public string Message{get;set;}
    }

    abstract class CarInspectionAttribute:Attribute
    {
        public int Priority{get;}
        protected CarInspectionAttribute(int priority)
        {
            Priority = priority;
        }
    }

    class InspectionInfoAttribute:CarInspectionAttribute
    {
        public string InspectionName{get;}
        public int MinCarAge{get;}

        public InspectionInfoAttribute(string inspectionName, int minCarAge, int priority):base(priority)
        {
            InspectionName = inspectionName;
            MinCarAge = minCarAge;
        }
    }

    class StopOnFailureAttribute:Attribute
    {    
    }

    interface ICarInspection
    {
        ServiceResult Inspect(Car car);
    }


    // [InspectionInfo("Engine Inspection", 3, 1)]
    // [StopOnFailure]
    // class EngineInspection : ICarInspection
    // {
    //     public ServiceResult Inspect(Car car)
    //     {
    //         return car.EngineHealthy
    //             ? new ServiceResult { IsSuccess = true, Message = "Engine inspection passed" }
    //             : new ServiceResult { IsSuccess = false, Message = "Engine inspection failed" };
    //     }
    // }

    // [InspectionInfo("Brake Inspection", 1, 2)]
    // class BrakeInspection : ICarInspection
    // {
    //     public ServiceResult Inspect(Car car)
    //     {
    //         return car.BrakesHealthy
    //             ? new ServiceResult { IsSuccess = true, Message = "Brake inspection passed" }
    //             : new ServiceResult { IsSuccess = false, Message = "Brake inspection failed" };
    //     }
    // }

    // [InspectionInfo("Insurance Inspection", 0, 3)]
    // class InsuranceInspection : ICarInspection
    // {
    //     public ServiceResult Inspect(Car car)
    //     {
    //         return car.HasValidInsurance
    //             ? new ServiceResult { IsSuccess = true, Message = "Insurance inspection passed" }
    //             : new ServiceResult { IsSuccess = false, Message = "Insurance inspection failed" };
    //     }
    // }

    // TASK 8: Reflection-Based Inspection Engine
    class InspectionEngine
    {
        public void Run(Car car)
        {
            var inspections =
            Assembly.GetExecutingAssembly().GetTypes().Where(t => typeof(ICarInspection).IsAssignableFrom(t) && !t.IsInterface).Select(t => new
                {
                    Type = t,
                    Info = t.GetCustomAttribute<InspectionInfoAttribute>(),
                    Stop = t.GetCustomAttribute<StopOnFailureAttribute>() != null
                }).Where(x => x.Info != null && car.Age >= x.Info.MinCarAge).OrderBy(x => x.Info.Priority);

            foreach (var item in inspections)
            {
                var inspection = (ICarInspection)Activator.CreateInstance(item.Type);
                var result = inspection.Inspect(car);

                Console.WriteLine(result.Message);

                if (!result.IsSuccess && item.Stop)
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Model = "BMW X5",
                ManufacturingYear = 2019,
                EngineHealthy = true,
                BrakesHealthy = true,
                HasValidInsurance = false
            };

            InspectionEngine engine = new InspectionEngine();
            engine.Run(car);
        }
    }
}
