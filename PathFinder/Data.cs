using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public static class Data
    {        
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static Board board;
        public static Home.Type SelectionType = Home.Type.StartPoint;
        public static Home StartHome = null;
        public static Home DestinationHome = null;
        public static bool Is8Side = false;
    }
}
