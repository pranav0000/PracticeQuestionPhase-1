/* Scenario: Restrict deposit and withdraw from bank account
Create BankAccount with following members
Data members:    cname, accountBalance: private
Methods:    Constructor(),Deposit() and Withdraw()
Implement following in constructor
    Set accountBalance to 500rs when opening account on friday
    Set accountBalance to 0rs when opening account on other days
Implement Deposit method with following (amount as an argument)
    Restrict deposit out of office hours ( 9am to 5pm)
    Restrict deposit on sunday
    Restrict deposit more than 50k
    int hour = DateTime.Now.Hour;
if (hour >= 9 && hour <= 16)    //office hours
Note: Display attempt and status for every transcation with current date and time
Implement Withdraw method with following(amount as an argument)
    Restrict on sunday and outof working hours
    Restrict when funds are nil
    Restrict when funds are less than requested amount
Note:    Display attempt and status for every transcation with current date and time
*/

using System;
using System.Collections;

class Today
{
    public static bool IsSunday()
    {
        return DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower() == "sun";
    }
    public static bool IsFriday()
    {
        return DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower() == "fri";
    }
    public static bool IsOfficeHours()
    {
        int hour = DateTime.Now.Hour;
        return (hour >= 9 && hour <= 17);
    }
}
class assignment_bank
{
    private int accountBalance;
    private string cname;
    public assignment_bank(string cname = "Not Provided", int amount = 0)
    {
        this.cname = cname;
        if (Today.IsFriday())
        {
            this.accountBalance = 500;
            Console.WriteLine($"Congratulations {this.cname} account opened sucessfully, you got 500rs welcome bonus");
        }
        else
        {
            this.accountBalance = 0;
            Console.WriteLine($"Congrtulations {this.cname}, account opened successfully...");
        }
        this.accountBalance += amount;
        Console.WriteLine("=========================================================");
        //Thread.Sleep(3000);
    }
    public void Deposit(int amount)
    {
        Console.WriteLine($"Attempt by {this.cname}: Deposit request for {amount} at {DateTime.Now}");
        if (Today.IsSunday())
            {
            Console.WriteLine($"Status: Deposit request failed as You cannot deposit on sunday");
        }
            else if (!Today.IsOfficeHours())
        {
            Console.WriteLine($"Status: Deposit request failed as You cannot deposit out of office hours");
        }
        else if (amount > 50000)
        {
            Console.WriteLine($"Status: Deposit failed, You cannot deposit  50k above, pls check with manager");
        }
        else
        {
            this.accountBalance += amount;
            Console.WriteLine($"Status: Deposited {amount} successfully...");
        }
        Console.WriteLine("=======================================================");
        //Thread.Sleep(3000);
    }
    public void GetDetails()
    {
        Console.WriteLine($"Name: {this.cname}, Account balance: {this.accountBalance}");
    }
}


    class bank_transaction
{
    static void Main(string[] args)
    {
        assignment_bank c1 = new assignment_bank("Kiran", 5000);
        assignment_bank c2 = new assignment_bank();
        c1.Deposit(55000);
        c2.Deposit(12500);
    }
}