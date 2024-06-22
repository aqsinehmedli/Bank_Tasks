namespace Interface1;

interface IOperations { public void addOperations(); }
public class Worker : IOperations
{


    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public int Salary { get; set; }
    public DateOnly StartTime { get; set; }
    public DateOnly EndTime { get; set; }
    public Operations Operations { get; set; }
        public Worker(Guid id, string name, string surname, int age, string position, int salary, DateOnly startTime, DateOnly endTime, Operations operations)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;
        StartTime = startTime;
        EndTime = endTime;
        Operations = operations;
    }
  
    public void addOperations()
    {
        Console.WriteLine("Add Operations");
    }
    public override string ToString() =>
    $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nPosition:{Position}\nSalary:{Salary}\nStartTime:{StartTime}\nEndTime:{EndTime}\nOperations:{Operations}";
}

