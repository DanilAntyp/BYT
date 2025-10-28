namespace BYT.Task2;

public class Program
{
   public static void Main(String[] args)
   {
      Calculator calculator = new Calculator();
      double resPlus = calculator.Calculate(10, 5, '+');
      double resMinus =calculator.Calculate(10,5,'-');
      double resMultiply =calculator.Calculate(10,5,'*');
      double resDivide =calculator.Calculate(10,5,'/');
      
      Console.WriteLine(resPlus);
      Console.WriteLine(resMinus);
      Console.WriteLine(resMultiply);
      Console.WriteLine(resDivide);
   }
}