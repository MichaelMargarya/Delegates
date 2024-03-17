using PostfixAlgorithm;
using static System.Console;
namespace PostifixAlgoritm;


internal class Program
{
    static void Main(string[] args)
    {
       WriteLine("Enter PotFix:");
        string expression = ReadLine();

        try
        {
            double result = PostStack.Calculate(expression);
            WriteLine("Result: " + result);
        }
        catch (Exception ex)
        {
            WriteLine("Error: " + ex.Message);
        }
    }

}
