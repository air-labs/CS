//выключенный комментарий
using System; //встроенный комментарий

	public class L1S03
	{
		/// <summary>
		/// Выводит на экран строку, подсвечивая ее заданным цветом
		/// </summary>
		/// <param name='color'>
		/// Цвет, которым должна быть подсвечена строка
		/// </param>
		/// <param name='text'>
		/// Текст, который нужно вывести
		/// </param>
		public static void PrintMethod(ConsoleColor color, string text)
		{
			Console.ForegroundColor=color;
			Console.WriteLine (text);
		}
		
		public static void MainX()
		{
			PrintMethod(ConsoleColor.Gray, "Gray string"); //!Показать, что документация доступна через IntelliSence
			PrintMethod(ConsoleColor.White, "White string");
	}
}

//!Комментарии и документирование

