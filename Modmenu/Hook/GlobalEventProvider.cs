using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HookMouseKeyboard
{
	public class GlobalEventProvider : Component
	{
		protected override bool CanRaiseEvents
		{
			get
			{
				return true;
			}
		}
		private event MouseEventHandler m_MouseMove;
		public event MouseEventHandler MouseMove
		{
			add
			{
				if (this.m_MouseMove == null)
				{
					HookManager.MouseMove += this.HookManager_MouseMove;
				}
				this.m_MouseMove += value;
			}
			remove
			{
				this.m_MouseMove -= value;
				if (this.m_MouseMove == null)
				{
					HookManager.MouseMove -= this.HookManager_MouseMove;
				}
			}
		}
		private void HookManager_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.m_MouseMove != null)
			{
				this.m_MouseMove(this, e);
			}
		}
		private event MouseEventHandler m_MouseClick;
		public event MouseEventHandler MouseClick
		{
			add
			{
				if (this.m_MouseClick == null)
				{
					HookManager.MouseClick += this.HookManager_MouseClick;
				}
				this.m_MouseClick += value;
			}
			remove
			{
				this.m_MouseClick -= value;
				if (this.m_MouseClick == null)
				{
					HookManager.MouseClick -= this.HookManager_MouseClick;
				}
			}
		}
		private void HookManager_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.m_MouseClick != null)
			{
				this.m_MouseClick(this, e);
			}
		}
		private event MouseEventHandler m_MouseDown;
		public event MouseEventHandler MouseDown
		{
			add
			{
				if (this.m_MouseDown == null)
				{
					HookManager.MouseDown += this.HookManager_MouseDown;
				}
				this.m_MouseDown += value;
			}
			remove
			{
				this.m_MouseDown -= value;
				if (this.m_MouseDown == null)
				{
					HookManager.MouseDown -= this.HookManager_MouseDown;
				}
			}
		}
		private void HookManager_MouseDown(object sender, MouseEventArgs e)
		{
			if (this.m_MouseDown != null)
			{
				this.m_MouseDown(this, e);
			}
		}
		private event MouseEventHandler m_MouseUp;
		public event MouseEventHandler MouseUp
		{
			add
			{
				if (this.m_MouseUp == null)
				{
					HookManager.MouseUp += this.HookManager_MouseUp;
				}
				this.m_MouseUp += value;
			}
			remove
			{
				this.m_MouseUp -= value;
				if (this.m_MouseUp == null)
				{
					HookManager.MouseUp -= this.HookManager_MouseUp;
				}
			}
		}
		private void HookManager_MouseUp(object sender, MouseEventArgs e)
		{
			if (this.m_MouseUp != null)
			{
				this.m_MouseUp(this, e);
			}
		}
		private event MouseEventHandler m_MouseDoubleClick;
		public event MouseEventHandler MouseDoubleClick
		{
			add
			{
				if (this.m_MouseDoubleClick == null)
				{
					HookManager.MouseDoubleClick += this.HookManager_MouseDoubleClick;
				}
				this.m_MouseDoubleClick += value;
			}
			remove
			{
				this.m_MouseDoubleClick -= value;
				if (this.m_MouseDoubleClick == null)
				{
					HookManager.MouseDoubleClick -= this.HookManager_MouseDoubleClick;
				}
			}
		}
		private void HookManager_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.m_MouseDoubleClick != null)
			{
				this.m_MouseDoubleClick(this, e);
			}
		}
		private event EventHandler<MouseEventExtArgs> m_MouseMoveExt;
		public event EventHandler<MouseEventExtArgs> MouseMoveExt
		{
			add
			{
				if (this.m_MouseMoveExt == null)
				{
					HookManager.MouseMoveExt += this.HookManager_MouseMoveExt;
				}
				this.m_MouseMoveExt += value;
			}
			remove
			{
				this.m_MouseMoveExt -= value;
				if (this.m_MouseMoveExt == null)
				{
					HookManager.MouseMoveExt -= this.HookManager_MouseMoveExt;
				}
			}
		}
		private void HookManager_MouseMoveExt(object sender, MouseEventExtArgs e)
		{
			if (this.m_MouseMoveExt != null)
			{
				this.m_MouseMoveExt(this, e);
			}
		}
		private event EventHandler<MouseEventExtArgs> m_MouseClickExt;
		public event EventHandler<MouseEventExtArgs> MouseClickExt
		{
			add
			{
				if (this.m_MouseClickExt == null)
				{
					HookManager.MouseClickExt += this.HookManager_MouseClickExt;
				}
				this.m_MouseClickExt += value;
			}
			remove
			{
				this.m_MouseClickExt -= value;
				if (this.m_MouseClickExt == null)
				{
					HookManager.MouseClickExt -= this.HookManager_MouseClickExt;
				}
			}
		}
		private void HookManager_MouseClickExt(object sender, MouseEventExtArgs e)
		{
			if (this.m_MouseClickExt != null)
			{
				this.m_MouseClickExt(this, e);
			}
		}
		private event KeyPressEventHandler m_KeyPress;
		public event KeyPressEventHandler KeyPress
		{
			add
			{
				if (this.m_KeyPress == null)
				{
					HookManager.KeyPress += this.HookManager_KeyPress;
				}
				this.m_KeyPress += value;
			}
			remove
			{
				this.m_KeyPress -= value;
				if (this.m_KeyPress == null)
				{
					HookManager.KeyPress -= this.HookManager_KeyPress;
				}
			}
		}
		private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.m_KeyPress != null)
			{
				this.m_KeyPress(this, e);
			}
		}
		private event KeyEventHandler m_KeyUp;
		public event KeyEventHandler KeyUp
		{
			add
			{
				if (this.m_KeyUp == null)
				{
					HookManager.KeyUp += this.HookManager_KeyUp;
				}
				this.m_KeyUp += value;
			}
			remove
			{
				this.m_KeyUp -= value;
				if (this.m_KeyUp == null)
				{
					HookManager.KeyUp -= this.HookManager_KeyUp;
				}
			}
		}
		private void HookManager_KeyUp(object sender, KeyEventArgs e)
		{
			if (this.m_KeyUp != null)
			{
				this.m_KeyUp(this, e);
			}
		}
		private event KeyEventHandler m_KeyDown;
		public event KeyEventHandler KeyDown
		{
			add
			{
				if (this.m_KeyDown == null)
				{
					HookManager.KeyDown += this.HookManager_KeyDown;
				}
				this.m_KeyDown += value;
			}
			remove
			{
				this.m_KeyDown -= value;
				if (this.m_KeyDown == null)
				{
					HookManager.KeyDown -= this.HookManager_KeyDown;
				}
			}
		}
		private void HookManager_KeyDown(object sender, KeyEventArgs e)
		{
			this.m_KeyDown(this, e);
		}
	}
}
