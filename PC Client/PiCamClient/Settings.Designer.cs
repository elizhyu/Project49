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
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_hostname = new System.Windows.Forms.TextBox();
            this.text_username = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.text_fingerprint = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_host = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_fingerprint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(118, 79);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 20);
            this.text_name.TabIndex = 0;
            // 
            // text_hostname
            // 
            this.text_hostname.Location = new System.Drawing.Point(118, 105);
            this.text_hostname.Name = "text_hostname";
            this.text_hostname.Size = new System.Drawing.Size(100, 20);
            this.text_hostname.TabIndex = 1;
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(118, 131);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(100, 20);
            this.text_username.TabIndex = 2;
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(118, 157);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(100, 20);
            this.text_password.TabIndex = 3;
            // 
            // text_fingerprint
            // 
            this.text_fingerprint.Location = new System.Drawing.Point(118, 183);
            this.text_fingerprint.Name = "text_fingerprint";
            this.text_fingerprint.Size = new System.Drawing.Size(100, 20);
            this.text_fingerprint.TabIndex = 4;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(74, 82);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Name:";
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Location = new System.Drawing.Point(52, 108);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(60, 13);
            this.label_host.TabIndex = 6;
            this.label_host.Text = "HostName:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(52, 134);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(60, 13);
            this.label_username.TabIndex = 7;
            this.label_username.Text = "UserName:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(56, 160);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 8;
            this.label_password.Text = "Password:";
            // 
            // label_fingerprint
            // 
            this.label_fingerprint.AutoSize = true;
            this.label_fingerprint.Location = new System.Drawing.Point(53, 186);
            this.label_fingerprint.Name = "label_fingerprint";
            this.label_fingerprint.Size = new System.Drawing.Size(59, 13);
            this.label_fingerprint.TabIndex = 9;
            this.label_fingerprint.Text = "Fingerprint:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_fingerprint);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_host);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.text_fingerprint);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.text_hostname);
            this.Controls.Add(this.text_name);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_hostname;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox text_fingerprint;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_fingerprint;
    }
}