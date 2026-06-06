namespace Practice4_Task1
{
    public class MathHelper
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        
        public double Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException(
                    "Division by zero is impossible!"
                );
            }

            return (double)a / b;
        }
    }
}