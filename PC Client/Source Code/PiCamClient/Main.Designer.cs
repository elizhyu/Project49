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
            this.Button_Sync = new System.Windows.Forms.Button();
            this.Button_Clear_Playback2 = new System.Windows.Forms.Button();
            this.Button_Clear_Playback1 = new System.Windows.Forms.Button();
            this.Button_Browse2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_duration2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.File_Transfer_Status_Label = new System.Windows.Forms.Label();
            this.Connect_Status_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Time_Left_Label = new System.Windows.Forms.Label();
            this.Bat_Lvl_Label = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Transfer_Progress_List = new System.Windows.Forms.ListView();
            this.Record_Status_Label = new System.Windows.Forms.Label();
            this.Bat_Warn_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Transfer
            // 
            this.Button_Transfer.Location = new System.Drawing.Point(187, 46);
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
            this.PiCam_List.Location = new System.Drawing.Point(27, 19);
            this.PiCam_List.Name = "PiCam_List";
            this.PiCam_List.Size = new System.Drawing.Size(154, 21);
            this.PiCam_List.TabIndex = 0;
            this.PiCam_List.SelectedIndexChanged += new System.EventHandler(this.PiCam_List_SelectedIndexChanged);
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(187, 18);
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
            this.Button_Record.Location = new System.Drawing.Point(107, 46);
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
            this.Button_Test.Location = new System.Drawing.Point(27, 46);
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
            this.Button_Disconnect.Location = new System.Drawing.Point(268, 19);
            this.Button_Disconnect.Name = "Button_Disconnect";
            this.Button_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Button_Disconnect.TabIndex = 12;
            this.Button_Disconnect.Text = "Disconnect";
            this.Button_Disconnect.UseVisualStyleBackColor = true;
            this.Button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect_Click);
            // 
            // Button_Setting
            // 
            this.Button_Setting.Location = new System.Drawing.Point(268, 46);
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
            this.Button_Browse1.Location = new System.Drawing.Point(27, 19);
            this.Button_Browse1.Name = "Button_Browse1";
            this.Button_Browse1.Size = new System.Drawing.Size(154, 23);
            this.Button_Browse1.TabIndex = 14;
            this.Button_Browse1.Text = "Playback #1 Browse";
            this.Button_Browse1.UseVisualStyleBackColor = true;
            this.Button_Browse1.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // Media_Player_Timer
            // 
            this.Media_Player_Timer.Enabled = true;
            this.Media_Player_Timer.Interval = 200;
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
            this.groupBox1.Size = new System.Drawing.Size(380, 80);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 568);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 111);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playback Control";
            // 
            // Button_Sync
            // 
            this.Button_Sync.Location = new System.Drawing.Point(107, 77);
            this.Button_Sync.Name = "Button_Sync";
            this.Button_Sync.Size = new System.Drawing.Size(155, 23);
            this.Button_Sync.TabIndex = 18;
            this.Button_Sync.Text = "Sync Playback";
            this.Button_Sync.UseVisualStyleBackColor = true;
            this.Button_Sync.Click += new System.EventHandler(this.Button_Sync_Click);
            // 
            // Button_Clear_Playback2
            // 
            this.Button_Clear_Playback2.Location = new System.Drawing.Point(187, 48);
            this.Button_Clear_Playback2.Name = "Button_Clear_Playback2";
            this.Button_Clear_Playback2.Size = new System.Drawing.Size(154, 23);
            this.Button_Clear_Playback2.TabIndex = 17;
            this.Button_Clear_Playback2.Text = "Clear Playback #2";
            this.Button_Clear_Playback2.UseVisualStyleBackColor = true;
            this.Button_Clear_Playback2.Click += new System.EventHandler(this.Button_Clear_Playback2_Click);
            // 
            // Button_Clear_Playback1
            // 
            this.Button_Clear_Playback1.Location = new System.Drawing.Point(27, 48);
            this.Button_Clear_Playback1.Name = "Button_Clear_Playback1";
            this.Button_Clear_Playback1.Size = new System.Drawing.Size(154, 23);
            this.Button_Clear_Playback1.TabIndex = 16;
            this.Button_Clear_Playback1.Text = "Clear Playback #1";
            this.Button_Clear_Playback1.UseVisualStyleBackColor = true;
            this.Button_Clear_Playback1.Click += new System.EventHandler(this.Button_Clear_Playback1_Click);
            // 
            // Button_Browse2
            // 
            this.Button_Browse2.Location = new System.Drawing.Point(187, 19);
            this.Button_Browse2.Name = "Button_Browse2";
            this.Button_Browse2.Size = new System.Drawing.Size(155, 23);
            this.Button_Browse2.TabIndex = 15;
            this.Button_Browse2.Text = "Playback #2 Browse";
            this.Button_Browse2.UseVisualStyleBackColor = true;
            this.Button_Browse2.Click += new System.EventHandler(this.Button_Browse2_Click);
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
            // label_duration2
            // 
            this.label_duration2.AutoSize = true;
            this.label_duration2.Location = new System.Drawing.Point(1348, 453);
            this.label_duration2.Name = "label_duration2";
            this.label_duration2.Size = new System.Drawing.Size(72, 13);
            this.label_duration2.TabIndex = 21;
            this.label_duration2.Text = "00:00 / 00:00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Bat_Warn_Label);
            this.groupBox4.Controls.Add(this.Record_Status_Label);
            this.groupBox4.Controls.Add(this.File_Transfer_Status_Label);
            this.groupBox4.Controls.Add(this.Connect_Status_Label);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.Time_Left_Label);
            this.groupBox4.Controls.Add(this.Bat_Lvl_Label);
            this.groupBox4.Location = new System.Drawing.Point(12, 685);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 82);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status Monitor";
            // 
            // File_Transfer_Status_Label
            // 
            this.File_Transfer_Status_Label.AutoSize = true;
            this.File_Transfer_Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_Transfer_Status_Label.ForeColor = System.Drawing.Color.Red;
            this.File_Transfer_Status_Label.Location = new System.Drawing.Point(287, 38);
            this.File_Transfer_Status_Label.Name = "File_Transfer_Status_Label";
            this.File_Transfer_Status_Label.Size = new System.Drawing.Size(35, 13);
            this.File_Transfer_Status_Label.TabIndex = 8;
            this.File_Transfer_Status_Label.Text = "Down";
            // 
            // Connect_Status_Label
            // 
            this.Connect_Status_Label.AutoSize = true;
            this.Connect_Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_Status_Label.ForeColor = System.Drawing.Color.Red;
            this.Connect_Status_Label.Location = new System.Drawing.Point(287, 16);
            this.Connect_Status_Label.Name = "Connect_Status_Label";
            this.Connect_Status_Label.Size = new System.Drawing.Size(73, 13);
            this.Connect_Status_Label.TabIndex = 7;
            this.Connect_Status_Label.Text = "Disconnected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Recording Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "File Transfer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Connection Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Left:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Battery Level:";
            // 
            // Time_Left_Label
            // 
            this.Time_Left_Label.AutoSize = true;
            this.Time_Left_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Left_Label.ForeColor = System.Drawing.Color.Red;
            this.Time_Left_Label.Location = new System.Drawing.Point(104, 60);
            this.Time_Left_Label.Name = "Time_Left_Label";
            this.Time_Left_Label.Size = new System.Drawing.Size(63, 13);
            this.Time_Left_Label.TabIndex = 1;
            this.Time_Left_Label.Text = "Unavailable";
            // 
            // Bat_Lvl_Label
            // 
            this.Bat_Lvl_Label.AutoSize = true;
            this.Bat_Lvl_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bat_Lvl_Label.ForeColor = System.Drawing.Color.Red;
            this.Bat_Lvl_Label.Location = new System.Drawing.Point(104, 25);
            this.Bat_Lvl_Label.Name = "Bat_Lvl_Label";
            this.Bat_Lvl_Label.Size = new System.Drawing.Size(63, 13);
            this.Bat_Lvl_Label.TabIndex = 0;
            this.Bat_Lvl_Label.Text = "Unavailable";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Transfer_Progress_List);
            this.groupBox5.Location = new System.Drawing.Point(398, 482);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 285);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "File Transfer Stream Monitor";
            // 
            // Transfer_Progress_List
            // 
            this.Transfer_Progress_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Transfer_Progress_List.Location = new System.Drawing.Point(7, 18);
            this.Transfer_Progress_List.Name = "Transfer_Progress_List";
            this.Transfer_Progress_List.Size = new System.Drawing.Size(312, 261);
            this.Transfer_Progress_List.TabIndex = 7;
            this.Transfer_Progress_List.UseCompatibleStateImageBehavior = false;
            // 
            // Record_Status_Label
            // 
            this.Record_Status_Label.AutoSize = true;
            this.Record_Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record_Status_Label.ForeColor = System.Drawing.Color.Red;
            this.Record_Status_Label.Location = new System.Drawing.Point(287, 60);
            this.Record_Status_Label.Name = "Record_Status_Label";
            this.Record_Status_Label.Size = new System.Drawing.Size(47, 13);
            this.Record_Status_Label.TabIndex = 9;
            this.Record_Status_Label.Text = "Stopped";
            // 
            // Bat_Warn_Label
            // 
            this.Bat_Warn_Label.AutoSize = true;
            this.Bat_Warn_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bat_Warn_Label.ForeColor = System.Drawing.Color.Red;
            this.Bat_Warn_Label.Location = new System.Drawing.Point(104, 42);
            this.Bat_Warn_Label.Name = "Bat_Warn_Label";
            this.Bat_Warn_Label.Size = new System.Drawing.Size(16, 13);
            this.Bat_Warn_Label.TabIndex = 10;
            this.Bat_Warn_Label.Text = "   ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 779);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label_duration2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Player_2);
            this.Controls.Add(this.label_duration);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Transfer;
        private AxWMPLib.AxWindowsMediaPlayer Player_1;
        private System.Windows.Forms.ComboBox PiCam_List;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView Transfer_Progress_List;
        private System.Windows.Forms.Label Time_Left_Label;
        private System.Windows.Forms.Label Bat_Lvl_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label File_Transfer_Status_Label;
        private System.Windows.Forms.Label Connect_Status_Label;
        private System.Windows.Forms.Label Record_Status_Label;
        private System.Windows.Forms.Label Bat_Warn_Label;
    }
}

