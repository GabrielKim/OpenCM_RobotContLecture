namespace serial_control {
	partial class MainApp {
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent() {
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.MenuStrip_File = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip_Set = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip_Set_SerialPort = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip_Set_Key = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.SerialConnStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.ImputModeStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.Group_Output = new System.Windows.Forms.GroupBox();
			this.ResultOut = new System.Windows.Forms.TextBox();
			this.Group_Input = new System.Windows.Forms.GroupBox();
			this.TextInputMode = new System.Windows.Forms.CheckBox();
			this.TextInput = new System.Windows.Forms.TextBox();
			this.MenuStrip_Set_BaudRate = new System.Windows.Forms.ToolStripMenuItem();
			this.PortStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.BaudRateStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.MenuStrip.SuspendLayout();
			this.StatusStrip.SuspendLayout();
			this.Group_Output.SuspendLayout();
			this.Group_Input.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuStrip
			// 
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_File,
            this.MenuStrip_Set});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(483, 24);
			this.MenuStrip.TabIndex = 0;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// MenuStrip_File
			// 
			this.MenuStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_File_Exit});
			this.MenuStrip_File.Name = "MenuStrip_File";
			this.MenuStrip_File.Size = new System.Drawing.Size(37, 20);
			this.MenuStrip_File.Text = "File";
			// 
			// MenuStrip_File_Exit
			// 
			this.MenuStrip_File_Exit.Name = "MenuStrip_File_Exit";
			this.MenuStrip_File_Exit.Size = new System.Drawing.Size(152, 22);
			this.MenuStrip_File_Exit.Text = "Exit";
			this.MenuStrip_File_Exit.Click += new System.EventHandler(this.MenuStrip_File_Exit_Click);
			// 
			// MenuStrip_Set
			// 
			this.MenuStrip_Set.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_Set_SerialPort,
            this.MenuStrip_Set_BaudRate,
            this.MenuStrip_Set_Key});
			this.MenuStrip_Set.Name = "MenuStrip_Set";
			this.MenuStrip_Set.Size = new System.Drawing.Size(36, 20);
			this.MenuStrip_Set.Text = "Set";
			// 
			// MenuStrip_Set_SerialPort
			// 
			this.MenuStrip_Set_SerialPort.Name = "MenuStrip_Set_SerialPort";
			this.MenuStrip_Set_SerialPort.Size = new System.Drawing.Size(152, 22);
			this.MenuStrip_Set_SerialPort.Text = "Serial Port";
			this.MenuStrip_Set_SerialPort.DropDownOpening += new System.EventHandler(this.MenuStrip_Set_SerialPort_DropDownOpening);
			// 
			// MenuStrip_Set_Key
			// 
			this.MenuStrip_Set_Key.Name = "MenuStrip_Set_Key";
			this.MenuStrip_Set_Key.Size = new System.Drawing.Size(152, 22);
			this.MenuStrip_Set_Key.Text = "Key";
			// 
			// StatusStrip
			// 
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SerialConnStatus,
            this.ImputModeStatus,
            this.PortStatus,
            this.BaudRateStatus});
			this.StatusStrip.Location = new System.Drawing.Point(0, 188);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(483, 22);
			this.StatusStrip.TabIndex = 1;
			this.StatusStrip.Text = "statusStrip1";
			// 
			// SerialConnStatus
			// 
			this.SerialConnStatus.Name = "SerialConnStatus";
			this.SerialConnStatus.Size = new System.Drawing.Size(36, 17);
			this.SerialConnStatus.Text = "None";
			// 
			// ImputModeStatus
			// 
			this.ImputModeStatus.Name = "ImputModeStatus";
			this.ImputModeStatus.Size = new System.Drawing.Size(36, 17);
			this.ImputModeStatus.Text = "None";
			// 
			// Group_Output
			// 
			this.Group_Output.Controls.Add(this.ResultOut);
			this.Group_Output.Location = new System.Drawing.Point(0, 27);
			this.Group_Output.Name = "Group_Output";
			this.Group_Output.Size = new System.Drawing.Size(483, 100);
			this.Group_Output.TabIndex = 3;
			this.Group_Output.TabStop = false;
			this.Group_Output.Text = "Output";
			// 
			// ResultOut
			// 
			this.ResultOut.Location = new System.Drawing.Point(0, 20);
			this.ResultOut.Multiline = true;
			this.ResultOut.Name = "ResultOut";
			this.ResultOut.ReadOnly = true;
			this.ResultOut.Size = new System.Drawing.Size(483, 74);
			this.ResultOut.TabIndex = 0;
			// 
			// Group_Input
			// 
			this.Group_Input.Controls.Add(this.TextInputMode);
			this.Group_Input.Controls.Add(this.TextInput);
			this.Group_Input.Location = new System.Drawing.Point(0, 127);
			this.Group_Input.Name = "Group_Input";
			this.Group_Input.Size = new System.Drawing.Size(483, 61);
			this.Group_Input.TabIndex = 4;
			this.Group_Input.TabStop = false;
			this.Group_Input.Text = "Input";
			// 
			// TextInputMode
			// 
			this.TextInputMode.AutoSize = true;
			this.TextInputMode.Location = new System.Drawing.Point(403, 44);
			this.TextInputMode.Name = "TextInputMode";
			this.TextInputMode.Size = new System.Drawing.Size(80, 16);
			this.TextInputMode.TabIndex = 1;
			this.TextInputMode.Text = "Text Input";
			this.TextInputMode.UseVisualStyleBackColor = true;
			this.TextInputMode.CheckedChanged += new System.EventHandler(this.TextInputMode_CheckedChanged);
			// 
			// TextInput
			// 
			this.TextInput.Location = new System.Drawing.Point(0, 20);
			this.TextInput.Name = "TextInput";
			this.TextInput.Size = new System.Drawing.Size(483, 21);
			this.TextInput.TabIndex = 0;
			this.TextInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextInput_KeyPress);
			// 
			// MenuStrip_Set_BaudRate
			// 
			this.MenuStrip_Set_BaudRate.Name = "MenuStrip_Set_BaudRate";
			this.MenuStrip_Set_BaudRate.Size = new System.Drawing.Size(152, 22);
			this.MenuStrip_Set_BaudRate.Text = "Baud Rate";
			this.MenuStrip_Set_BaudRate.DropDownOpening += new System.EventHandler(this.MenuStrip_Set_BaudRate_DropDownOpening);
			// 
			// PortStatus
			// 
			this.PortStatus.Name = "PortStatus";
			this.PortStatus.Size = new System.Drawing.Size(36, 17);
			this.PortStatus.Text = "None";
			// 
			// BaudRateStatus
			// 
			this.BaudRateStatus.Name = "BaudRateStatus";
			this.BaudRateStatus.Size = new System.Drawing.Size(36, 17);
			this.BaudRateStatus.Text = "None";
			// 
			// MainApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 210);
			this.Controls.Add(this.Group_Input);
			this.Controls.Add(this.Group_Output);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "MainApp";
			this.Text = "Serial Control";
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.Group_Output.ResumeLayout(false);
			this.Group_Output.PerformLayout();
			this.Group_Input.ResumeLayout(false);
			this.Group_Input.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem MenuStrip_File;
		private System.Windows.Forms.ToolStripMenuItem MenuStrip_File_Exit;
		private System.Windows.Forms.ToolStripMenuItem MenuStrip_Set;
		private System.Windows.Forms.ToolStripMenuItem MenuStrip_Set_SerialPort;
		private System.Windows.Forms.ToolStripMenuItem MenuStrip_Set_Key;
		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel SerialConnStatus;
		private System.Windows.Forms.GroupBox Group_Output;
		private System.Windows.Forms.TextBox ResultOut;
		private System.Windows.Forms.GroupBox Group_Input;
		private System.Windows.Forms.CheckBox TextInputMode;
		private System.Windows.Forms.TextBox TextInput;
		private System.Windows.Forms.ToolStripStatusLabel ImputModeStatus;
		private System.Windows.Forms.ToolStripMenuItem MenuStrip_Set_BaudRate;
		private System.Windows.Forms.ToolStripStatusLabel PortStatus;
		private System.Windows.Forms.ToolStripStatusLabel BaudRateStatus;
	}
}

