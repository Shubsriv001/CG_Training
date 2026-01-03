using System;

class Patient
{
    int PatientId{get;}
    string Name{get;set;}
    int age{get;set;}
    private string medicalhistory;


    public Patient(string Name,int age)
    {
        this.Name=Name;
        this.age=age;
    }


    public void Setmedicalhistory(string medicalhistory)
    {
        this.medicalhistory=medicalhistory;
    }


    public void Getmedicalhistory()
    {
        Console.WriteLine($"Medical History is {medicalhistory}");
    }


}