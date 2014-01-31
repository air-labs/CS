using System.IO;
using System;
class L1S03
{
	public static void MainX()
	{
		var outStream=File.Open ("streambin",FileMode.OpenOrCreate, FileAccess.Write);
		var byteWriter=new BinaryWriter(outStream);
		for (int i=1;i<10000 ;i*=2)
			byteWriter.Write (i-1);
		byteWriter.Close();
		
		var inStream=File.Open ("streambin",FileMode.Open, FileAccess.Read);
		var byteReader=new BinaryReader(inStream);
		while(true)
		{
			var bytes=new byte[4];
			if (byteReader.Read (bytes,0,4)!=4) break;
			foreach(var b in bytes)
				Console.Write ("{0,2:X} ",b);
			Console.WriteLine ();
		}
		byteReader.Close ();
	}
		
		
}