using System;
using System.Collections.Generic;
using System.Linq;


namespace yujuu_test_backend
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            MathTest match = new MathTest();

            while (answer != null && !answer.Equals("q"))
            {
                ExpressionDto exp = new ExpressionDto();

                exp.expression = ReadExpression();

                int option = SelectOperation();

                if (option == 1)
                {
                    exp.evaluationArray = AddListOfFloat();
                    Console.WriteLine("Result After evaluate");
                    foreach (var f in match.EvalExpression(exp))
                    {
                        Console.WriteLine("Value evaluated " + f);
                    }
                }
                else
                {
                    exp.derivativeVar = SelectDerivativeValue();
                    Console.WriteLine("Derivative expression of " + exp.derivativeVar);
                    Console.WriteLine(match.PartialDerivative(exp));
                    Console.Read();
                }

                Console.WriteLine("Would you like to repeat. Press q to exit");
                answer = Console.ReadLine();
            }
        }

        static string ReadExpression()
        {
            Console.Clear();
            
            string exp = "";
            Console.WriteLine("Write the expression to evaluate. Ex Cos(x) + x2");
            exp = Console.ReadLine();

            return exp;
        }

        static int SelectOperation()
        {
            Console.WriteLine("Wich operation would you like to applied?");
            Console.WriteLine("1. Evaluate");
            Console.WriteLine("2. Partial derivate");
            string option = "";
            option = Console.ReadLine();

            return Int32.Parse(option);
        }

        static float[] AddListOfFloat()
        {
            Console.WriteLine("Add the list of numbers to evaluate. Press q to finish");
            List<float> list = new List<float>();

            string value =  Console.ReadLine();
            while (float.TryParse(value, out float valueF))
            {
                list.Add(valueF);
                value = Console.ReadLine();
            }

            return list.ToArray();
        }

        static char SelectDerivativeValue()
        {
            Console.WriteLine("Select variable to find out derivative expression");
            return (char)Console.Read();
        }
    }
}