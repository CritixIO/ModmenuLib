using System.Windows.Forms;
namespace ModmenuLib
{
    public partial class Keys_Events
    {
        public void Key_Action(object sender, KeyEventArgs e)
        {

            int OnItem_Index = Menu.Get.Page[Menu.Get.WasOnPage].Items.FindIndex(x => x.WasOn == true);
            Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].Function?.Invoke();
 
            if (Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].FunctionType == 1)
            {   
                //Set The Enable-Disable
                if (Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].FunctionActivated) 
                { Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].FunctionActivated = false; }
                else { Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].FunctionActivated = true; }
            }
            if (Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].ReturnToPage != -1)
            {
                // make the actual line on WasOn false
                Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].WasOn = false;
                Menu.Get.Page[Menu.Get.WasOnPage].Items[0].WasOn = true;
                Menu.Get.WasOnPage = Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].ReturnToPage;
            }
            //Redraw
            Menu.Get.Redraw();
        }
    }
}
