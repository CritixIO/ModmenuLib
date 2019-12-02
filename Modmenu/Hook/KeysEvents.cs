using System;
using System.Windows.Forms;

namespace HookMouseKeyboard
{
	internal class KeysEvents
    {
        private static bool CanPressKey = true;
		public static void HookManager_KeyDown(object sender, KeyEventArgs e)
		{
            if (!CanPressKey) { }
            else { ModmenuLib.Menu.KeysEvents.Launch(sender,e); }
            CanPressKey = false;
        }
		public static void HookManager_KeyUp(object sender, KeyEventArgs e)
		{
            CanPressKey = true;
        }
		public static void HookManager_KeyPress(object sender, KeyPressEventArgs e)
		{
		}
		public static void HookManager_MouseMove(object sender, MouseEventArgs e)
		{
		}
		public static void HookManager_MouseClick(object sender, MouseEventArgs e)
		{
		}
		public static void HookManager_MouseUp(object sender, MouseEventArgs e)
		{
		}
		public static void HookManager_MouseDown(object sender, MouseEventArgs e)
		{
		}
		public static void HookManager_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		}
		public static void HookManager_MouseWheel(object sender, MouseEventArgs e)
		{
		}
	}
}
