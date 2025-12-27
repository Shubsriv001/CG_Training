using System;
using System.Runtime.ConstrainedExecution;
class QuickMartTraders{



string InvoiceNo;
string CustomerName;
string ItemName;
int Quantity;
double PurchaseAmount_total;
double SellingAmount_total;

string ProfitOrLossStatus;

double  ProfitOrLossAmount;

double ProfitMarginPercent;

bool last_transac=false;


public void CreateNewTransaction()
    {
        Console.WriteLine();
Console.WriteLine("Enter Invoice No: ");
string iV_N=Console.ReadLine();
        if (InvoiceNo == "")
        {
            System.Console.WriteLine("Please Enter the valid Invoice Number:");
            return;
        }
        else
        {
            InvoiceNo=iV_N;
        }
Console.WriteLine("Enter Customer Name: ");
string name=Console.ReadLine();
        if (name == "")
        {
            System.Console.WriteLine("Please Enter the valid name:");
            return;
        }
        else
        {
            CustomerName=name;
        }

Console.WriteLine("Enter Item Name: ");
string i_name=Console.ReadLine();
        if (i_name == "")
        {
            System.Console.WriteLine("Please Enter the Valid Item Name:");
            return;
        }
        else
        {
ItemName=i_name;
            
        }

Console.WriteLine("Enter Quantity: ");
int qun=Convert.ToInt32(Console.ReadLine());
        if (qun < 0)
        {
            System.Console.WriteLine("Please Enter the Quantity Greater than 0");
            return;
        }
        else
        {
            Quantity=qun;
        }
Console.WriteLine("Enter Purchase Amount (total): ");
double P_a=Convert.ToDouble(Console.ReadLine());
        if (P_a < 0)
        {
            System.Console.WriteLine("Please Enter the Purchase Amount greater than 0");
            return;
        }
        else
        {
            PurchaseAmount_total=P_a;
        }

Console.WriteLine("Enter Selling Amount (total):");
double S_a=Convert.ToDouble(Console.ReadLine());
        if (S_a >= 0)
        {
            SellingAmount_total=S_a;
        }
        else
        {
            System.Console.WriteLine("Please Enter the Selling Amount greater than 0");
        }


ProfitMarginPercent=(ProfitOrLossAmount/PurchaseAmount_total)*100;

        if(PurchaseAmount_total< SellingAmount_total)
        {
            ProfitOrLossStatus="PROFIT";
            ProfitOrLossAmount=SellingAmount_total-PurchaseAmount_total;
        }
        else if (PurchaseAmount_total>SellingAmount_total)
        {
            ProfitOrLossStatus="LOSS";
            ProfitOrLossAmount=PurchaseAmount_total-SellingAmount_total;
        }
        else if(PurchaseAmount_total==SellingAmount_total){
            ProfitOrLossStatus="BREAK-EVEN";
            ProfitOrLossAmount=0;
            
        }
        last_transac=true;

        Console.WriteLine("Transaction saved successfully");
        Console.WriteLine($"Status: {ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount}");
        Console.WriteLine($"Profit Margin (%):  {ProfitMarginPercent}");
        Console.WriteLine();

        

    }


    public void ViewLastTransaction()
    {
        Console.WriteLine();
        Console.WriteLine("-------------- Last Transaction --------------");
        Console.WriteLine();

            
        if (last_transac == false)
        {
        Console.WriteLine("No transaction available. Please create a new transaction first.");
        Console.WriteLine();

        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"InvoiceNo: {InvoiceNo}");
            Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Item: {ItemName}");
            Console.WriteLine($"Quantity:  {Quantity}");
            Console.WriteLine($"Purchase Amount:  {PurchaseAmount_total}");
            Console.WriteLine($"Selling Amount: {SellingAmount_total}");
            Console.WriteLine($"Status: {ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount}");
            Console.WriteLine($"Profit Margin (%):  {ProfitMarginPercent}");
            Console.WriteLine();
        }
        
    }

    public void CalculateProfit_Loss()
    {
        Console.WriteLine();
        if (last_transac = true)
        {
           Console.WriteLine($"Status: {ProfitOrLossStatus}");
           Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            Console.WriteLine();
        }
        
    }
}