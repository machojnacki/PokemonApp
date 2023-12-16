namespace ChallangeApp5;

public class Employee
{
    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
    public string Name { get; set; }

    public string Surname { get; set; }

    public int Age { get; set; }

    private List<int> points = new List<int>();

    public void AddPoints(int score)
    {
        this.points.Add(score);
    }

    public int Result
    {
        get
        {
            return this.points.Sum();
        }
    }
}

