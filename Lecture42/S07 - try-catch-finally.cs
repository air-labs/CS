
using System;
using System.IO;

class L2S07
{
	public static void MainX()
	{
		StreamWriter writer=null;
		try
		{
		writer=new StreamWriter("temp.txt");
		writer.WriteLine("Hello, world!");
		throw new Exception("");
		}
		catch 
		{
		}
		finally //закрывает блок в любом случае
		{
		writer.Close ();
		}
	}
}