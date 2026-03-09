using System;
using System.Collections.Generic;

// 1. Sealed class
sealed class Security
{
    public void Login()
    {
        Console.WriteLine("Authentication successfully");
    }
}
abstract class InsurancePolicy
{
    public int PolicyNumber { get; init; }
    public string HolderName { get; set; }

    private double premium;
    public double Premium
    {
        get => premium;
        set { if (value > 0) premium = value; }
    }

    public virtual double CalculatePremium()
    {
        return Premium;
    }

    public void ShowPolicy()
    {
        Console.WriteLine("Insurance Policy");
    }
}

class LifeInsurance : InsurancePolicy
{
    public override double CalculatePremium()
    {
        return Premium + 500;
    }

    public new void ShowPolicy()
    {
        Console.WriteLine("Life Insurance Policy");
    }
}

class HealthInsurance : InsurancePolicy
{
    public sealed override double CalculatePremium()
    {
        return Premium + 2000;
    }
}

class PolicyStore
{
    List<InsurancePolicy> list = new List<InsurancePolicy>();

    public void Add(InsurancePolicy p)
    {
        list.Add(p);
    }

    public InsurancePolicy this[int index]
    {
        get { return list[index]; }
    }

    public InsurancePolicy this[string name]
    {
        get { return list.Find(p => p.HolderName == name); }
    }
}

class Program
{
    static void Main()
    {
        Security s = new Security();
        s.Login();

        LifeInsurance life = new LifeInsurance
        {
            HolderName = "Amit",
            PolicyNumber = 102,
            Premium = 5000
        };

        HealthInsurance health = new HealthInsurance
        {
            HolderName = "Neha",
            PolicyNumber = 103,
            Premium = 6000
        };

        PolicyStore store = new PolicyStore();
        store.Add(life);
        store.Add(health);

        Console.WriteLine(store[0].HolderName);
        Console.WriteLine(store["Neha"].PolicyNumber);

        InsurancePolicy p = life;
        Console.WriteLine("Life Premium: " + p.CalculatePremium());
        Console.WriteLine("Health Premium: " + health.CalculatePremium());

        life.ShowPolicy();  
        p.ShowPolicy();      
    }
}
