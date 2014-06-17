using System.Windows.Forms;
using System;
class L1S07
{
	[STAThread] //!Не забыть, иначе ничего не будет работать!
	public static void MainЧ()
	{
		var saveDialog=new SaveFileDialog();
		saveDialog.Filter="(*.txt) Текстовые файлы|*.txt";
		if (saveDialog.ShowDialog()!=DialogResult.OK)
		{
			MessageBox.Show ("Пользователь отказался");
		}
		else
		{
			MessageBox.Show(string.Format ("Пользователь выбрал файл{0})",saveDialog.FileName));
		}
		
	}
}