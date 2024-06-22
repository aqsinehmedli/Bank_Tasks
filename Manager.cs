namespace Interface1;

interface ICalculateSlaries { public void  Calculate(); }
public class Manager:CEO,IOrganize,ICalculateSlaries
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public int Salary { get; set; }
    public Manager(Guid id, string name, string surname, int age, string position, int salary)
        :base(id,name,surname,age,position,salary)
    {
       
    }
    public override string ToString() =>
        $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nPosition:{Position}\nSalary:{Salary}";

    public void Calculate()
    {
        Console.WriteLine("Calculate Salaries");
    }
}
