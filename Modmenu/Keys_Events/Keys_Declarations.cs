using System.Windows.Forms;
namespace ModmenuLib
{
    public partial class Keys_Events
    {
        
        public void Launch(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Menu.Get.Key.OpenClose) { Menu.KeysEvents.Key_OpenClose(sender, e); }
            if (Menu.Get.WasOpened)
            {
                if (e.KeyCode == Menu.Get.Key.Up) { Menu.KeysEvents.Key_Up(sender, e); }
                else if (e.KeyCode == Menu.Get.Key.Down) { Menu.KeysEvents.Key_Down(sender, e); }
                else if (e.KeyCode == Menu.Get.Key.Left) { Menu.KeysEvents.Key_Left(sender, e); }
                else if (e.KeyCode == Menu.Get.Key.Right) { Menu.KeysEvents.Key_Right(sender, e); }
                else if (e.KeyCode == Menu.Get.Key.Action) { Menu.KeysEvents.Key_Action(sender, e); }
            }
        }
    } 
}
