//ConsoleUI
public class CustomerManager 
{
    private Customer _customer;
    ICreditManager _creditManager;

    public CustomerManager(Customer customer, ICreditManager creditManager)
    {
        _customer = customer;
        _creditManager = creditManager;
    }

    public void Save()
    {
        Console.WriteLine("Kaydedildi :");
    }

    public void GiveCredit()
    {

        _creditManager.Calculate();
        Console.WriteLine("Kredi verildi");
    }
}


