using System;

// ==================================1. Message===========================================================

// What: Error description.

// Example:

// try { int x = 10 / 0; }
// catch (Exception ex) { Console.WriteLine(ex.Message); }


// Output:

// Attempted to divide by zero.


// ==================================2. StackTrace// ==================================

// What: Method call sequence where error occurred.

// Example:

// try { int x = 10 / 0; }
// catch (Exception ex) { Console.WriteLine(ex.StackTrace); }


// Output (sample):

// at Program.Main(String[] args)

// ==================================3. Source// ==================================

// What: Application/object that caused the error.

// Example:

// try { int x = 10 / 0; }
// catch (Exception ex) { Console.WriteLine(ex.Source); }


// Output (sample):

// ConsoleApp1

// ==================================4. InnerException// ==================================

// What: Original exception wrapped inside another.

// Example:

// try
// {
//     try { int x = 10 / 0; }
//     catch (Exception e) { throw new Exception("Outer error", e); }
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
//     Console.WriteLine(ex.InnerException.Message);
// }


// Output:

// Outer error
// Attempted to divide by zero.

// ==========================//===========================//===============================//=======================


    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message):base(message)
        { }
    } 

    class BankAccount
    {
        public decimal Balance { get; private set; } = 5000;

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new InsufficientBalanceException("Withdrawal amount must be greater than zero");

            if (amount > Balance)
                throw new InsufficientMemoryException("Insufficient balance for withdrawal");
            Balance -=amount;
        }
    }

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            //User input validation
            Console.WriteLine("Enter Wthdrawal amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            //Arithmatic Operation

            int serviceCharge = 100;
            int devisionCheck = serviceCharge; // /int.Parse("0"); //Intentional Error

            //Access File

            string data = File.ReadAllText("account.txt");
            if (data == "")
            {
                Console.WriteLine("No Text Present");
            }
            else
            {
            Console.WriteLine(data);
            }
                

            //Bussiness Logic
            BankAccount account = new BankAccount();
            account.Withdraw(amount);
            Console.WriteLine("Withdrawal Successful.");
        }

        catch (FormatException ex)
        {
            LogException(ex);
            Console.WriteLine("Invalid input format.");
        }

        catch (DivideByZeroException ex)
        {
            LogException(ex);
            Console.WriteLine("Arithmatic Error Occur.");
        }
        catch (FileNotFoundException ex)
        {
            LogException(ex);
            Console.WriteLine("Required file not found");
        }
        catch (InsufficientBalanceException ex)
        {
            LogException(ex);
            Console.WriteLine(ex.Message);
        }

        catch (Exception ex)
        {
            LogException(ex);
            Console.WriteLine("An unexpected Error Occured");
        }
        finally
        {
            Console.WriteLine("Transaction Attented Complete");
        }
    }

    static void LogException(Exception ex)
    {
        File.AppendAllText(
            "error.log",
            DateTime.Now + " | " + ex.GetType().Name + " | " + ex.Message + Environment.NewLine
            );
    } }







