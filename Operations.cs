namespace Interface1;

public class Operations
{

    public Guid Id { get; set; }
    public string ProcessName { get; set; }
    public DateTime DateTimes { get; set; }
    public Operations(Guid id, string processName, DateTime dateTimes)
    {
        Id = id;
        ProcessName = processName;
        DateTimes = dateTimes;
    }
    public override string ToString() =>
        $"Id:{Id}\nProcessName:{ProcessName}\nDateTime:{DateTimes}";

}
