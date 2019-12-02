using System.Linq;
using System.Windows.Forms;
namespace ModmenuLib
{
    public partial class Keys_Events
    {
        public void Key_Down(object sender, KeyEventArgs e)
        {
            int itemsCount = Menu.Get.Page[Menu.Get.WasOnPage].Items.Count() -1;
            int OnItem_Index = Menu.Get.Page[Menu.Get.WasOnPage].Items.FindIndex(x=> x.WasOn == true);
            if (OnItem_Index < itemsCount) 
            {
                //Set the actual line to WasOn False
                Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].WasOn = false;
                //Set the line under the actual line to WasOn True
                Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index+1].WasOn = true;
                //Redraw
                Menu.Get.Redraw();
            }
        }
    }
}
