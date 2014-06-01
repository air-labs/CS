using System.IO;
using System;
class L1S04
{
	public static void MainX()
	{
		var textWriter=new StreamWriter("streamtxt",false);
		for(int i=0;i<10;i++)
			textWriter.WriteLine (i.ToString ());
		textWriter.Close ();
		
		var textReader=new StreamReader("streamtxt",false);
		while(true)
		{
			var line=textReader.ReadLine();
			if (line==null) break;
			Console.WriteLine(line);
		}
		textReader.Close ();
	}
}
