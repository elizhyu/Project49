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
            ((System.ComponentModel.ISupportInitialize)(this.Player_1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Transfer
            // 
            this.Button_Transfer.Location = new System.Drawing.Point(659, 39);
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
            this.PiCam_List.Items.AddRange(new object[] {
            "Eli_HA (Test Only)",
            "PiCam 1"});
            this.PiCam_List.Location = new System.Drawing.Point(418, 12);
            this.PiCam_List.Name = "PiCam_List";
            this.PiCam_List.Size = new System.Drawing.Size(154, 21);
            this.PiCam_List.TabIndex = 0;
            this.PiCam_List.SelectedIndexChanged += new System.EventHandler(this.PiCam_List_SelectedIndexChanged);
            // 
            // Transfer_Progress_List
            // 
            this.Transfer_Progress_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Transfer_Progress_List.Location = new System.Drawing.Point(418, 68);
            this.Transfer_Progress_List.Name = "Transfer_Progress_List";
            this.Transfer_Progress_List.Size = new System.Drawing.Size(316, 370);
            this.Transfer_Progress_List.TabIndex = 6;
            this.Transfer_Progress_List.UseCompatibleStateImageBehavior = false;
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(578, 10);
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
            this.Button_Record.Location = new System.Drawing.Point(578, 39);
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
            this.Player_1.Location = new System.Drawing.Point(12, 12);
            this.Player_1.Name = "Player_1";
            this.Player_1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player_1.OcxState")));
            this.Player_1.Size = new System.Drawing.Size(400, 225);
            this.Player_1.TabIndex = 3;
            this.Player_1.TabStop = false;
            this.Player_1.Enter += new System.EventHandler(this.Player_1_Enter);
            // 
            // Button_Test
            // 
            this.Button_Test.Location = new System.Drawing.Point(498, 39);
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
            this.Button_Disconnect.Location = new System.Drawing.Point(659, 10);
            this.Button_Disconnect.Name = "Button_Disconnect";
            this.Button_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Button_Disconnect.TabIndex = 12;
            this.Button_Disconnect.Text = "Disconnect";
            this.Button_Disconnect.UseVisualStyleBackColor = true;
            this.Button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.Button_Disconnect);
            this.Controls.Add(this.Button_Test);
            this.Controls.Add(this.Button_Record);
            this.Controls.Add(this.Button_Connect);
            this.Controls.Add(this.Transfer_Progress_List);
            this.Controls.Add(this.PiCam_List);
            this.Controls.Add(this.Player_1);
            this.Controls.Add(this.Button_Transfer);
            this.Name = "Main";
            this.Text = "PiCam PC Client";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Player_1)).EndInit();
            this.ResumeLayout(false);

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
    }
}

