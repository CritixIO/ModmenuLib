using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace ModmenuLib
{
    public partial class Keys_Events
    {
        public void Key_Right(object sender, KeyEventArgs e)
        {
            int OnItem_Index = Menu.Get.Page[Menu.Get.WasOnPage].Items.FindIndex(x => x.WasOn == true);
            Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].Function?.Invoke();

            if (Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].FunctionType == 2)
            {
                //Detect the new value
                List<string> values = Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].Function2Values.ToList();
                int index = values.FindIndex(x => x == Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].Function2_SelectedValue);
                if (index + 1 < values.Count()) { Menu.Get.Page[Menu.Get.WasOnPage].Items[OnItem_Index].Function2_SelectedValue = values[index + 1]; }
                //Redraw
                Menu.Get.Redraw();
            }
        }
    }
}
