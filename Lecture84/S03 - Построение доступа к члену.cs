using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

class L5S03
{
    public static void Main()
    {

        var param = Expression.Parameter(typeof(DateTime), "s");
        var expression =
            Expression.Lambda<Func<DateTime, int>>(
                Expression.MakeMemberAccess(
                    param,
                    typeof(DateTime).GetProperty("Year")),
                new ParameterExpression[] { param });
        var lambda = expression.Compile();
        Console.WriteLine(lambda(DateTime.Now));




    }
}