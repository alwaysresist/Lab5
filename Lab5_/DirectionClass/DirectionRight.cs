using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Lab5_
{
    class DirectionRight:DirectionState, IDirection
    {
        public DirectionRight(Bitmap image)
        {
            this.image = image;
        }
        public direction Trend => direction.Right;
        public void Step(ref int X, ref int Y)
        {
            X += step;
        }
        IDirection IDirection.ChangeTrend(string command)
        {
            direction newtrend = Trends[command];
            switch (newtrend)
            {
                case direction.Down:
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    return new DirectionDown(image);
                case direction.Left:
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    return new DirectionLeft(image);
                case direction.Up:
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    return new DirectionUp(image);
                default: return new DirectionRight(image);
            }
        }
    }
}
