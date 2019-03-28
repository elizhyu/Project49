namespace PiCamClient
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Button_Transfer = new System.Windows.Forms.Button();
            this.PiCam_List = new System.Windows.Forms.ComboBox();
            this.Transfer_Progress_List = new System.Windows.Forms.ListView();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.Status_Refresh_Timer = new System.Windows.Forms.Timer(this.components);
            this.Button_Record = new System.Windows.Forms.Button();
            this.Player_1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Button_Test = new System.Windows.Forms.Button();
            this.Button_Disconnect = new System.Windows.Forms.Button();
            this.Button_Setting = new System.Windows.Forms.Button();
            this.Device_List_Refresh_Timer = new System.Windows.Forms.Timer(this.components);
            this.Record_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.Button_Browse1 = new System.Windows.Forms.Button();
            this.Media_Player_Timer = new System.Windows.Forms.Timer(this.components);
            this.label_duration = new System.Windows.Forms.Label();
            this.Config_File_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.Player_2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Browse2 = new System.Windows.Forms.Button();
            this.label_duration2 = new System.Windows.Forms.Label();
            this.Button_Clear_Playback1 = new System.Windows.Forms.Button();
            this.Button_Clear_Playback2 = new System.Windows.Forms.Button();
            this.Button_Sync = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Transfer
            // 
            this.Button_Transfer.Location = new System.Drawing.Point(189, 78);
            this.Button_Transfer.Name = "Button_Transfer";
            this.Button_Transfer.Size = new System.Drawing.Size(75, 23);
            this.Button_Transfer.TabIndex = 1;
            this.Button_Transfer.Text = "Transfer";
            this.Button_Transfer.UseVisualStyleBackColor = true;
            this.Button_Transfer.Click += new System.EventHandler(this.Button_Transfer_Click);
            // 
            // PiCam_List
            // 
            this.PiCam_List.FormattingEnabled = true;
            this.PiCam_List.Location = new System.Drawing.Point(29, 42);
            this.PiCam_List.Name = "PiCam_List";
            this.PiCam_List.Size = new System.Drawing.Size(154, 21);
            this.PiCam_List.TabIndex = 0;
            this.PiCam_List.SelectedIndexChanged += new System.EventHandler(this.PiCam_List_SelectedIndexChanged);
            // 
            // Transfer_Progress_List
            // 
            this.Transfer_Progress_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Transfer_Progress_List.Location = new System.Drawing.Point(398, 482);
            this.Transfer_Progress_List.Name = "Transfer_Progress_List";
            this.Transfer_Progress_List.Size = new System.Drawing.Size(325, 285);
            this.Transfer_Progress_List.TabIndex = 6;
            this.Transfer_Progress_List.UseCompatibleStateImageBehavior = false;
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(189, 42);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(75, 23);
            this.Button_Connect.TabIndex = 7;
            this.Button_Connect.Text = "Connect";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // Status_Refresh_Timer
            // 
            this.Status_Refresh_Timer.Enabled = true;
            this.Status_Refresh_Timer.Interval = 300;
            this.Status_Refresh_Timer.Tick += new System.EventHandler(this.Status_Refresh_Timer_Tick);
            // 
            // Button_Record
            // 
            this.Button_Record.Location = new System.Drawing.Point(109, 78);
            this.Button_Record.Name = "Button_Record";
            this.Button_Record.Size = new System.Drawing.Size(74, 22);
            this.Button_Record.TabIndex = 10;
            this.Button_Record.Text = "Record";
            this.Button_Record.UseVisualStyleBackColor = true;
            this.Button_Record.Click += new System.EventHandler(this.Button_Record_Click);
            // 
            // Player_1
            // 
            this.Player_1.Enabled = true;
            this.Player_1.Location = new System.Drawing.Point(12, 10);
            this.Player_1.Name = "Player_1";
            this.Player_1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player_1.OcxState")));
            this.Player_1.Size = new System.Drawing.Size(711, 466);
            this.Player_1.TabIndex = 3;
            this.Player_1.TabStop = false;
            // 
            // Button_Test
            // 
            this.Button_Test.Location = new System.Drawing.Point(29, 79);
            this.Button_Test.Name = "Button_Test";
            this.Button_Test.Size = new System.Drawing.Size(74, 22);
            this.Button_Test.TabIndex = 11;
            this.Button_Test.Text = "Test";
            this.Button_Test.UseVisualStyleBackColor = true;
            this.Button_Test.Click += new System.EventHandler(this.Button_Test_Click);
            // 
            // Button_Disconnect
            // 
            this.Button_Disconnect.Enabled = false;
            this.Button_Disconnect.Location = new System.Drawing.Point(270, 42);
            this.Button_Disconnect.Name = "Button_Disconnect";
            this.Button_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Button_Disconnect.TabIndex = 12;
            this.Button_Disconnect.Text = "Disconnect";
            this.Button_Disconnect.UseVisualStyleBackColor = true;
            this.Button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect_Click);
            // 
            // Button_Setting
            // 
            this.Button_Setting.Location = new System.Drawing.Point(270, 78);
            this.Button_Setting.Name = "Button_Setting";
            this.Button_Setting.Size = new System.Drawing.Size(75, 23);
            this.Button_Setting.TabIndex = 13;
            this.Button_Setting.Text = "Setting";
            this.Button_Setting.UseVisualStyleBackColor = true;
            this.Button_Setting.Click += new System.EventHandler(this.Button_Setting_Click);
            // 
            // Device_List_Refresh_Timer
            // 
            this.Device_List_Refresh_Timer.Enabled = true;
            this.Device_List_Refresh_Timer.Tick += new System.EventHandler(this.Device_List_Refresh_Timer_Tick);
            // 
            // Record_Dialog
            // 
            this.Record_Dialog.FileName = "openFileDialog1";
            // 
            // Button_Browse1
            // 
            this.Button_Browse1.Location = new System.Drawing.Point(29, 31);
            this.Button_Browse1.Name = "Button_Browse1";
            this.Button_Browse1.Size = new System.Drawing.Size(155, 23);
            this.Button_Browse1.TabIndex = 14;
            this.Button_Browse1.Text = "Playback #1 Browse";
            this.Button_Browse1.UseVisualStyleBackColor = true;
            this.Button_Browse1.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // Media_Player_Timer
            // 
            this.Media_Player_Timer.Enabled = true;
            this.Media_Player_Timer.Interval = 500;
            this.Media_Player_Timer.Tick += new System.EventHandler(this.Media_Player_Timer_Tick);
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.Location = new System.Drawing.Point(638, 453);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(72, 13);
            this.label_duration.TabIndex = 16;
            this.label_duration.Text = "00:00 / 00:00";
            // 
            // Config_File_Dialog
            // 
            this.Config_File_Dialog.FileName = "PiCam Recording File";
            // 
            // Player_2
            // 
            this.Player_2.Enabled = true;
            this.Player_2.Location = new System.Drawing.Point(729, 10);
            this.Player_2.Name = "Player_2";
            this.Player_2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player_2.OcxState")));
            this.Player_2.Size = new System.Drawing.Size(711, 466);
            this.Player_2.TabIndex = 17;
            this.Player_2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Setting);
            this.groupBox1.Controls.Add(this.Button_Disconnect);
            this.groupBox1.Controls.Add(this.Button_Transfer);
            this.groupBox1.Controls.Add(this.Button_Test);
            this.groupBox1.Controls.Add(this.PiCam_List);
            this.groupBox1.Controls.Add(this.Button_Connect);
            this.groupBox1.Controls.Add(this.Button_Record);
            this.groupBox1.Location = new System.Drawing.Point(12, 482);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 126);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remote Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_Sync);
            this.groupBox2.Controls.Add(this.Button_Clear_Playback2);
            this.groupBox2.Controls.Add(this.Button_Clear_Playback1);
            this.groupBox2.Controls.Add(this.Button_Browse2);
            this.groupBox2.Controls.Add(this.Button_Browse1);
            this.groupBox2.Location = new System.Drawing.Point(12, 614);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 153);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playback Control";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(729, 482);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 285);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor Data Monitor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 259);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Browse2
            // 
            this.Button_Browse2.Location = new System.Drawing.Point(190, 31);
            this.Button_Browse2.Name = "Button_Browse2";
            this.Button_Browse2.Size = new System.Drawing.Size(155, 23);
            this.Button_Browse2.TabIndex = 15;
            this.Button_Browse2.Text = "Playback #2 Browse";
            this.Button_Browse2.UseVisualStyleBackColor = true;
            this.Button_Browse2.Click += new System.EventHandler(this.Button_Browse2_Click);
            // 
            // label_duration2
            // 
            this.label_duration2.AutoSize = true;
            this.label_duration2.Location = new System.Drawing.Point(1348, 453);
            this.label_duration2.Name = "label_duration2";
            this.label_duration2.Size = new System.Drawing.Size(72, 13);
            this.label_duration2.TabIndex = 21;
            this.label_duration2.Text = "00:00 / 00:00";
            // 
            // Button_Clear_Playback1
            // 
            this.Button_Clear_Playback1.Location = new System.Drawing.Point(29, 71);
            this.Button_Clear_Playback1.Name = "Button_Clear_Playback1";
            this.Button_Clear_Playback1.Size = new System.Drawing.Size(154, 23);
            this.Button_Clear_Playback1.TabIndex = 16;
            this.Button_Clear_Playback1.Text = "Clear Playback #1";
            this.Button_Clear_Playback1.UseVisualStyleBackColor = true;
            this.Button_Clear_Playback1.Click += new System.EventHandler(this.Button_Clear_Playback1_Click);
            // 
            // Button_Clear_Playback2
            // 
            this.Button_Clear_Playback2.Location = new System.Drawing.Point(189, 71);
            this.Button_Clear_Playback2.Name = "Button_Clear_Playback2";
            this.Button_Clear_Playback2.Size = new System.Drawing.Size(154, 23);
            this.Button_Clear_Playback2.TabIndex = 17;
            this.Button_Clear_Playback2.Text = "Clear Playback #2";
            this.Button_Clear_Playback2.UseVisualStyleBackColor = true;
            this.Button_Clear_Playback2.Click += new System.EventHandler(this.Button_Clear_Playback2_Click);
            // 
            // Button_Sync
            // 
            this.Button_Sync.Location = new System.Drawing.Point(109, 113);
            this.Button_Sync.Name = "Button_Sync";
            this.Button_Sync.Size = new System.Drawing.Size(155, 23);
            this.Button_Sync.TabIndex = 18;
            this.Button_Sync.Text = "Sync Playback";
            this.Button_Sync.UseVisualStyleBackColor = true;
            this.Button_Sync.Click += new System.EventHandler(this.Button_Sync_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 779);
            this.Controls.Add(this.label_duration2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Player_2);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.Transfer_Progress_List);
            this.Controls.Add(this.Player_1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PiCam PC Client";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Player_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Transfer;
        private AxWMPLib.AxWindowsMediaPlayer Player_1;
        private System.Windows.Forms.ComboBox PiCam_List;
        private System.Windows.Forms.ListView Transfer_Progress_List;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.Timer Status_Refresh_Timer;
        private System.Windows.Forms.Button Button_Record;
        private System.Windows.Forms.Button Button_Test;
        private System.Windows.Forms.Button Button_Disconnect;
        private System.Windows.Forms.Button Button_Setting;
        private System.Windows.Forms.Timer Device_List_Refresh_Timer;
        private System.Windows.Forms.OpenFileDialog Record_Dialog;
        private System.Windows.Forms.Button Button_Browse1;
        private System.Windows.Forms.Timer Media_Player_Timer;
        private System.Windows.Forms.Label label_duration;
        private System.Windows.Forms.OpenFileDialog Config_File_Dialog;
        private AxWMPLib.AxWindowsMediaPlayer Player_2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Browse2;
        private System.Windows.Forms.Label label_duration2;
        private System.Windows.Forms.Button Button_Clear_Playback1;
        private System.Windows.Forms.Button Button_Clear_Playback2;
        private System.Windows.Forms.Button Button_Sync;
    }
}

