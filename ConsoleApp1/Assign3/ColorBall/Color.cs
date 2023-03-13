using System;
namespace Assign3.ColorBall
{
	public class Color
	{
		private int red { get; set; }
        private int green { get; set; }
        private int blue { get; set; }
        private int alpha { get; set; }


        public Color(int red, int green, int blue, int alpha)
		{
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = alpha;
		}


        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        public int GetGrayScale()
        {
            return (red + green + blue) / 3;
        }
    }
}

