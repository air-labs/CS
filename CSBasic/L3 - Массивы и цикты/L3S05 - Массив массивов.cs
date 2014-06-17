using System;

public class L3S05
{
	public static void PrintDoubleArray(string[][] doubleArray)
	{
		for (int row=0;row<doubleArray.Length;row++)
		{
			for (int column=0;column<doubleArray[row].Length;column++)
				Console.Write("{0} ",doubleArray[row][column]);
			Console.WriteLine ();
		}
	}
	
	public static void MainX()
	{
		var doubleArray1= new string[2][];
		doubleArray1[0]=new string[1];
		doubleArray1[0][0]="a00";
		doubleArray1[1]=new string[2];
		doubleArray1[1][0]="a10";
		doubleArray1[1][1]="a11";
		PrintDoubleArray (doubleArray1);

        Console.WriteLine("---");
		
		var doubleArray2=new[]
		{
			new[] { "b00" },
			new[] { "b10", "b11" },
			new[] { "b20", "b21" }
		};
		PrintDoubleArray (doubleArray2);
	}
}

//!Массив массивов

