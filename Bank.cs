namespace Interface1;

interface IShowClientCredit { public void ShowClientCredit(string fullname); }
interface IPayCredit { public void PayCredit(string fullname, int money); }
interface IShowAllCredit { public void ShowAllCredit(); }
public class Bank : IShowClientCredit, IPayCredit, IShowAllCredit
{
    public string BankName { get; set; }
    public int Budget { get; set; }
    public List<CEO> cEOs { get; set; }
    public List<Worker> workers { get; set; }
    public List<Manager> managers { get; set; }
    public List<Client> clients { get; set; }
    public List<Credit> credits { get; set; }


    public Bank(string bankName, int budget, List<CEO> cEOs, List<Worker> workers, List<Manager> managers, List<Client> clients, List<Credit> credits)
    {
        BankName = bankName;
        Budget = budget;
        this.cEOs = cEOs;
        this.workers = workers;
        this.managers = managers;
        this.clients = clients;
        this.credits = credits;
    }


    public void ShowClientCredit(string fullname)
    {
        foreach (Client item in clients)
        {
            if (item.Name == fullname)
            {
                Console.WriteLine(item);
            }
            else
            {
                throw new Exception("Bele bir musteri yoxdur!");
            }

        }
    }

    public void PayCredit(string fullname, int money)
    {
        foreach (Client item in clients)
        {

            if (item.Name == fullname)
            {
                foreach (Credit item1 in credits)
                {
                    item1.Amount += money;
                }
            }
            else
            {
                throw new Exception("Bele bir musteri yoxdur!");
            }


        }
    }

    public void ShowAllCredit()
    {
        foreach (Credit item in credits)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
