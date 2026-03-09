using System;

public delegate string ReportGenerator(string patientName);
public delegate void HospitalAlert(string message);
public delegate void HospitalNotificationHandler(string message, DateTime time);

class HospitalNotifier
{
    public event HospitalNotificationHandler PatientAdmitted;

    public void AdmitPatient(string name)
    {
        PatientAdmitted?.Invoke($"Patient {name} admitted successfully.", DateTime.Now);
    }
}

class AdministrationDepartment
{
    public void Notify(string message, DateTime time)
    {
        Console.WriteLine($"[ADMIN] {message} | {time}");
    }
}

class Program
{
    public static string GenerateDischargeSummary(string patientName)
    {
        return $"Discharge summary generated for patient: {patientName}";
    }

    public static void SendSmsAlert(string message)
    {
        Console.WriteLine($"SMS Alert: {message}");
    }

    public static void SendEmailAlert(string message)
    {
        Console.WriteLine($"Email Alert: {message}");
    }

    public static void SendDashboardAlert(string message)
    {
        Console.WriteLine($"Dashboard Alert: {message}");
    }

    static void Main(string[] args)
    {
        ReportGenerator report = GenerateDischargeSummary;
        Console.WriteLine(report("Rahul"));

        HospitalAlert alert = SendSmsAlert;
        alert += SendEmailAlert;
        alert += SendDashboardAlert;
        alert("Emergency patient detected!");

        HospitalNotifier notifier = new HospitalNotifier();
        AdministrationDepartment admin = new AdministrationDepartment();
        notifier.PatientAdmitted += admin.Notify;
        notifier.AdmitPatient("Meera");

        Func<double, double, double> calculateBill = (consultation, tests) => consultation + tests;
        Console.WriteLine($"Total Bill Amount: {calculateBill(600, 1800)}");

        Action<string> logAction = message => Console.WriteLine($"[LOG] {message}");
        logAction("Billing process completed");

        Predicate<int> isSeniorCitizen = age => age >= 60;
        Console.WriteLine($"Is Senior Citizen: {isSeniorCitizen(65)}");
    }
}
