using System;
namespace HospitalSystem.Services
{
class InsuranceService
{

    double total_bill_amount_after_insurnce_cover;
    public void apply_insurance_Coverage(double billAmount, double coveragePercent)
    {
       Console.WriteLine();
        total_bill_amount_after_insurnce_cover=billAmount-(billAmount*coveragePercent/100);
        Console.WriteLine($"Bill to pay after Insurance Coverage of {coveragePercent}% is : {total_bill_amount_after_insurnce_cover}");
    }
}}