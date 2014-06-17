using System;

public class L3S01
{
	public static void MainX()
	{
		int[] array=new int[5];
		array[0]=0;
		array[1]=2;
		array[2]=4;
		array[3]=6;
		array[4]=8;
		//array[5]=10; //ошибка - выход за границы массива
		
		foreach(var e in array)
			Console.Write ("{0} ",e);
		
		Console.WriteLine();
	}
}
//!массив, foreach