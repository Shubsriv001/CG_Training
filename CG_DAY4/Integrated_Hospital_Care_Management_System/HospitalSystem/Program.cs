using System;
using HospitalSystem.Core;
using HospitalSystem.Services;

class Program
{
    public static void Main()
    {
        Patient patient_obj = new Patient();
        Appointment appointment_obj = new Appointment();
        BillingService billingService_obj = new BillingService();
        DiagnosisService diagnosisservice_obj = new DiagnosisService();
        HospitalStay hospitalStay_obj = new HospitalStay();
        InsuranceService insuranceService_obj = new InsuranceService();

        bool run = true;
        while (run)
        {
            Console.WriteLine("\nWelcome to the Hospital System\n");
            Console.WriteLine("1) Appointment");
            Console.WriteLine("2) Doctors");
            Console.WriteLine("3) Patient");
            Console.WriteLine("4) Billing Service");
            Console.WriteLine("5) Diagnosis Service");
            Console.WriteLine("6) Hospital Stays");
            Console.WriteLine("7) Insurance Service");
            Console.WriteLine("8) Exit");
            Console.Write("Enter Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: 
                    Console.WriteLine("1) Schedule Appointment");
                    Console.WriteLine("2) Back");
                    int appointmentChoice = Convert.ToInt32(Console.ReadLine());

                    switch (appointmentChoice)
                    {
                        case 1:

                        appointment_obj.Schedule_appointment_doctor();
                            Console.Write("Patient Name: ");
                            string patientName = Console.ReadLine();
                            Console.Write("Doctor Name: ");
                            string doctorName = Console.ReadLine();
                            Console.Write("Date & Time in the format dd/mm/yyyy-10:15 AM/PM:");
                            string dateTime = Console.ReadLine();
                            appointment_obj.Schedule_appointment(patientName, doctorName, dateTime);
                            break;

                        case 2:
                            break;
                    }
                    break;

                case 2: 
                    Console.WriteLine("1) Add Doctor");
                    Console.WriteLine("2) View Doctors");
                    Console.WriteLine("3) Back");
                    int doctorChoice = Convert.ToInt32(Console.ReadLine());

                    switch (doctorChoice)
                    {
                        case 1:
                            appointment_obj.add_doctor();
                            break;
                        case 2:
                            appointment_obj.show_doctors();
                            break;
                        case 3:
                            break;
                    }
                    break;

                case 3: 
                    Console.WriteLine("1) Add Patient");
                    Console.WriteLine("2) View Patient");
                    Console.WriteLine("3) View Patient Medical History");
                    Console.WriteLine("4) Back");
                    int patientChoice = Convert.ToInt32(Console.ReadLine());

                    switch (patientChoice)
                    {
                        case 1:
                            patient_obj.Patient_data();
                            break;
                        case 2:
                            patient_obj.get_patient_data();
                            break;
                        case 3:
                            patient_obj.GetMedicalHistory();
                            break;
                        case 4:
                            break;
                    }
                    break;

                case 4:
                    billingService_obj.total();
                    break;

                case 5:
                    diagnosisservice_obj.Evaluate();
                    break;

                case 6:
                    Console.Write("Enter number of days: ");
                    int days = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Total Hospital Stay Count: {hospitalStay_obj.calculate_Hospital_Stay(days)}");
                    break;

                case 7:
                    Console.Write("Bill Amount: ");
                    double bill = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Coverage %: ");
                    double cover = Convert.ToDouble(Console.ReadLine());
                    insuranceService_obj.apply_insurance_Coverage(bill, cover);
                    break;

                case 8:
                    run = false;
                    Console.WriteLine("You Exited From Selection Process Successfully!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}
