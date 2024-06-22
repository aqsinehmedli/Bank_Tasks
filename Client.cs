namespace Interface1;

public class Client
{


    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string LiveAdress { get; set; }
    public string WorkAdress { get; set; }
    public int Salary { get; set; }
    public Client(Guid id, string name, string surname, int age, string liveAdress, string workAdress, int salary)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Age = age;
        LiveAdress = liveAdress;
        WorkAdress = workAdress;
        Salary = salary;
    }
    public override string ToString() =>
        $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nAge{Age}\nLiveAdress:{LiveAdress}\nWorkAdress:{WorkAdress}\nSalary:{Salary}";
}
