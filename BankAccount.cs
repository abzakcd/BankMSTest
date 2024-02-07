// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public class BankAccount
{
    private string customer;
    private double balance;
    private int overDraft;
    public static string DepositeAmountNegative = "Deposite amount negative";
    public static string WithdrawAmountNegative = "Withdraw amount negative";
    public static string OverOverdraft = "Overdraft passed";
    public BankAccount(string customer, double balance,int overDraft)
    {
        this.customer = customer;
        this.balance = balance;
        this.overDraft = overDraft;
    }
    public double  Balance
    { 
        get { return balance; } 
    }

    public void Deposit(int amount)
    {
        if (amount < 0)
            throw new Exception(DepositeAmountNegative);

        balance+=amount; // was intentionally wrong -corrected
    }
    public void Withdraw(int amount)
    {
        if(amount <0)
        {
            throw new Exception(WithdrawAmountNegative);
        }
        if(balance - amount < overDraft)
        {
            throw new Exception(OverOverdraft);
        }
        balance -= amount;
    }
}
public class Bank1
{
    static void Main()
    {

    }
}
