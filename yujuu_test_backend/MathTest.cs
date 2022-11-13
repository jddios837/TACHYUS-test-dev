using System.Collections.Generic;
using AngouriMath;

namespace yujuu_test_backend
{
    public class MathTest
    {
        public MathTest() { }

        public List<float> EvalExpression(ExpressionDto exp)
        {
            List<float> list = new List<float>();
            
            Entity expr = exp.expression;

            foreach (var val in exp.evaluationArray)
            {
                var newExpr = expr.Substitute("x", val);
                list.Add((float)newExpr.EvalNumerical());
            }
            
            return list;
        }

        public string PartialDerivative(ExpressionDto exp)
        {
            Entity expr = exp.expression;
            Entity.Variable x = exp.derivativeVar.ToString();
            return expr.Differentiate(x).ToString();
        }
    }
}