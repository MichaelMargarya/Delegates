using System;
using System.Collections.Generic;

namespace PostfixAlgorithm;

internal class PostStack
{
    public static bool Valid(string input)
    {
        if (input != null)
        {
            bool number = double.TryParse(input[0].ToString(), out _);
            return number;
        }
        else
        {
            return false;
        }
    }

    public static double Calculate(string input)
    {
        Stack<double> stack = new Stack<double>();
        if (Valid(input))
        {
            string[] question = input.Split(' ');
            foreach (string operat in question)
            {
                if (double.TryParse(operat, out double number))
                {
                    stack.Push(number);
                }
                else
                {
                    double num2 = stack.Pop();
                    double num1 = stack.Pop();
                    double result = Gorc(num1, num2, operat);
                    stack.Push(result);
                }
            }
        }
        else { }
        return stack.Pop();
    }

    private static double Gorc(double left, double right, string operation)
    {
        switch (operation)
        {
            case "+":
                return left + right;
            case "-":
                return left - right;
            case "*":
                return left * right;
            case "/":
                if (right == 0)
                    throw new DivideByZeroException("Devide In Zero");
                return left / right;
            default:
                throw new ArgumentException("Error operation: " + operation);
        }
    }
}
