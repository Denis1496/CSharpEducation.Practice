namespace Practice2.Task7;

class Program
{
    static void Main(string[] args)
    {
        double metr;
        double km;
        double m_c;
        int c;
        
        for (int i = 0; i < 1; i++)
        {
            Console.Write("Введи метры:" + " ");
            metr = Convert.ToInt32(Console.ReadLine());
            km = metr / 1000;
            Console.WriteLine("Зачение в километрах:" + " " + km + " " + "км");
        }
        for (int i = 0; i < 1; i++)
        {
            Console.Write("Введи километры:" + " ");
            km = Convert.ToInt32(Console.ReadLine());
            double c_m = km * 100000;
            Console.WriteLine("Зачение в сантиметрах:" + " " + c_m + " " + "см");
        }
        for (int i = 0; i < 1; i++)
        {
            Console.Write("Введи м/с:" + " ");
            m_c = Convert.ToInt32(Console.ReadLine());
            double km_x = m_c * 3.6;
            Console.WriteLine("Зачение в км/ч:" + " " + km_x + " " + "км/ч");
        }
        for (int i = 0; i < 1; i++)
        {
            Console.Write("Введи градусы цельсия:" + " ");
            c = Convert.ToInt32(Console.ReadLine());
            double f = c * 33.8;
            Console.WriteLine("Зачение в градусах по фаренгету:" + " " + f + " " + "F");
        }
    }
}