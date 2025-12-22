using System;
using System.Security.Cryptography.X509Certificates;

namespace HospitalSystem.Core
{
    
class Patient
{
    private string patientName;
    private int patientAge;
    private int patientId;
    private string patientMedicalHistory;
    private string[]arr_patient_name;
    private int[]arr_patient_age;
    private int[]arr_patient_id;
    private string[]arr_patient_medical_history;
    private int patient_number_add;


    public void Patient_data()
    {Console.WriteLine();
            Console.WriteLine("----------------------------Enter Patient Data-----------------------");
            Console.WriteLine();
        Console.WriteLine("How many Patient You Want to Add:");
        patient_number_add=Convert.ToInt32(Console.ReadLine());

        arr_patient_name=new string[patient_number_add];
        arr_patient_age=new int[patient_number_add];
        arr_patient_id=new int[patient_number_add];
        arr_patient_medical_history=new string[patient_number_add];

        for(int i = 0; i < patient_number_add; i++)
            {
        Console.WriteLine($"Please Enter {i+1} Patient Name:");
        patientName = Console.ReadLine();

                if (patientName != "")
                {
                    arr_patient_name[i]=patientName;
                }
                else{
                    Console.WriteLine("Please Enter Valid Name.");
                    return;
                }


        Console.WriteLine($"Please Enter {i+1} Patient Age:");
        patientAge = Convert.ToInt32(Console.ReadLine());

         if (patientAge >0 )
                {
                    arr_patient_age[i]=patientAge;
                }
                else{
                    Console.WriteLine("Please Enter Valid age.");
                    return;
                }


        Console.WriteLine($"Please Enter {i+1} Patient ID:");
        patientId = Convert.ToInt32(Console.ReadLine());

         if (patientId >0 )
                {
                    arr_patient_id[i]=patientId;
                }
                else{
                    Console.WriteLine("Please Enter Valid Id.");
                    return;
                }


        Console.WriteLine("Please Enter the patient medical history:");
        patientMedicalHistory = Console.ReadLine();
            if (patientMedicalHistory!="")
            {
                    arr_patient_medical_history[i]=patientMedicalHistory;
            }
                else
                {
                    Console.WriteLine("Please your medical history:");
                return;
                }
                
        
            }

    }

    public void GetMedicalHistory()
    {
             Console.WriteLine();
            Console.WriteLine("----------------------------Patient Medical History-----------------------");
            Console.WriteLine();
        for(int i = 0; i < patient_number_add; i++)
            {
        Console.WriteLine($"Patient Medical History: {arr_patient_medical_history[i]}");
                
            }
            Console.WriteLine();
    }

     public void get_patient_data()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------Patient Present in Hospital-----------------------");
            Console.WriteLine();
            Console.WriteLine($"Total Number of Patient Present in the Hospital is: {patient_number_add}");

            for(int i = 0; i < patient_number_add; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"-------Patient {i+1}-------");
                Console.WriteLine($"Id: {arr_patient_id[i]}\nName: {arr_patient_name[i]}\nAge: {arr_patient_age[i]}\nMedical History: {arr_patient_medical_history[i]}");
                Console.WriteLine();
            }
        } 


}

}