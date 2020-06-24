using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Lab5_
{
    class DirectionState
    {
        protected Dictionary<string, direction> Trends = new Dictionary<string, direction>()
        {
            {"Up", direction.Up },
            {"Down", direction.Down },
            {"Left", direction.Left },
            {"Right", direction.Right}
        };
        protected Bitmap image;
        protected const int step = 30;
    }
}
