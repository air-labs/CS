using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;


class L5S04
{
    public static void MainX()
    {
        
        var param = Expression.Parameter(typeof(string), "s");
        var expression =
            Expression.Lambda<Func<string, string>>(
                Expression.Call(
                    param,
                    typeof(string).GetMethod("Substring", new[] { typeof(int),typeof(int)}),
                    Expression.Constant(0),
                    Expression.Constant(3)),
                new ParameterExpression[] { param });
        var lambda = expression.Compile();
        Console.WriteLine(lambda("abcd"));
		
		
		

    }
}