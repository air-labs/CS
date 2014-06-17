using System;

public class L3S04
{
	public static void PrintTensor(string[,] tensor)
	{
		for (int row=0;row<tensor.GetLength (0);row++)
		{
			for (int column=0;column<tensor.GetLength(1);column++)
				Console.Write("{0} ",tensor[row,column]);
			Console.WriteLine ();
		}
	}
	
	public static void MainX()
	{
		var tensor1= new string[1,2];
		tensor1[0,0]="a00";
		tensor1[0,1]="a01";
		PrintTensor (tensor1);

        Console.WriteLine("---");
		
		var tensor2=new string[,]
		{
			{ "b00", "b01" },
			{ "b10", "b11" },
			{ "b20", "b21" }
		};
		PrintTensor (tensor2);
	}
}
