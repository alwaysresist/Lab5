using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Lab5_
{
    class DirectionDown : DirectionState, IDirection
    {
        public DirectionDown(Bitmap image)
        {
            this.image = image;
        }

        public direction Trend => direction.Down;

        public void Step(ref int X, ref int Y)
        {
            Y += step;
        }

        IDirection IDirection.ChangeTrend(string command)
        {
            direction newtrend = Trends[command];
            switch (newtrend)
            {
                case direction.Left:
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    return new DirectionLeft(image);
                case direction.Up:
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    return new DirectionUp(image);
                case direction.Right:
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    return new DirectionRight(image);
                default: return new DirectionDown(image);
            }
        }
    }
}
