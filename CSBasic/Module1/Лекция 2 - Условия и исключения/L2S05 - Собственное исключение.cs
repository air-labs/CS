using System;

public class NegativeArgumentException : Exception
{
	public string ArgumentName;	
	public NegativeArgumentException(string argumentName)
	{
		ArgumentName=argumentName;
	}
}

public class L2S05 
{
	public static void MainX()
	{
		try
		{
			var a=int.Parse(Console.ReadLine());
			var b=int.Parse(Console.ReadLine());
			if (a<0) throw new NegativeArgumentException("A");
			if (b<0) throw new NegativeArgumentException("B");
			Console.WriteLine (a+b);
		}
		catch(NegativeArgumentException me)
		{
			Console.WriteLine ("Negative argument {0}",me.ArgumentName);
		}
		catch(Exception e)
		{
			Console.WriteLine("Unknown error {0}",e.Message);
		}
	}
}

//!Создание пользовательских исключений, обработка разных типов исключений