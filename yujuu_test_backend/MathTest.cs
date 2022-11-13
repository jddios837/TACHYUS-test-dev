using System;
using System.Collections.Generic;
using AngouriMath;
using AngouriMath.Core.Exceptions;

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
                try
                {
                    var eval = (float)newExpr.EvalNumerical();
                    list.Add((float)newExpr.EvalNumerical());
                }
                catch (CannotEvalException e)
                {
                    return list;
                }
                
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