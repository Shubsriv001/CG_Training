using System;
namespace Medical
{
    

class PtientBill
{
    public double GrossAmount;
    public double FinalPayable;
    bool View_Last_Bill=false;
     string BillId;
        string PatientName;
        char HasInsurance;
        double ConsultationFee;
        double LabCharges;
        double MedicineCharges;
        bool BoolInsurance;
        double DiscountAmount;
    
    public void CreateNewBill()
        {
    
        Console.WriteLine("Enter Bill Id: ");
        BillId=(Console.ReadLine());
            if (BillId == "")
            {
                System.Console.WriteLine("Please enter a valid Bill Id.");
                return;
            }
            else
            {
                
        Console.WriteLine("Enter Patient Name:  ");
        PatientName=(Console.ReadLine());
       
            }

        Console.WriteLine("Is the patient insured? (Y/N):  ");
        HasInsurance=Convert.ToChar(Console.ReadLine());

            if (HasInsurance.ToString().ToUpper() == "Y")
            {
                BoolInsurance=true;
            }
            else
            {
                BoolInsurance=false;
            }


        Console.WriteLine("Enter Consultation Fee:  ");
        ConsultationFee=Convert.ToDouble(Console.ReadLine());

        if (ConsultationFee < 0)
        {
            System.Console.WriteLine("Consultation Fee cannot be negative. Please enter a valid amount.");
            return;
        }
        else if (ConsultationFee == 0)
        {
            System.Console.WriteLine("Consultation Fee cannot be zero. Please enter a valid amount.");
            return;
        }


        Console.WriteLine("Enter Lab Charges:   ");
        LabCharges=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Medicine Charges:    ");
        MedicineCharges=Convert.ToDouble(Console.ReadLine());

        if (MedicineCharges < 0 ||LabCharges < 0)
        {
            System.Console.WriteLine("Charges cannot be negative. Please enter valid amounts.");
            return;
        }

        GrossAmount=ConsultationFee+LabCharges+MedicineCharges;
            if (BoolInsurance == true)
            {
             DiscountAmount=GrossAmount*0.10;   
        FinalPayable=GrossAmount-DiscountAmount;
           
            }
            else
            {
                DiscountAmount=0.0;
                FinalPayable=GrossAmount-DiscountAmount;
            }
                View_Last_Bill = true;


            Console.WriteLine($"Gross Amount: {GrossAmount}");
            Console.WriteLine($"Discount Amount: {DiscountAmount}");
            Console.WriteLine($"Final Payable: {FinalPayable}");



        System.Console.WriteLine("Bill created successfully.");



 
        }


        public void ViewLastBill()
        {
            if (View_Last_Bill == true)
            {
                Console.WriteLine($"BillId: {BillId}");
                Console.WriteLine($"Patient:  {PatientName}");
                Console.WriteLine($"Insured:  {HasInsurance}");
                Console.WriteLine($"Consultation Fee:  {ConsultationFee}");
                Console.WriteLine($"Lab Charges:  {LabCharges}");
                Console.WriteLine($"Medicine Charges:  {MedicineCharges}");
                Console.WriteLine($"Gross Amount:   {GrossAmount}");
                Console.WriteLine($"Discount Amount :  {DiscountAmount}");
                Console.WriteLine($"Final Payable:  {FinalPayable}");

            }
            else
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
            }
        }

        public void ClearLastBill()
        {
         GrossAmount=0.0;
    FinalPayable=0.0;
     View_Last_Bill=false;
      BillId="";
        PatientName="";
        HasInsurance='N';
         ConsultationFee=0.0;
         LabCharges=0.0;
        MedicineCharges=0.0;
        BoolInsurance=false;
        DiscountAmount=0.0;

        Console.WriteLine("Last bill cleared.");
        }

}
}