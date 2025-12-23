using System;

namespace HospitalSystem.Core
{
    class Doctor
    {
        protected int number_doctor;
        protected string[] arr_doc_name;
        protected string[] arr_doc_specialization;
        protected int[] arr_doc_license_number;
        protected string[] arr_doc_present_in_hospital;

        public void add_doctor()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------- Add Doctors ---------------------------");
            Console.WriteLine();

            Console.WriteLine("How Many Doctors You Want to add:");
            number_doctor = Convert.ToInt32(Console.ReadLine());

            arr_doc_name = new string[number_doctor];
            arr_doc_specialization = new string[number_doctor];
            arr_doc_license_number = new int[number_doctor];
            arr_doc_present_in_hospital = new string[number_doctor]; 

            for (int i = 0; i < number_doctor; i++)
            {
                Console.WriteLine($"Please Enter {i+1} Doctor name:");
                string doctor_Name = Console.ReadLine();

                if (doctor_Name == "")
                {
                    Console.WriteLine($"Please Enter valid Doctor Name");
                    doctor_Name = Console.ReadLine();
                }
                arr_doc_name[i] = doctor_Name;

                Console.WriteLine($"Please Enter {i+1} Doctor Specialization:");
                string doctor_Specialization = Console.ReadLine();

                if (doctor_Specialization == "")
                {
                    Console.WriteLine("Please Enter valid Doctor Specialization");
                    doctor_Specialization = Console.ReadLine();
                }
                arr_doc_specialization[i] = doctor_Specialization;

                Console.WriteLine($"Please Enter {i+1} Doctor License Number:");
                int doctor_license_Number = Convert.ToInt32(Console.ReadLine());

                if (doctor_license_Number <= 0)
                {
                    Console.WriteLine("Please Enter Valid License Number");
                    doctor_license_Number = Convert.ToInt32(Console.ReadLine());
                }
                arr_doc_license_number[i] = doctor_license_Number;

                Console.WriteLine($"Please Enter {i+1} Doctor Present Status (Day/Night):");
                string doctor_present_in_hospital = Console.ReadLine();

                if (doctor_present_in_hospital == "")
                {
                    Console.WriteLine("Please Enter Valid Status (Day/Night)");
                    doctor_present_in_hospital = Console.ReadLine();
                }
                arr_doc_present_in_hospital[i] = doctor_present_in_hospital;
            }
        }

        public void show_doctors()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------- Doctors List ---------------------------");
            if (arr_doc_name == null || arr_doc_name.Length == 0)
            {
                Console.WriteLine("Regret, there are no doctors present in the hospital Please Add Doctor.");  
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Total Number of Doctors Present in the Hospital: {number_doctor}");
                Console.WriteLine();
                for (int i = 0; i < number_doctor; i++)
                {
                    Console.WriteLine($"-------Doctor {i+1}-------");
                    Console.WriteLine($"Name: {arr_doc_name[i]}\nSpecialization: {arr_doc_specialization[i]}\nLicense Number: {arr_doc_license_number[i]}\nDoctor Present Status: {arr_doc_present_in_hospital[i]}\n");
                }
            }
        }
    }
}
