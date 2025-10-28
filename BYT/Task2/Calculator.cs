namespace BYT.Task2;
    
public class Calculator
{
    public double Calculate(double a, double b, char operation)
    {
        switch (operation)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
                if (b == 0)
                    throw new DivideByZeroException("Cannot divide by zero.");
                return a / b;
            default:
                throw new ArgumentException($"Invalid operation: {operation}");
        }
    }
}
