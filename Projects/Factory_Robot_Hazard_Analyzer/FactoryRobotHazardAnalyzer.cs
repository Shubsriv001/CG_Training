// using System;


// // 1. Create custom exception
// class RobotSafetyException : Exception
// {
//     public RobotSafetyException(string message) : base(message) { }
// }
// class FactoryRobotHazardAnalyzer{


//     public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState){
//         Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
//         armPrecision=Convert.ToDouble(Console.ReadLine());

        
//         Console.WriteLine("Enter Worker Density (1 - 20):");
//         workerDensity=Convert.ToInt32(Console.ReadLine());


//         Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
//         machineryState=Console.ReadLine();

//         try
//         {
            
//         if(armPrecision<0.0 || armPrecision > 1.0)
//         {
//             throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
//         }
        
//         }
//         catch(RobotSafetyException e)
//         {
//             Console.WriteLine(e.Message());
//         }


//         else if(workerDensity<0 || workerDensity > 20)
//         {
//             Console.WriteLine("Error: Worker density must be 1-20");
//         }

//         else if (machineryState!="Worn" || machineryState !="Faulty" || machineryState !="Critical")
//         {
//             Console.WriteLine("Error: Unsupported machinery state:");
            
//         }




//     }
// } 