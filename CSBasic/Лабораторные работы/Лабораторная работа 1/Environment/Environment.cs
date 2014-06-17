using System;

namespace Lab1
{
	
	
	public partial class Environment
	{
		int currentX;
		int currentY;
			
		public void Up()
		{
			Update(0,-1);
		}
		public void Down()
		{
			Update(0,1);
		}
		public void Left()
		{
			Update(-1,0);
		}
		public void Right()
		{
			Update(1,0);
		}
		void Update(int dx, int dy)
		{
		}
			
		
		
		
		
	}
}

