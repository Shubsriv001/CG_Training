using System;

namespace HospitalSystem.Services
{
    class DiagnosisService
    {
        int age;
        string condition="";
        string riskLevel="";
        int[] testScore=new int[0];

        public void Evaluate()
        {
            Console.WriteLine("Please enter Your age:");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter how many Medical test Score You want to add: ");
            int number_test_score = Convert.ToInt32(Console.ReadLine());
            testScore = new int[number_test_score];

            for (int i = 0; i < number_test_score; i++)
            {
                Console.WriteLine($"Enter test score {i + 1}: ");
                testScore[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach (int i in testScore)
            {
                sum += i;
            }

            void IsCritical()
            {
                if (sum > 250 && age > 60)
                {
                    condition = "Serious";
                    riskLevel = "High";

                    Console.WriteLine();
                    Console.WriteLine("---------------------Result------------------------");
                    Console.WriteLine($"Patient Condition is: {condition}\nPatient Risk Level {riskLevel}");
                    Console.WriteLine();
                }
                else
                {
                    condition = "Stable";
                    riskLevel = "Moderate";
                     Console.WriteLine();
                    Console.WriteLine("--------------------OverAll Result------------------------");
                    Console.WriteLine($"Patient Condition is: {condition} and Risk Level {riskLevel}");
                     Console.WriteLine();
                }
            }

            IsCritical();
        }
    }
}
