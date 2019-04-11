using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Resources;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSCP;
using WMPLib;

using PiCamClient.Properties;

namespace PiCamClient
{
    public partial class Main : Form
    {
        const int Device_Count = 10;
        public SessionOptions[] device_list = new SessionOptions[Device_Count];

        // Transfer Progress List Groups
        ListViewGroup Initiation_Group = new ListViewGroup("Live Monitor");
        ListViewGroup Transfer_Group = new ListViewGroup("File Transfer");

        string[] File_List = new string[100];
        bool file_list_state = false;
        bool file_list_final = false;

        // Winscp Result Declaration
        CommandExecutionResult execute_result;
        TransferOptions sftp_option = new TransferOptions();
        TransferOperationResult sftp_result;
        Session ssh_session = new Session();

        // Background Stop Flag
        bool status_check_stop_flag = false;
        bool test_flag = false;

        // Status Check
        string status = "off";
        string action = "none";
        bool recording_status = false;
        int PiCam_Selection = -1;
        bool transfer_status = false;
        string[] bat_info = new string[2];
        string bat_per = "0";
        string min_left = "0";
        bool bat_update = false;
        bool bat_warning_flag = false;

        Settings settings = new Settings();
        AboutBox about = new AboutBox();

        // Sync Variables
        bool sync_flag = false;
        string Start_Time_1 = "";
        string Start_Time_2 = "";
        int Hour_1 = 0;
        int Hour_2 = 0;
        int Min_1 = 0;
        int Min_2 = 0;
        int Sec_1 = 0;
        int Sec_2 = 0;
        double Start_Time_Num_1 = 0;
        double Start_Time_Num_2 = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Button_Transfer_Click(object sender, EventArgs e)
        {
            action = "transfer";
        }

        private void SessionFileTransferProgress(object sender , FileTransferProgressEventArgs e)
        {
            string _lastFileName = "";
            int currentindex = 0;
            // Grab file name
            string[] filename_array = e.FileName.Split('/');

            // New line for every new file
            if (_lastFileName != e.FileName)
            {
                foreach(ListViewItem theitem in Transfer_Progress_List.Items)
                {
                    if (theitem.SubItems[0].Text.Split('(')[0] == filename_array[filename_array.Length - 1])
                    {
                        currentindex = theitem.Index;
                        Transfer_Progress_List.Items[currentindex].EnsureVisible();
                    }
                }
            }

            // Print transfer progress
            double progess_percent =  e.FileProgress * 100;
            // Use "Done" instead of 100%
            if (progess_percent == 100) Transfer_Progress_List.Items[currentindex].SubItems[1].Text = "Done";
            else Transfer_Progress_List.Items[currentindex].SubItems[1].Text = progess_percent + "%";

            // Remember a name of the last file reported
            _lastFileName = e.FileName;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Config_File_Dialog.Filter = "TXT Files (*.txt)|*.txt|All Files (*.*)|*.*";
            Config_File_Dialog.CheckFileExists = true;
            Config_File_Dialog.Multiselect = false;

            // Media Player Initiation
            Player_1.Ctlenabled = true;
            Player_1.uiMode = "full";//"none";
            Player_2.Ctlenabled = true;
            Player_2.uiMode = "full";//"none";

            // Transfer Progress List Settings
            //Transfer_Progress_List.Groups.Add(Initiation_Group);
            //Transfer_Progress_List.Groups.Add(Transfer_Group);
            Transfer_Progress_List.Sorting = SortOrder.None;
            Transfer_Progress_List.View = View.Details;
            Transfer_Progress_List.AllowColumnReorder = false;
            Transfer_Progress_List.FullRowSelect = true;
            Transfer_Progress_List.Columns.Add(new ColumnHeader());
            Transfer_Progress_List.Columns[0].Text = "Name";
            Transfer_Progress_List.Columns[0].Width = 225;
            Transfer_Progress_List.Columns.Add(new ColumnHeader());
            Transfer_Progress_List.Columns[1].Text = "Progress";
            Transfer_Progress_List.Columns[1].Width = 80;
            //Transfer_Progress_List.Items.Add(new ListViewItem(new string[] { "Remote Device Access", "Unavailable" }, Initiation_Group));
            //Transfer_Progress_List.Items.Add(new ListViewItem(new string[] { "File Tranfer Stream", "Stopped" }, Initiation_Group));
            //Transfer_Progress_List.Items.Add(new ListViewItem(new string[] { "Recording Status", "Stopped" }, Initiation_Group));

            sftp_option.TransferMode = TransferMode.Binary;
            Device_List_Refresh_Timer.Enabled = true;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Device_List_Refresh_Timer.Enabled = true;
        }

