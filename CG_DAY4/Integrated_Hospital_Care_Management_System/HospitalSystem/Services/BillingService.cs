using System;

namespace HospitalSystem.Services
{
class BillingService
{
    double total_Charge;
    double consultation_Fee;
    double test_charges;
    double room_charges;

    public  void total()
    {
        Console.WriteLine("Please Enter Consultation Fee:");
        consultation_Fee=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please Enter Test Charges:");
        test_charges=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please Enter Room Charges:");
        room_charges=Convert.ToDouble(Console.ReadLine());
        total_Charge=consultation_Fee+test_charges+room_charges;

        Console.WriteLine($"Total Amount to pay: {total_Charge}");
    }



}}