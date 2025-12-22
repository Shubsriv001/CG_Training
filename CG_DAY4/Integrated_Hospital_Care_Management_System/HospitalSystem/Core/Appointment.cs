using System;
using System.Diagnostics;

namespace HospitalSystem.Core
{
    class Appointment : Doctor
    {
        public void Schedule_appointment(string patient_Name, string doctor_name)
        {
            Console.WriteLine("Below is the list of Doctors Present in the Hospital:");
            show_doctors();  
            
            Console.WriteLine($"Your appointment is scheduled tomorrow. Patient Name: {patient_Name} and Doctor Name: {doctor_name}");
        }

        public void Schedule_appointment(string patient_Name, string doctor_name, string date_Time)
        {
            Console.WriteLine("----------------------------Appointment Booked-------------------------");
            Console.WriteLine();
            Console.WriteLine($"Your appointment is scheduled tomorrow. Patient Name: {patient_Name}, Doctor Name: {doctor_name}, Date & Time: {date_Time}");
            Console.WriteLine();
        }
    }
}
