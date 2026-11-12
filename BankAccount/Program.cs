using System.Threading.Tasks.Dataflow;

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount bank = new BankAccount("Mohammad", 10000);
        SavingAccount saving = new SavingAccount("Mohammad", 10000, 0.05m);
        bank.Deposit(100);
        bank.Deposit(0);
        bank.Deposit(-100);
        bank.Withdraw(2000);
        bank.Withdraw(500000);
        bank.Withdraw(bank.GetBalance());
        bank.PrintInfo();

        saving.ApplyInterest();
        saving.PrintInfo();



    }       
    
}



public class BankAccount
{
    public string Name;
    protected decimal balance;
    public BankAccount(string owner, decimal startingBalance)
    {
        Name = owner;
        balance = startingBalance ;
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            System.Console.WriteLine("Invalid amount");
        }
        else
        {
          balance=balance+amount;
          System.Console.WriteLine("New balance is " + balance);  
        }

    }
    public void Withdraw(decimal amount)
    {
        if (amount<= 0)
        {
            System.Console.WriteLine("Invalid Amount");
        }
        else if(amount > balance)
        {
            System.Console.WriteLine("Insufficient Funds");   
        }
        else
        {
            balance = balance-amount;
            System.Console.WriteLine("New balance is " + balance);
        }
        
    } 
    public decimal GetBalance()
    {
        return balance;
    }

    public virtual void PrintInfo()
    {
        System.Console.WriteLine($"Welcome {Name}\nYour balance is {balance}");
    }

}

public class SavingAccount : BankAccount
{
    private decimal Interest;
    public SavingAccount(string owner, decimal startingBalance, decimal rates) : base(owner, startingBalance)
    {
        Interest = rates;
    }
    public void ApplyInterest()
    {
         balance = (balance * Interest) + balance;    
    }
    public override void PrintInfo()
    {
        base.PrintInfo();
        System.Console.WriteLine("Your Interest is: " + Interest);
    }


}