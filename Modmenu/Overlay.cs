using System.Windows.Forms;
using System;
using System.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ModmenuLib
{
    public class Overlay : Form
    {
        #region Dll_Imports
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, Int32 crKey, int bAlpha, uint dwFlags);


        #endregion
        #region NoVisualRedraw
        int WS_EX_COMPOSITED = 0x02000000;/*Double Buffered (All Controls)*/
        int WS_EX_LAYERED = 0x00080000;/*Click Trough Form*/
        int WS_EX_TRANSPARENT = 0x00000020;/*Form Allow Transparent*/
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_COMPOSITED;
                createParams.ExStyle |= WS_EX_LAYERED;
                createParams.ExStyle |= WS_EX_TRANSPARENT;
                return createParams;
            }
        }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            int msg = message.Msg;
            if (msg == 274)
            {
                int num = message.WParam.ToInt32() & 65520;
                if (num == 61488 || num == 61728)
                {
                    this.Refresh();
                    base.Invalidate();
                }
            }
        }
        #endregion
        public Overlay()
        {
            ModmenuLib.Menu MyMenu = new ModmenuLib.Menu();
            ModmenuLib.Menu.Get = MyMenu;
            this.Text = "Overlay";
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.TransparencyKey = this.BackColor;

            this.ShowInTaskbar = false;

            Timer OverlayOnProcess = new Timer();
            OverlayOnProcess.Interval = 100;
            OverlayOnProcess.Tick += OverlayOnProcess_Tick;
            OverlayOnProcess.Start();

            this.Paint += ModmenuLib.Menu.Get.Draw;
            HookMouseKeyboard.HookManager.Load();
            ModmenuLib.Menu.Get.Load();
            ModmenuLib.Menu.Get.Overlay = this;

            this.Show();

            
        }
          
        public RECT rect;
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
            public int x;
            public int y;
        }
        
        private void OverlayOnProcess_Tick(object sender, EventArgs e)
        {
            Process proc = Process.GetProcessesByName(ModmenuLib.Menu.Get.GameName).FirstOrDefault();

            if (proc != null)
            {
                IntPtr owner = proc.MainWindowHandle;
                IntPtr owned = this.Handle;
                SetWindowLong(owned, -8 /*GWL_HWNDPARENT*/, owner);

                GetWindowRect(owner, out rect);
                this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
                this.Location = new Point(rect.left, rect.top);
            }
        }
        #region AutoGenerate by code
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

    }
}
