using System.IO;
using System;
class L1S05
{
	public static void MainX()
	{
		var memoryStream=new MemoryStream();
		
		var binaryWriter=new BinaryWriter(memoryStream);
		for (int i=1;i<10000 ;i*=2)
			binaryWriter.Write (i-1);
		var position=memoryStream.Position;
		binaryWriter.Close();
		
		var bytes=memoryStream.GetBuffer ();
		for (int i=0;i<position;i+=4)
		{
			for (int j=0;j<4;j++)
				Console.Write ("{0,2:X} ",bytes[i+j]);
			Console.WriteLine ();
		}
	}
}
