using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Homework_Task
{
    internal class Calculator
    { 

      public void Calculation()
    {
        float result = 0;


        Console.WriteLine("Enter first number");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter operator");
        string op = Console.ReadLine();

        switch (op)
        {

            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Sifira bolunmur");
                    break;
                }
                else
                {
                    result = num1 / num2;
                    break;
                }



        }
        Console.WriteLine("Result = " + result);


    }

}
}
