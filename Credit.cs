namespace Interface1;

interface ICalculateCredit { public void CalculateCredit(); }
public class Credit:ICalculateCredit
{


    public Guid Id { get; set; }
    public Client client { get; set; }
    public int Amount { get; set; }
    public int Percent { get; set; }
    public DateOnly Months { get; set; }
    public Credit(Guid id, Client client, int amount, int percent, DateOnly months)
    {
        Id = id;
        this.client = client;
        Amount = amount;
        Percent = percent;
        Months = months;
    }

    
    public override string ToString() =>
        $"Id:{Id}\nClient:{client}\nAmount:{Amount}\nPercent:{Percent}\nMonths:{Months}";

    public void CalculateCredit()
    {
        int credit = Amount * Percent;
        Console.Write("Sizin Umumi Kreditiniz:");
        Console.WriteLine(credit);
    }
}
