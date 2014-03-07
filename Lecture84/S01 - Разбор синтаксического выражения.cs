using System;
using System.Linq.Expressions;
class L5S01
{
	public static string GetString(Expression exp)
	{
		if (exp is BinaryExpression)
		{
			var bexp=exp as BinaryExpression;
			return string.Format ("({0} {1} {2})",
			                      GetString (bexp.Left),
			                      bexp.NodeType,
			                      GetString (bexp.Right));
		}
		if (exp is ConstantExpression)
		{
			return (exp as ConstantExpression).Value.ToString ();
		}
		if (exp is ParameterExpression)
		{
			return (exp as ParameterExpression).Name;
		}
		throw new NotImplementedException();
		
	}
	
	public static void Print(Expression<Func<int,int>> f)
	{
		Console.WriteLine (GetString(f.Body));
	}
	
	public static void MainX()
	{
		Print (z=>z*(z+5));	
	}
	
	
	
}

//!Разбор Expression