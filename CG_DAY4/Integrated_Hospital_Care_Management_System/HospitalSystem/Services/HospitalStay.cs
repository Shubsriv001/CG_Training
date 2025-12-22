using System;

namespace HospitalSystem.Services
{
class HospitalStay
{
    public int calculate_Hospital_Stay(int days)
    {
        if (days == 0)
        {
            return 0;
        }
        else
        {
            return days + calculate_Hospital_Stay(days-1);
        }
    }
}}