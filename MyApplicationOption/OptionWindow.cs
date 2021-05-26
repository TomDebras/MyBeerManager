using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationOption
{
    public class OptionWindow
    {

        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int Width { get; set; }
        public OptionWindow(int Red, int Green, int Blue, int size)
        {
            R = Red;
            G = Green;
            B = Blue;
            Width = size;
        }
        public OptionWindow(int Red, int Green, int Blue) : this(Red, Green, Blue, 0) { }
        public OptionWindow() : this(0, 0, 0, 0) { }

    }
}
