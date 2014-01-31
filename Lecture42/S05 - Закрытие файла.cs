using System;
using System.IO;

class L2S05
{
	public static void MainX()
	{
		var writer=new StreamWriter("temp.txt");
		writer.WriteLine("Hello, world!");
        //throw new Exception(); //перед закрытием случайно вылетело исключение
		//writer.Close ();  //мы забыли закрыть файл

        //Если забыли закрыть файл, то он останется пустым:
        //буфер - это управляемый ресурс, сброс буфера происходит только при вызове Dispose, который вызывается из Close
        //с другой стороны, файл - это неуправляемый ресурс, и он освобождается в любом случае
	}
}