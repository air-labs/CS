using System;

public class L1S02
{
	static string staticVariable="Static";
	string dynamicVariable="Dynamic";
	
	static void MainX()
	{
		Console.WriteLine ("We are in Main method");
		string localVariable="Local";
		if (localVariable.Length>3)
		{
			string temporaryVariable="Temporary";
			Console.WriteLine (staticVariable);
			Console.WriteLine (localVariable);
			Console.WriteLine (temporaryVariable);
			//Console.WriteLine (dynamicVariable); // нет доступа к динамической переменной из статического метода
		}
		else
		{
			Console.WriteLine (staticVariable);
			Console.WriteLine (localVariable);
			//Console.WriteLine (temporaryVariable); //нет доступа, т.к. переменная определена в другом блоке
			//Console.WriteLine (dynamicVariable); // нет доступа к динамической переменной из статического метода
		}
		StaticMethod ();
		var instance=new L1S02();
		instance.DynamicMethod();
	}
		
	static void StaticMethod()
	{
		Console.WriteLine("We are in StaticMethod");
		Console.WriteLine(staticVariable);
		//Console.WriteLine(dynamicVariable); // нет доступа к динамической переменной из статического метода
		//Console.WriteLine(localVariable); //эта переменная - локальная для MainX и не видна здесь
	}
	
	void DynamicMethod()
	{
		Console.WriteLine ("We are in DynamicMethod");
		Console.WriteLine (staticVariable);
		Console.WriteLine (dynamicVariable);
		//Console.WriteLine(localVariable); //эта переменная - локальная для MainX и не видна здесь
	}
}


//!Переменные и их области видимости