        private async void Button_Connect_Click(object sender, EventArgs e)
        {
            status_check_stop_flag = false;
            await Task.Run((Action)status_check_function);
        }

        private void Button_Disconnect_Click(object sender, EventArgs e)
        {
            status_check_stop_flag = true;
        }

        private void status_check_function()
        {
            status = "ing";
            try
            {
                // ====================================================================================================================
                // Select and Establish Connection
                ssh_session.Open(device_list[PiCam_Selection]);

                status = "on";

                while (status_check_stop_flag == false)
                {
                    switch(action)
                    {
                        // ====================================================================================================================
                        // Transfer Recording
                        case "transfer":
                            transfer_status = true;
                            // Read 
                                
                            RemoteDirectoryInfo directory = ssh_session.ListDirectory("/home/pi/picam/rec/archive");
                            for(int file_list_count = 0; file_list_count < File_List.Length; file_list_count++)
                            {
                                File_List[file_list_count] = "";
                            }
                            int file_count = 0;
                            foreach (RemoteFileInfo FileInfo in directory.Files)
                            {
                                // Grab file name
                                string[] filename_array = FileInfo.Name.Split('.');

                                // File Type Matching
                                if (filename_array[filename_array.Length - 1].ToLower() == "ts")
                                {
                                    int i = 0;
                                    string[] Byte_Units = { " B", " KB", " MB", " GB", "TB" };
                                    long FileSize = FileInfo.Length;
                                    while (FileSize >= 1024)
                                    {
                                        FileSize = FileSize / 1024;
                                        i++;
                                    }
                                    string filename = FileInfo.Name + "(" + FileSize + Byte_Units[i] + ")";
                                    File_List[file_count] = filename;
                                    file_count++;
                                }
                            }
                            file_list_state = true;
                            while (file_list_state) ;

                                
                            // Transfer Files
                            //sftp_result = ssh_session.PutFiles(@"D:\Downloads\Bla Bla Bla\Pokemon\*", "/home/pi/Pictures/", false, sftp_option);
                            sftp_result = ssh_session.GetFiles("/home/pi/picam/rec/archive/*.ts", @"C:\PiCam\records\", true, sftp_option);
                            transfer_status = false;
                            //sftp_result.Check();

                            MessageBox.Show("Transfer Done", "Notification", MessageBoxButtons.OK);
                            file_list_final = true;
                            action = "none";
                            break;
                        case "record":
                            execute_result = ssh_session.ExecuteCommand("sudo touch ~/picam/hooks/start_record");
                            action = "none";
                            break;
                        case "stop":
                            execute_result = ssh_session.ExecuteCommand("sudo touch ~/picam/hooks/stop_record");
                            action = "none";
                            break;
                        case "test":
                            execute_result = ssh_session.ExecuteCommand("sudo sh /home/pi/Project49/Code/fivesec.sh");
                            MessageBox.Show("Test Performed", "Notification", MessageBoxButtons.OK);
                            if (File.Exists(@"C:\PiCam\records\last_preview.ts")) File.Delete(@"C:\PiCam\records\last_preview.ts");
                            sftp_result = ssh_session.GetFiles("/home/pi/picam/rec/archive/preview.ts", @"C:\PiCam\records\", true, sftp_option);
                            if (!File.Exists(@"C:\PiCam\records\last_preview.ts")) File.Move(@"C:\PiCam\records\preview.ts", @"C:\PiCam\records\last_preview.ts");
                            test_flag = true;
                            action = "none";
                            break;
                        // ====================================================================================================================
                        case "none":
                            break;
                    }

                    // ====================================================================================================================
                    // Check Recording Status
                    execute_result = ssh_session.ExecuteCommand("sudo cat ~/picam/state/record");
                    if (execute_result.Output == "false") recording_status = false;
                    else if (execute_result.Output == "true") recording_status = true;
                    execute_result = ssh_session.ExecuteCommand("sudo cat /home/pi/Project49/execution_data/battery_info.txt");
                    bat_info = execute_result.Output.Split(' ');
                    bat_per = bat_info[0];
                    min_left = bat_info[1];
                    bat_update = true;
                    //if (execute_result.Output.Split(' ') == )
                }
                ssh_session.Close();
                status = "off";
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error Message", MessageBoxButtons.OK);
            }
        }
        
        public void Status_Refresh_Timer_Tick(object sender, EventArgs e)
        {
            switch(status)
            {
                case "off":
                    Button_Connect.Enabled = true;
                    Button_Disconnect.Enabled = false;
                    Connect_Status_Label.Text = "Unavailable";
                    Connect_Status_Label.ForeColor = Color.Red;
                    //Transfer_Progress_List.Items[0].SubItems[1].Text = "Unavailable";
                    Bat_Lvl_Label.Text = "Unavailable";
                    Bat_Lvl_Label.ForeColor = Color.Red;
                    Time_Left_Label.Text = "Unavailable";
                    Time_Left_Label.ForeColor = Color.Red;
                    Bat_Warn_Label.Text = "   ";
                    break;
                case "ing":
                    Button_Connect.Enabled = false;
                    Button_Disconnect.Enabled = false;
                    Connect_Status_Label.Text = "Establishing";
                    Connect_Status_Label.ForeColor = Color.Orange;
                    //Transfer_Progress_List.Items[0].SubItems[1].Text = "Establishing";
                    break;
                case "on":
                    Button_Connect.Enabled = false;
                    Button_Disconnect.Enabled = true;
                    Connect_Status_Label.Text = "Connected";
                    Connect_Status_Label.ForeColor = Color.SeaGreen;
                    //Transfer_Progress_List.Items[0].SubItems[1].Text = "Connected";
                    break;
            }
            if (recording_status)
            {
                if (action == "stop") Button_Record.Enabled = false;
                else Button_Record.Enabled = true;
                Record_Status_Label.Text = "Recording";
                Record_Status_Label.ForeColor = Color.SeaGreen;
                //Transfer_Progress_List.Items[2].SubItems[1].Text = "Recording";
                Button_Record.Text = "Stop";
            }
            else
            {
                if (action == "record") Button_Record.Enabled = false;
                else Button_Record.Enabled = true;
                Record_Status_Label.Text = "Stopped";
                Record_Status_Label.ForeColor = Color.Red;
                //Transfer_Progress_List.Items[2].SubItems[1].Text = "Stopped";
                Button_Record.Text = "Record";
            }
            if(transfer_status)
            {
                Button_Transfer.Enabled = false;
                File_Transfer_Status_Label.Text = "In Progress";
                File_Transfer_Status_Label.ForeColor = Color.SeaGreen;
                //Transfer_Progress_List.Items[1].SubItems[1].Text = "In Progress";
            }
            else
            {
                Button_Transfer.Enabled = true;
                File_Transfer_Status_Label.Text = "Down";
                File_Transfer_Status_Label.ForeColor = Color.Red;
                //Transfer_Progress_List.Items[1].SubItems[1].Text = "Down";
            }
            if(file_list_state)
            {
                foreach(ListViewItem item in Transfer_Progress_List.Items)
                {
                    item.Remove();
                }
                foreach(string filename in File_List)
                {
                    if (!(filename == ""))
                    {
                        Transfer_Progress_List.Items.Add(new ListViewItem(new string[] { filename, "Transferring" }));
                        Transfer_Progress_List.Items[Transfer_Progress_List.Items.Count - 1].EnsureVisible();
                    }
                }
                file_list_state = false;
            }
            if(file_list_final)
            {
                foreach (ListViewItem item in Transfer_Progress_List.Items)
                {
                    item.SubItems[1].Text = "Done";
                }
                file_list_final = false;
            }
            if(test_flag)
            {
                test_flag = false;
                Player_1.settings.mute = false;
                Player_1.settings.setMode("loop", true);
                Player_1.URL = @"C:\PiCam\records\last_preview.ts";
                Player_1.Ctlcontrols.play();
                Media_Player_Timer.Enabled = true;
            }
            if(bat_update)
            {
                bat_update = false;
                if(Convert.ToInt16(min_left) >= 60)
                {
                    Time_Left_Label.Text = (Convert.ToInt16(min_left) / 60).ToString() + "h" + (Convert.ToInt16(min_left) % 60).ToString() + "min";
                }
                else
                {
                    Time_Left_Label.Text = min_left + "min";
                }

                Bat_Lvl_Label.Text = bat_per + "%";
                if(Convert.ToInt16(bat_per) < 50)
                {
                    if(Convert.ToInt16(bat_per) < 20)
                    {
                        Bat_Warn_Label.Text = "Extremely Low";
                        Bat_Lvl_Label.ForeColor = Color.Red;
                        Time_Left_Label.ForeColor = Color.Red;
                        if (Convert.ToInt16(bat_per) < 10)
                        {
                            if (!bat_warning_flag)
                            {
                                bat_warning_flag = true;
                                MessageBox.Show("Battery is almost gone! Please stop recording immediately to save footage!", "Battery Low Warning", MessageBoxButtons.OK);

                            }
                        }
                        else
                        {
                            bat_warning_flag = false;
                        }
                    }
                    else
                    {
                        bat_warning_flag = false;
                        Bat_Warn_Label.Text = "Battery Low";
                        Bat_Lvl_Label.ForeColor = Color.Orange;
                        Time_Left_Label.ForeColor = Color.Orange;
                    }
                }
                else
                {
                    bat_warning_flag = false;
                    Bat_Warn_Label.Text = "";
                    Bat_Lvl_Label.ForeColor = Color.SeaGreen;
                    Time_Left_Label.ForeColor = Color.SeaGreen;
                }
            }
        }

        private void PiCam_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            PiCam_Selection = PiCam_List.SelectedIndex;
        }

        private void Button_Record_Click(object sender, EventArgs e)
        {
            if(recording_status) action = "stop";
            else action = "record";
        }

        private void Button_Test_Click(object sender, EventArgs e)
        {
            Player_1.Ctlcontrols.stop();
            Player_1.URL = "";
            action = "test";
        }

        public void Button_Setting_Click(object sender, EventArgs e)
        {
            settings.Show();
            Device_List_Refresh_Timer.Enabled = true;
            
        }

        public void Device_List_Refresh_Timer_Tick(object sender, EventArgs e)
        {
            if (!settings.Visible)
            {
                if (File.Exists(@"config.txt"))
                {
                    try
                    {
                        StreamReader reader = new StreamReader(@"config.txt");
                        for (int i = 0; i < Device_Count; i++)
                        {
                            device_list[i] = new SessionOptions();
                            device_list[i].HostName = "";
                            device_list[i].UserName = "";
                            device_list[i].Password = "";
                        }
                        PiCam_List.Items.Clear();
                        int count = 0;
                        while (true)
                        {
                            if (string.Equals(reader.ReadLine(), "----"))
                            {
                                PiCam_List.Items.Add(reader.ReadLine());
                                device_list[count].HostName = reader.ReadLine();
                                device_list[count].UserName = reader.ReadLine();
                                device_list[count].Password = reader.ReadLine();
                                device_list[count].Protocol = Protocol.Sftp;
                                device_list[count].GiveUpSecurityAndAcceptAnySshHostKey = true;
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception wrong)
                    {
                        Device_List_Refresh_Timer.Enabled = false;
                        MessageBox.Show(wrong.Message, "Error Message", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    Device_List_Refresh_Timer.Enabled = false;
                    if (MessageBox.Show("Possible setting file missing or broken! Do you want to locate it now?", "Setting File Missing", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Config_File_Dialog.ShowDialog() == DialogResult.OK)
                        {
                            File.Copy(Config_File_Dialog.FileName, @"config.txt", true);
                            try
                            {
                                StreamReader reader = new StreamReader(@"config.txt");
                                for (int i = 0; i < Device_Count; i++)
                                {
                                    device_list[i] = new SessionOptions();
                                    device_list[i].HostName = "";
                                    device_list[i].UserName = "";
                                    device_list[i].Password = "";
                                }
                                PiCam_List.Items.Clear();
                                int count = 0;
                                while (true)
                                {
                                    if (string.Equals(reader.ReadLine(), "----"))
                                    {
                                        PiCam_List.Items.Add(reader.ReadLine());
                                        device_list[count].HostName = reader.ReadLine();
                                        device_list[count].UserName = reader.ReadLine();
                                        device_list[count].Password = reader.ReadLine();
                                        device_list[count].Protocol = Protocol.Sftp;
                                        device_list[count].GiveUpSecurityAndAcceptAnySshHostKey = true;
                                        count++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                reader.Close();
                            }
                            catch (Exception wrong)
                            {
                                MessageBox.Show(wrong.Message, "Error Message", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                if (PiCam_List.SelectedIndex == -1 && !(PiCam_List.Items.Count == 0))
                {
                    PiCam_List.SelectedIndex = 0;
                }
                Device_List_Refresh_Timer.Enabled = false;
            }
        }

        public void Button_Browse_Click(object sender, EventArgs e)
        {
            if(!File.Exists(@"C:\PiCam\records"))  System.IO.Directory.CreateDirectory(@"C:\PiCam\records");
            Record_Dialog.InitialDirectory = @"C:\PiCam\records\";
            Player_1.Ctlcontrols.stop();
            Media_Player_Timer.Enabled = false;
            Record_Dialog.Filter = "TS Files (*.ts)|*.ts|All Files (*.*)|*.*";
            Record_Dialog.CheckFileExists = true;
            Record_Dialog.Multiselect = false;
            Player_1.settings.mute = false;
            Player_1.settings.setMode("loop", true);
            if (Record_Dialog.ShowDialog() != DialogResult.OK) return;
            Player_1.URL = Record_Dialog.FileName;
            Player_1.Ctlcontrols.play();
            Media_Player_Timer.Enabled = true;
        }

        private void Media_Player_Timer_Tick(object sender, EventArgs e)
        {
            if (Player_1.playState == WMPPlayState.wmppsPlaying)
            {
                label_duration.Text = Player_1.Ctlcontrols.currentPositionString + " / " + Player_1.currentMedia.durationString;
            }
            if (Player_2.playState == WMPPlayState.wmppsPlaying)
            {
                label_duration2.Text = Player_2.Ctlcontrols.currentPositionString + " / " + Player_2.currentMedia.durationString;
            }
            if(sync_flag)
            {
                if((Player_1.playState != WMPPlayState.wmppsPlaying) | (Player_2.playState != WMPPlayState.wmppsPlaying))
                {
                    Player_1.Ctlcontrols.stop();
                    Player_2.Ctlcontrols.stop();
                    sync_flag = false;
                }
            }
        }

        private void Button_Browse2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\PiCam\records")) System.IO.Directory.CreateDirectory(@"C:\PiCam\records");
            Record_Dialog.InitialDirectory = @"C:\PiCam\records\";
            Player_2.Ctlcontrols.stop();
            Media_Player_Timer.Enabled = false;
            Record_Dialog.Filter = "TS Files (*.ts)|*.ts|All Files (*.*)|*.*";
            Record_Dialog.CheckFileExists = true;
            Record_Dialog.Multiselect = false;
            Player_2.settings.mute = false;
            Player_2.settings.setMode("loop", true);
            if (Record_Dialog.ShowDialog() != DialogResult.OK) return;
            Player_2.URL = Record_Dialog.FileName;
            Player_2.Ctlcontrols.play();
            Media_Player_Timer.Enabled = true;
        }

        private void Button_Clear_Playback1_Click(object sender, EventArgs e)
        {
            Player_1.Ctlcontrols.stop();
            Player_1.URL = "";
        }

        private void Button_Clear_Playback2_Click(object sender, EventArgs e)
        {
            Player_2.Ctlcontrols.stop();
            Player_2.URL = "";
        }

        private void Button_Sync_Click(object sender, EventArgs e)
        {
            Player_1.Ctlcontrols.pause();
            Player_2.Ctlcontrols.pause();
            if ((Player_1.URL != "") && (Player_2.URL != ""))
            {
                // extract starting time from file name #1
                string[] splited_name = Player_1.URL.Split('\\');
                Start_Time_1 = splited_name[splited_name.Length - 1];
                Start_Time_1 = Start_Time_1.Remove(Start_Time_1.Length - 3, 3);
                // extract starting time from file name #2
                splited_name = Player_2.URL.Split('\\');
                Start_Time_2 = splited_name[splited_name.Length - 1];
                Start_Time_2 = Start_Time_2.Remove(Start_Time_2.Length - 3, 3);
        
                if (string.Compare(Start_Time_1.Substring(0, 10), Start_Time_2.Substring(0, 10)) == 0)  // match date
                {
                    // extract time in hours, minutes and seconds
                    Start_Time_1 = Start_Time_1.Substring(11);
                    Start_Time_2 = Start_Time_2.Substring(11);
                    Hour_1 = Convert.ToInt16(Start_Time_1.Substring(0, 2));
                    Hour_2 = Convert.ToInt16(Start_Time_2.Substring(0, 2));
                    Min_1 = Convert.ToInt16(Start_Time_1.Substring(3, 2));
                    Min_2 = Convert.ToInt16(Start_Time_2.Substring(3, 2));
                    Sec_1 = Convert.ToInt16(Start_Time_1.Substring(6, 2));
                    Sec_2 = Convert.ToInt16(Start_Time_2.Substring(6, 2));
                    Start_Time_Num_1 = Sec_1 + (Hour_1 * 60 + Min_1) * 60;
                    Start_Time_Num_2 = Sec_2 + (Hour_2 * 60 + Min_2) * 60;
                    if(Start_Time_Num_1 < Start_Time_Num_2)
                    {
                        if(Start_Time_Num_2 <= (Start_Time_Num_1 + Player_1.currentMedia.duration))
                        {
                            Player_1.settings.setMode("loop", false);
                            Player_2.settings.setMode("loop", false);
                            Player_1.Ctlcontrols.currentPosition = Start_Time_Num_2 - Start_Time_Num_1;
                            Player_2.Ctlcontrols.currentPosition = 0;
                            Player_1.Ctlcontrols.play();
                            Player_2.Ctlcontrols.play();
                            sync_flag = true;
                        }
                        else
                        {
                            MessageBox.Show("The footages selected are not able to be synced due to time difference.", "Sync Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        if (Start_Time_Num_1 <= (Start_Time_Num_2 + Player_2.currentMedia.duration))
                        {
                            Player_1.settings.setMode("loop", false);
                            Player_2.settings.setMode("loop", false);
                            Player_1.Ctlcontrols.currentPosition = 0;
                            Player_2.Ctlcontrols.currentPosition = Start_Time_Num_1 - Start_Time_Num_2;
                            Player_1.Ctlcontrols.play();
                            Player_2.Ctlcontrols.play();
                            sync_flag = true;
                        }
                        else
                        {
                            MessageBox.Show("The footages selected are not able to be synced due to time difference.", "Sync Error", MessageBoxButtons.OK);
                        }
                    }
                    //MessageBox.Show(Player_1.currentMedia.duration.ToString());
                }
                else  // if date unmatched
                {
                    MessageBox.Show("The footages selected are not able to be synced due to date difference.", "Sync Error", MessageBoxButtons.OK);
                }
            }
        }

        private void Button_About_Click(object sender, EventArgs e)
        {
            about.Show();
        }
    }
}