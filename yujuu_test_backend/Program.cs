using System;


namespace yujuu_test_backend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MathTest test = new MathTest();

            ExpressionDto exp = new ExpressionDto();
            exp.expression = "sin(x12) + x3cos(x2) + 42";
            exp.evaluationArray = new float[] { 2.2f, 3.3f, 4.6f, 5.8f };
            exp.derivativeVar = 'x';

            //Console.WriteLine(test.PartialDerivative(exp));

            // foreach (var f in test.EvalExpression(exp))
            // {
            //     Console.WriteLine("Value evaluated " + f);
            // }
        }
    }
}