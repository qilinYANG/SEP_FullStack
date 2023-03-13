using System;
namespace Assign3.ColorBall
{
	public class Ball
	{
		private int size;
		private int throwTime;
		private Color color;

		public Ball(int size, Color color)
		{

			this.size = size;
			this.throwTime = 0;
			this.color = color;
		}

		void pop()
		{
			size = 0;
		}

		void thrown()
		{
			throwTime += 1;
		}
		
	}
}

