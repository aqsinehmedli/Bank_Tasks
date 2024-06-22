
using Interface1;

CEO ceos1 = new CEO(Guid.NewGuid(), "Aqsin", "Ehmedli", 20, "Development", 1500);
CEO ceos2 = new CEO(Guid.NewGuid(), "Nihad", "Amirov", 20, "Management", 2500);

Operations operations1 = new Operations(Guid.NewGuid(), "Kredit", new DateTime(2018, 12, 23));
Operations operations2 = new Operations(Guid.NewGuid(), "Kassa", new DateTime(2020, 12, 23));

Worker workers1 = new Worker(Guid.NewGuid(), "Revan", "Agazade", 21, "Developer", 2000, new DateOnly(2014, 01, 02), new DateOnly(2024, 02, 02), operations1);
Worker workers2 = new Worker(Guid.NewGuid(), "Nihad", "Agazade", 21, "Guard", 700, new DateOnly(2015, 01, 02), new DateOnly(2024, 03, 02), operations2);

Manager managers1 = new Manager(Guid.NewGuid(), "Nazim", "Nazimli", 34, "Senior Program Manager", 3200);
Manager managers2 = new Manager(Guid.NewGuid(), "Famil", "Familli", 44, "Business Manager", 4200);

Client client1 = new Client(Guid.NewGuid(), "Asif", "Memmedli", 23, "Sumqayit", "Baki", 2300);
Client client2 = new Client(Guid.NewGuid(), "Necef", "Necefli", 26, "Xirdalan", "Sumqayit", 2300);

Credit credit1 = new Credit(Guid.NewGuid(), client1, 2000, 30, new DateOnly(2024, 11, 25));
Credit credit2 = new Credit(Guid.NewGuid(), client2, 3000, 25, new DateOnly(2024, 01, 25));

Bank bank = new Bank("My Bank", 25000, new List<CEO> { ceos1, ceos2 }, new List<Worker> { workers1, workers2 }, new List<Manager> { managers1, managers2 }, new List<Client> { client1, client2 }, new List<Credit> { credit1, credit2 });
//bank.PayCredit("Necef", 200);
//bank.ShowAllCredit();
try
{
    bank.ShowAllCredit();
    bank.ShowClientCredit("Memmed");
    bank.PayCredit("Mamed", 2323);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}