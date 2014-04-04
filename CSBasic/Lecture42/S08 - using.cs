using System.IO;
using System;
class L2S08
{
	public static void MainX()
	{
        //гораздо элегантнее, чем try-catch-finally
        //запускать с Ctrl-F5, чтобы студия не прерывала выполнение на исключении
		using (var writer=new StreamWriter("text.txt")) 
		{
			writer.WriteLine ("Hello, world!");
			throw new Exception();
		}
	}
}