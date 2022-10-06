//ConsoleUI
//c#'da field tanımlamalarında public verilirse field ismi PascalCase yazılır

public class Customer
{
    public Customer()
    {
        Console.WriteLine("Müşteri nesnesi başlatıldı");
    }
    public int Id { get; set; }
    public string City { get; set; }
}


