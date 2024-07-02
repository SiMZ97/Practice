namespace Practice;

public struct WorkTask
{
    public string description;
    public int hours;

    public void PerformWorkTask()
    {
        Console.WriteLine($"Task {description} of {hours} hours has been completed!"); 
    }
}

