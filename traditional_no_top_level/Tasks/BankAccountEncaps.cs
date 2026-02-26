using traditional_no_top_level.Menu;

namespace traditional_no_top_level.Tasks;

public class BankAccountEncaps : ITask
{
    public string Subject => "Encapsulation";
    public string Title => "Bank Account - Encapsulation";
    public string Description => "Practice encapsulation";
    public int Number => 1;

    private decimal _balance = 0m;

    public void Run()
    {
        Console.WriteLine($"{Subject} - {Title} - {Description}");
        
        bool running =  true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine($"Current balance: {_balance:C}");
            Console.WriteLine("1) Deposit");
            Console.WriteLine("2) Withdraw");
            Console.WriteLine("0) Exit");
            Console.Write("Choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Deposit();
                    break;
                case "2":
                    Withdraw();
                    break;
                case "0":
                    running = false;
                    break;
            }
        }
    }

    private void Deposit()
    {
        Console.Write("Amount to deposit: ");
        if (decimal.TryParse(Console.ReadLine(), out var amount) && amount > 0)
            _balance += amount;
    }

    private void Withdraw()
    {
        Console.Write("Amount to withdraw: ");
        if (decimal.TryParse(Console.ReadLine(), out var amount) && amount > 0 && amount <= _balance)
            _balance -= amount;
    }
}