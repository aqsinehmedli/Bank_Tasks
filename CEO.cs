namespace Interface1;

interface IControl { public void Control(); }
interface IOrganize { public void Organize(); }
interface IMakeMeeting { public void MakeMeeting(); }
interface IDecreasePercentAge { public void DecreasePercentAge(); }
public class CEO : IControl, IOrganize, IMakeMeeting, IDecreasePercentAge
{

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public int Salary { get; set; }
    public CEO(Guid id, string name, string surname, int age, string position, int salary)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;
    }

    public void Control()
    {
        Console.WriteLine("Control");
    }

    public void Organize()
    {
        Console.WriteLine("Organize");
    }

    public void MakeMeeting()
    {
        Console.WriteLine("MakeMeeting");
    }

    public void DecreasePercentAge()
    {
        Console.WriteLine("DecrentPercentAge");
    }
    public override string ToString() =>
        $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nPosition:{Position}\nSalary:{Salary}";
}
