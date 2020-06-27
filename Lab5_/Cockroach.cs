using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace Lab5_
{
    public class Cockroach
    {
        public Bitmap image;
        const int step = 40;
        int x;
        int y;
        direction trend = direction.Right;

        public Cockroach(Bitmap _image)
        {
            image = _image;
        }

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        public Bitmap Image
        {
            get => image;
            set => image = value;
        }

        public void newcoordinates(int dx, int dy)
        {
            x = dx;
            y = dy;
        }

		public void Step()
		{
			switch (trend)
			{
				case direction.Right:
					{
						X += step;
					}
					break;
				case direction.Down:
					{
						Y += step;
					}
					break;
				case direction.Left:
					{
						X -= step;
					}
					break;
				case direction.Up:
					{
						Y -= step;
					}
					break;
			}
		}

		public void ChangeTrend(char c)
		{
			direction newtrend = trend;
			for (direction y = direction.Up; y <= direction.Left; y++)
				if (char.ToLower(c) == char.ToLower(y.ToString()[0]))
				{
					newtrend = y;
					break;
				}
			switch (trend)
			{
				case direction.Up:
					switch (newtrend)
					{
						case direction.Right: Image.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
						case direction.Down: Image.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
						case direction.Left: Image.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
					}
					break;
				case direction.Right:
					switch (newtrend)
					{
						case direction.Up: Image.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
						case direction.Down: Image.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
						case direction.Left: Image.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
					}
					break;
				case direction.Down:
					switch (newtrend)
					{
						case direction.Right: Image.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
						case direction.Up: Image.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
						case direction.Left: Image.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
					}
					break;
				case direction.Left:
					switch (newtrend)
					{
						case direction.Right: Image.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
						case direction.Down: Image.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
						case direction.Up: Image.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
					}
					break;
			}
			trend = newtrend;
		}
	}
}
