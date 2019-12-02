using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace ModmenuLib
{
    public partial class Menu
    {
        public Overlay Overlay;
        public static Keys_Events KeysEvents = new Keys_Events();
        public static Menu Get;

        public string GameName;
        public _Keys Key = new _Keys();
        public struct _Keys
        {
            public Keys OpenClose { get; set; }
            public Keys Up { get; set; }
            public Keys Down { get; set; }
            public Keys Left { get; set; }
            public Keys Right { get; set; }
            public Keys Action { get; set; }
        }

        public Image Image;
        public bool WasOpened;
        public int WasOnPage;
        Point Location;
        Size Size;
        public int Opacity;
        public Color Color;
        public Color Default_LineColor;
        public Color Selected_LineColor;

        public Color Function_Enable_Color;
        public Color Function_Disable_Color;
        public Color Function2_Selected_Color;
        public Color Bars_Color;

        public string Enable;
        public string Disable;
        public string Actual_Function2;
        public string[] Bars;
    }
}
