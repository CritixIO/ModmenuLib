using System.Windows.Forms;
namespace ModmenuLib
{
    public partial class Keys_Events
    {
        public void Key_OpenClose(object sender, KeyEventArgs e)
        {
            if (Menu.Get.WasOpened) { Menu.Get.WasOpened = false; Menu.Get.Redraw(); }
            else if(!Menu.Get.WasOpened) { Menu.Get.WasOpened = true; Menu.Get.Redraw(); }
        }
    }
}
