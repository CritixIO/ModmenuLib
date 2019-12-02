using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace ModmenuLib
{
    public partial class Menu
    {
        public void Redraw()
        {
            this.Overlay.Invalidate();
        }
        private List<float> Get_location_from_strings_ToMid(PaintEventArgs e, string Text, Font font)
        {
            string[] Texts = Text.Split(' ');
            float[] LocationX = new float[Texts.Length];
            LocationX[0] = Location.X + (Size.Width - e.Graphics.MeasureString(Text, font).Width) / 2;

            for (int x = 1; x < Texts.Count(); x++)
            {
                LocationX[x] = LocationX[x - 1]
                + e.Graphics.MeasureString(Texts[x - 1], font).Width;
            }

            return LocationX.ToList();

        }
        
        public void Draw(object sender, PaintEventArgs e)
        {
            if (this.WasOpened)
            {
                this.Overlay.Opacity = (double)(this.Opacity) / 100;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;

                if (this.Image == null)
                {
                    if (this.Color == Color.Transparent)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(this.Overlay.BackColor), new Rectangle(this.Location, this.Size));
                    }
                    else
                    {
                        e.Graphics.FillRectangle(new SolidBrush(this.Color), new Rectangle(this.Location, this.Size));
                    }
                }
                else
                {
                    this.Size = new Size(this.Image.Width,this.Image.Height);
                    e.Graphics.DrawImage(this.Image, this.Location);
                }

                int lx = 0, ly = 20;
                if (this.Page[this.WasOnPage].Title != "")
                {
                    lx = this.Location.X + (int)(this.Size.Width - e.Graphics.MeasureString(this.Page[this.WasOnPage].Title, this.Page[this.WasOnPage].TitleFont).Width) / 2;
                    e.Graphics.DrawString(this.Page[this.WasOnPage].Title, this.Page[this.WasOnPage].TitleFont,
                        new SolidBrush(this.Page[this.WasOnPage].TitleColor),
                        lx, ly);
                    ly += (int)(e.Graphics.MeasureString(this.Page[this.WasOnPage].Title, this.Page[this.WasOnPage].TitleFont).Height);
                }
                foreach (item item in this.Page[this.WasOnPage].Items)
                {
                    SolidBrush LineColor;
                    SolidBrush Selected_Text_Color = new SolidBrush(Color.Black);
                    string Selected_Text = "";

                    if (item.WasOn) { LineColor = new SolidBrush(Color.FromArgb(this.Opacity * 255 / 100, this.Selected_LineColor)); }
                    else { LineColor = new SolidBrush(this.Default_LineColor); }

                    if (item.FunctionType == 0)
                    {
                        lx = this.Location.X + (int)(Size.Width - e.Graphics.MeasureString(item.Text, item.Font).Width) / 2;
                        e.Graphics.DrawString(item.Text, item.Font, LineColor, lx, ly);
                    }
                    //Enable_Disable + selected Value
                    else if (item.FunctionType == 1 || item.FunctionType == 2)
                    {
                        if (item.FunctionActivated && item.FunctionType == 1)
                        { Selected_Text = this.Enable; }
                        else if (!item.FunctionActivated && item.FunctionType == 1)
                        { Selected_Text = this.Disable; }
                        else if (item.FunctionType == 2)
                        { Selected_Text = item.Function2_SelectedValue; }

                        for (int x = 0; x < 4; x++)
                        {
                            if (x == 0) { Selected_Text_Color = LineColor; }
                            else if (x == 1 || x == 3) { Selected_Text_Color = new SolidBrush(this.Bars_Color); }
                            else
                            {
                                if (item.FunctionActivated && item.FunctionType == 1)
                                { Selected_Text_Color = new SolidBrush(this.Function_Enable_Color); }
                                else if (!item.FunctionActivated && item.FunctionType == 1)
                                { Selected_Text_Color = new SolidBrush(this.Function_Disable_Color); }
                                else if (item.FunctionType == 2)
                                { Selected_Text_Color = new SolidBrush(this.Function2_Selected_Color); }

                            }
                            string text = item.Text + " " + this.Bars[0] + " " + Selected_Text + " " + this.Bars[1];
                            string[] textarray = text.Split(' ');
                            List<float> LxArray = Get_location_from_strings_ToMid(e, text, item.Font);

                            e.Graphics.DrawString(textarray[x], item.Font, Selected_Text_Color, LxArray[x], ly);
                        }

                    }
                    ly = ly + (int)e.Graphics.MeasureString(item.Text, item.Font).Height + 2;
                }
            } 
        }   
    }
}
