using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Diagnostics;

using System.Threading;

namespace serial_control {
	public partial class MainApp : Form {
		private SerialPort _SerialConnection;

		private string _SerialPort = "";
		private string _BaudRate = "";
		private string _AngleValue = "";

		private const int WH_KEYBOARD_LL = 13;
		private const int WM_KEYDOWN = 0x0100;
		private LowLevelKeyboardProc _proc;
		private IntPtr _hookID = IntPtr.Zero;

		public MainApp() {
			InitializeComponent();

			_Init();
		}

		private void _Init() {
			// App Thread is On.
			Thread AppBackgroungThread = new Thread(new ThreadStart(BackgroundThread));

			AppBackgroungThread.Start();
			_Init_Menus();
			_Init_Controls();

			_Init_KeyHook();
		}

		private void _Init_Menus() {
			MenuStrip_Set_BaudRate.DropDownItems.Clear();

			for (int i = 2400; i <= 38400; i *= 2) {
				ToolStripMenuItem _item = new ToolStripMenuItem();

				_item.Name = i.ToString();
				_item.Text = i.ToString();
				_item.Click += _BaudRate_item_Click;
				if (i.ToString() == "9600" && _BaudRate == "") {
					_item.Checked = true;
					_BaudRate = "9600";
				}
				MenuStrip_Set_BaudRate.DropDownItems.Add(_item);
			}
			for (int i = 57600; i <= 921600; i *= 2) {
				ToolStripMenuItem _item = new ToolStripMenuItem();

				_item.Name = i.ToString();
				_item.Text = i.ToString();
				_item.Click += _BaudRate_item_Click;
				MenuStrip_Set_BaudRate.DropDownItems.Add(_item);
			}

			BaudRateStatus.Text = _BaudRate;

			_Scanning_COM_Port();
		}

		private void _Init_Controls() {
			TextInputMode.Checked = true;
		}

		private void _Init_KeyHook() {
			_proc = HookCallback;
			_hookID = SetHook(_proc);
			
		}

		#region hook area
		private IntPtr SetHook(LowLevelKeyboardProc proc) {
			using (Process curProcess = Process.GetCurrentProcess())
			using (ProcessModule curModule = curProcess.MainModule) {
				return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
						GetModuleHandle(curModule.ModuleName), 0);
			}
		}

		private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

		private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
			if (TextInputMode.Checked == false) {
				if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN) {
					int vkCode = Marshal.ReadInt32(lParam);

					//Console.WriteLine((Keys)vkCode);
				}
			}
			

			return CallNextHookEx(_hookID, nCode, wParam, lParam);
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);
		#endregion

		private void BackgroundThread() {

		}

		private void _Scanning_COM_Port() {
			MenuStrip_Set_SerialPort.DropDownItems.Clear();

			foreach (string name in System.IO.Ports.SerialPort.GetPortNames()) {
				ToolStripMenuItem _item = new ToolStripMenuItem();

				_item.Name = name.ToString();
				_item.Text = name.ToString();
				_item.Click += _Port_item_Click;
				MenuStrip_Set_SerialPort.DropDownItems.Add(_item);
			}

		}

		void _Port_item_Click(object sender, EventArgs e) {
			ToolStripMenuItem _TT = (ToolStripMenuItem)sender;
			if (_SerialPort != "")
				((ToolStripMenuItem)((ToolStripMenuItem)_TT.OwnerItem).DropDownItems[_SerialPort]).Checked = false;
			_SerialPort = _TT.Name;
			_TT.Checked = true;

			PortStatus.Text = _SerialPort;
		}

		private void MenuStrip_Set_SerialPort_DropDownOpening(object sender, EventArgs e) {
			_Scanning_COM_Port();
		}

		private void _BaudRate_item_Click(object sender, EventArgs e) {
			ToolStripMenuItem _TT = (ToolStripMenuItem)sender;
			((ToolStripMenuItem)((ToolStripMenuItem)_TT.OwnerItem).DropDownItems[_BaudRate]).Checked = false;
			_BaudRate = _TT.Name;
			_TT.Checked = true;
			BaudRateStatus.Text = _BaudRate;
		}

		private void MenuStrip_Set_BaudRate_DropDownOpening(object sender, EventArgs e) {
			
			
		}

		private void TextInputMode_CheckedChanged(object sender, EventArgs e) {
			CheckBox _Cb = (CheckBox)sender;
			if (_Cb.Checked == true)
				TextInput.ReadOnly = false;
			else
				TextInput.ReadOnly = true;
		}

		private void TextInput_KeyPress(object sender, KeyPressEventArgs e) {
			if (TextInput.ReadOnly == false) {
				TextBox _Tb = (TextBox)sender;
				ResultOut.Text = _Tb.Text.ToString();
			}
		}

		private void MenuStrip_File_Exit_Click(object sender, EventArgs e) {
			UnhookWindowsHookEx(_hookID);
			_proc -= HookCallback;
			Close();
			GC.SuppressFinalize(this);
		}
	}
}
