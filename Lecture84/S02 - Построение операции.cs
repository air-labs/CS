using System.Linq.Expressions;
using System;
class L5S02
{
	public static void MainX()
	{
		var param=Expression.Parameter (typeof(int),"x");
		var expression=
			Expression.Lambda<Func<int,int>>(
				Expression.Add (
					param,
					Expression.Constant (1)),
				new ParameterExpression[]  { param });
		var lambda=expression.Compile ();
		Console.WriteLine(lambda(2));
		
		
		
		
	}
	
}
//!Построение Expression