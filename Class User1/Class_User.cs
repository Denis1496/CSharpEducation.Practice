namespace Class_User1;

class Program
{
    void Main(string[] args)
    {
        User user = new User(125, "Denis");
        user.ShowInfo();
    }
}namespace Class_User1;

class Program
{
    void Main(string[] args)
    {
        User user = new User(125, "Denis");
        user.ShowInfo();
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public User(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}");
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public User(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}");
    }
}