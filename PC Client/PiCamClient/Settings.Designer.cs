namespace PiCamClient
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_hostname = new System.Windows.Forms.TextBox();
            this.text_username = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_host = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.Device_Select = new System.Windows.Forms.ComboBox();
            this.label_Device = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.Check_Visibility_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(80, 49);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 20);
            this.text_name.TabIndex = 0;
            this.text_name.TextChanged += new System.EventHandler(this.text_name_TextChanged);
            // 
            // text_hostname
            // 
            this.text_hostname.Location = new System.Drawing.Point(80, 75);
            this.text_hostname.Name = "text_hostname";
            this.text_hostname.Size = new System.Drawing.Size(100, 20);
            this.text_hostname.TabIndex = 1;
            this.text_hostname.TextChanged += new System.EventHandler(this.text_hostname_TextChanged);
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(80, 101);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(100, 20);
            this.text_username.TabIndex = 2;
            this.text_username.TextChanged += new System.EventHandler(this.text_username_TextChanged);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(80, 127);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(100, 20);
            this.text_password.TabIndex = 3;
            this.text_password.TextChanged += new System.EventHandler(this.text_password_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(36, 52);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Name:";
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Location = new System.Drawing.Point(14, 78);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(60, 13);
            this.label_host.TabIndex = 6;
            this.label_host.Text = "HostName:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(14, 104);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(60, 13);
            this.label_username.TabIndex = 7;
            this.label_username.Text = "UserName:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(18, 130);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 8;
            this.label_password.Text = "Password:";
            // 
            // Device_Select
            // 
            this.Device_Select.FormattingEnabled = true;
            this.Device_Select.Location = new System.Drawing.Point(80, 16);
            this.Device_Select.Margin = new System.Windows.Forms.Padding(2);
            this.Device_Select.Name = "Device_Select";
            this.Device_Select.Size = new System.Drawing.Size(100, 21);
            this.Device_Select.TabIndex = 10;
            this.Device_Select.SelectedIndexChanged += new System.EventHandler(this.Device_Select_SelectedIndexChanged);
            // 
            // label_Device
            // 
            this.label_Device.AutoSize = true;
            this.label_Device.Location = new System.Drawing.Point(0, 19);
            this.label_Device.Name = "label_Device";
            this.label_Device.Size = new System.Drawing.Size(74, 13);
            this.label_Device.TabIndex = 11;
            this.label_Device.Text = "Select Device";
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(3, 157);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(86, 23);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "Save Changes";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(95, 157);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(85, 23);
            this.button_exit.TabIndex = 13;
            this.button_exit.Text = "Save and Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Check_Visibility_Timer
            // 
            this.Check_Visibility_Timer.Enabled = true;
            this.Check_Visibility_Timer.Interval = 500;
            this.Check_Visibility_Timer.Tick += new System.EventHandler(this.Check_Visibility_Timer_Tick);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 192);
            this.ControlBox = false;
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_Device);
            this.Controls.Add(this.Device_Select);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_host);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.text_hostname);
            this.Controls.Add(this.text_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_hostname;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.ComboBox Device_Select;
        private System.Windows.Forms.Label label_Device;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Timer Check_Visibility_Timer;
    }
}