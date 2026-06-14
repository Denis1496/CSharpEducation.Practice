namespace Practice5;

class Program
{
    public class Employee
    {
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;

        }

        string Name;
        double Salary;

        public virtual double CalculateBonus(double Salary)
        {
            return Salary * 0.1;
        }
    }

    public class Manager:Employee
    {
            int teamSize;

            public Manager(int teamSize, string name, int salary) : base(name, salary)
            {
                this.teamSize = teamSize;
            }
       public override double CalculateBonus(double Salary)
        {
            if(teamSize > 5)
               return Salary = Salary * 0.2 + Salary * 0.05;
            else
            {
                return Salary * 0.2; 
            }
        }
    }
    public class Contractor:Employee
    {
        public int HourlyRate;

        public Contractor(int HourlyRate, string name, int salary) : base(name, salary)
        {
            this.HourlyRate = HourlyRate;
        }
        
       new public double CalculateBonus(double hoursWorked)  // Сокрытие метода базового класса
       {
           return HourlyRate * hoursWorked;
       }
    }
        
        
    
    static void Main(string[] args)
    {
        Employee salary = new Employee("Denis", 1000);
        Manager manager = new Manager(5,"Vandam",500  );
        Contractor contractor = new Contractor(1000, "Statham", 5000);
        
        Console.WriteLine($"10 % of salary:{salary.CalculateBonus(100)} and 20 % of salary:{manager.CalculateBonus(100)} {contractor.CalculateBonus(100)}");
        
        List<Employee> employees = new List<Employee>()
        {
            new Employee("Denis", 100),
            new Manager(5,"Vandam",500),
            new Contractor(1000, "Statham", 5000)
        };
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.CalculateBonus(100));
        }
    }
}