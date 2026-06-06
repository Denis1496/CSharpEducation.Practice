namespace Practice3_Task2;

    class Student
    {
        private int _point;

        public int point
        {
            get => _point;
            set
            {
                if (value <= 5 && value >= 0)
                {
                    _point = value;
                }
            }
        }
    }

    class Programm
    {
        static void Print_Inform(string name, int age)
        {
            Console.WriteLine($"Name:{name}, Age:{age} years old.");
        }

        static void Main(string[] args)
        {
            Print_Inform("Denis", 29);
            Console.WriteLine("Enter you point");
            int point = Convert.ToInt32(Console.ReadLine());
            Student student = new Student();
            student.point = point;
            Console.WriteLine(student.point);
        }
    }
