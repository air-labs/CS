using System.IO;
using System.Threading;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Lab1
{

    

	partial class Program
	{

        class MyForm : Form { public void Center() { CenterToScreen(); } }

		static Map currentMap;
		static int currentX=0;
		static int currentY=0;
		static bool[] keys=new bool[3];
		
		static void Go(Direction Direction)
		{
			currentMap.Restore(currentX,currentY);
			int dx=0;
			int dy=0;
			switch(Direction)
			{
			case Direction.Left : dx=-1; break;
			case Direction.Right: dx=1;break;
			case Direction.Up   : dy=-1;break;
			case Direction.Down: dy=1;break;
			}
			
			var newX=currentX+dx;
			var newY=currentY+dy;
			bool stop=false;
			bool exit=false;
			string message="                              ";
			
			if (newX<0 || newX>=currentMap.Width || newY<0 || newY>=currentMap.Height)
			{
				stop=true;
				message="Вы уперлись в стену";
				HittedObject=MapElements.Wall;
			}
			else
			{
				HittedObject=currentMap.map[newX,newY];
				
				switch(HittedObject)
				{
				case MapElements.CopperDoor: 
					if (!keys[0]) stop=true; 
					message=stop?"Нет бронзового ключа":"бронзовая дверь открыта";
					break;
				case MapElements.CopperKey: 
					keys[0]=true; 
					message="Вы подобрали бронзовый ключ";
					break;
				case MapElements.Exit: 
					File.WriteAllText ("log",(currentMap.Number+1).ToString()); 
					message="Вы выиграли";
					exit=true;
					break;
				case MapElements.GoldDoor: 
					if (!keys[2]) stop=true; 
					message=stop?"Нет золотого ключа":"золотая дверь открыта";
					break;
				case MapElements.GoldKey: 
					keys[2]=true; 
					message="Вы подобрали золотой ключ";
					break;
				case MapElements.Hint: 
					Hint=currentMap.hints[newX,newY]; 
					message="Вы прочли"+Hint;
					break;
				case MapElements.SilverDoor: 
					if (!keys[1]) stop=true; 
					message=stop?"Нет серебряного ключа":"серебряная дверь открыта";
					break;
				case MapElements.SilverKey: 
					keys[1]=true; 
					message="Вы подобрали серебряный ключ";
					break;
				case MapElements.Wall: 
					stop=true;
					message="Вы уперлись в стену";
					break;
				case MapElements.Pike:
					exit=true;
					message="Вы проиграли";
					break;
				}
			}
			
			if (!stop)
			{
				currentX=newX;
				currentY=newY;
			}
			Message=message;
			if (string.IsNullOrWhiteSpace(message)) Message="";
			currentMap.PlacePlayer (currentX,currentY);
			SuperConsole.Print (currentMap.Width+3,0,message);
			currentMap.ToSafePosition ();
			Thread.Sleep (20);
			if (exit)
			{
				Console.WriteLine ("Нажмите любую клавишу");
				Console.ReadKey ();
				Process.GetCurrentProcess ().Kill ();
			}
		}	
				
					
				
		static int GetCurrentGame(int level)
		{
			Stages.InitializeStages();
			if (level>=Stages.stages.Count)
				throw new Exception("Wrong level");
			InitializeLevel (level);
			return level;
		}
			
		
		static void InitializeLevel(int level)
		{
			Console.Clear ();
			currentMap=Stages.stages[level];
			currentMap.Print();
			currentMap.PlacePlayer(currentX,currentY);
			Console.CursorTop=currentMap.Height+2;
		}
		
		static int GetCurrentGame()
		{
			Stages.InitializeStages();
			var num=0;
			if (File.Exists("log"))
			{
				try
				{
					num=int.Parse (File.ReadAllText ("log"));
				}
				catch {}
			}
			
			if (num>=Stages.stages.Count)
			{
                var image = Image.FromFile("Environment/special.pcx");
                var pbox = new PictureBox();
                pbox.Image = image;
                pbox.Size = image.Size;
                pbox.Dock = DockStyle.Fill;
                var form = new MyForm();
                form.ClientSize = pbox.Size;
                form.Controls.Add(pbox);
                form.FormClosed += (o, s) =>
                    {
                        var msg = MessageBox.Show("Начать заново?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (msg == DialogResult.Yes)
                        {
                            File.Delete("log");
                            num = 0;
                        }
                        else
                        {
                            Process.GetCurrentProcess().Kill();
                        }
                    };
                form.Center();
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.Text = "Вы выиграли";
                form.ShowDialog();
			}
			InitializeLevel(num);
			return num;
		}
	}
}
