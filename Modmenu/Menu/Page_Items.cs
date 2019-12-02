using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
namespace ModmenuLib
{
    public partial class Menu
    {

        public List<page> Page = new List<page>();
        public class page
        {
            public string Title { get; set; }
            public Font TitleFont { get; set; }
            public Color TitleColor { get; set; }
            public List<item> Items = new List<item>();

            public void Add(Font Font, string Text, int FunctionType, string[] FunctionType2Values, int ReturnToPage, Action Function)
            {
                item Item = new item();
                //Create Item

                if (Items.Count() == 0) { Item.WasOn = true; } else { Item.WasOn = false; }
                Item.Font = Font;
                Item.Text = Text;
                Item.FunctionType = FunctionType;
                Item.ReturnToPage = ReturnToPage;
                Item.Function = Function;
                Item.Function2Values = FunctionType2Values;
                if (Item.Function2Values != null) { Item.Function2_SelectedValue = FunctionType2Values[0]; }
                Items.Add(Item);
            }
        }

        public class item
        {
            public bool WasOn { get; set; }
            public string Text { get; set; }
            public Font Font { get; set; }
            public int FunctionType { get; set; }
            public int ReturnToPage { get; set; }
            public Action Function { get; set; }
            public bool FunctionActivated { get; set; }
            public string[] Function2Values { get; set; }
            public string Function2_SelectedValue { get; set; }
        }
    }
}
