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
        public void Load()
        {
            GTA_SA_Modmenu.GTA gta = new GTA_SA_Modmenu.GTA();
            /*Menu Settings*/
            GameName = "gta_sa";
            Image = null;
            Opacity = 100;
            Location = new Point(10,10);
            Size = new Size(200, 400);
            Key.OpenClose = Keys.Insert;
            Key.Up = Keys.Up;
            Key.Down = Keys.Down;
            Key.Left = Keys.Left;
            Key.Right = Keys.Right;
            Key.Action = Keys.Enter;
            Color = Color.Black;
            Default_LineColor = Color.White;
            Selected_LineColor = Color.Fuchsia;
            Function_Enable_Color = Color.Green;
            Function_Disable_Color = Color.Red;
            Function2_Selected_Color = Color.Orange;
            Enable = "On";
            Disable = "Off";
            Bars = new string[] { "[", "]" };
            Bars_Color = Color.White;

            /*Menu Declaration*/
            //Main Menu
            Page.Add(new Menu.page());
            Page[0].Title = "Main Menu";
            Page[0].TitleColor = Color.Cyan;
            Page[0].TitleFont = new Font("Arial", 14f, FontStyle.Bold);
            Page[0].Add(new Font("Arial", 12f, FontStyle.Bold), "Teleport Menu", 0, null, 1, null); //Simple Click Action
            Page[0].Add(new Font("Arial", 12f, FontStyle.Bold), "Godmode", 1, null, -1, null); // On Off
            Page[0].Add(new Font("Arial", 12f, FontStyle.Bold), "SpeedHack", 2, new string[] { "Speed1", "Speed2", "Speed3" }, -1, null); //Choice

            //Teleport Menu
            Page.Add(new ModmenuLib.Menu.page());
            Page[1].Title = "Teleport Menu";
            Page[1].TitleColor = Color.Cyan;
            Page[1].TitleFont = new Font("Arial", 14f, FontStyle.Bold);
            Page[1].Add(new Font("Arial", 12f, FontStyle.Bold), "Johnson's House", 0, null, -1, () => gta.Teleport(2495.5, -1690.1, 15.5)); // '() =>' = calling void 
            Page[1].Add(new Font("Arial", 12f, FontStyle.Bold), "Front Johnson's House", 0, null, -1, () => gta.Teleport(2497.1, -1672.6, 13.34)); // '() =>' = calling void 
            Page[1].Add(new Font("Arial", 12f, FontStyle.Bold), "TP to Paint", 0, null, -1, () => gta.Teleport(2062.2, -1832.5, 13.2)); // '() =>' = calling void 
            Page[1].Add(new Font("Arial", 12f, FontStyle.Bold), "Main Menu", 0, null, 0, null);
        }
    }
}
