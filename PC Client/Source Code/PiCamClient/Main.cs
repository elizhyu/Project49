using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Resources;
using System.IO;
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

        string[] File_List = new string[50];
        bool file_list_state = false;

        // Winscp Result Declaration
        CommandExecutionResult execute_result;
        TransferOptions sftp_option = new TransferOptions();
        TransferOperationResult sftp_result;
        Session ssh_session = new Session();

        // Background Stop Flag
        bool status_check_stop_flag = false;

        // 
        string status = "off";
        string action = "none";
        bool recording_status = false;
        int PiCam_Selection = -1;
        bool transfer_status = false;

        Settings settings = new Settings();

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
            //Player_1.URL = @"D:\Project49\2019-01-15_16-19-33.ts";
            //Player_1.Ctlcontrols.play();

            // Media Player Initiation
            Player_1.Ctlenabled = false;
            Player_1.uiMode = "none";
            
            // Transfer Progress List Settings
            Transfer_Progress_List.Groups.Add(Initiation_Group);
            Transfer_Progress_List.Groups.Add(Transfer_Group);
            Transfer_Progress_List.Sorting = SortOrder.None;
            Transfer_Progress_List.View = View.Details;
            Transfer_Progress_List.AllowColumnReorder = false;
            Transfer_Progress_List.FullRowSelect = true;
            Transfer_Progress_List.Columns.Add(new ColumnHeader());
            Transfer_Progress_List.Columns[0].Text = "Name";
            Transfer_Progress_List.Columns[0].Width = 170;
            Transfer_Progress_List.Columns.Add(new ColumnHeader());
            Transfer_Progress_List.Columns[1].Text = "Progress";
            Transfer_Progress_List.Columns[1].Width = 75;
            Transfer_Progress_List.Items.Add(new ListViewItem(new string[] { "Remote Device Access", "Unavailable" }, Initiation_Group));
            Transfer_Progress_List.Items.Add(new ListViewItem(new string[] { "File Tranfer Stream", "Stopped" }, Initiation_Group));
            Transfer_Progress_List.Items.Add(new ListViewItem(new string[] { "Recording Status", "Stopped" }, Initiation_Group));

            sftp_option.TransferMode = TransferMode.Binary;
            Device_List_Refresh_Timer.Enabled = true;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            //Player_1.URL = @"D:\Project49\PiCam_LOGO.png";
            //Player_1.URL = PiCamClient.Properties.Resources.PiCam_LOGO.png;
            Player_1.Ctlcontrols.pause();
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
                                
                            RemoteDirectoryInfo directory = ssh_session.ListDirectory("/home/pi/picam/rec/");
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
                                if (filename_array[filename_array.Length - 1].ToLower() == "ts") // change to TS for PiCam!!!!!!!!!
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
                                    //File_List[file_count] = new string;
                                    File_List[file_count] = filename;
                                    file_count++;
                                }
                            }
                            file_list_state = true;
                            while (file_list_state) ;

                                
                            // Transfer Files
                            //sftp_result = ssh_session.PutFiles(@"D:\Downloads\Bla Bla Bla\Pokemon\*", "/home/pi/Pictures/", false, sftp_option);
                            sftp_result = ssh_session.GetFiles("/home/pi/picam/rec/*.ts", @"D:\Project49\", false, sftp_option);
                            transfer_status = false;
                            //sftp_result.Check();

                            MessageBox.Show("Transfer Done", "Notification", MessageBoxButtons.OK);
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
                    Transfer_Progress_List.Items[0].SubItems[1].Text = "Unavailable";
                    break;
                case "ing":
                    Button_Connect.Enabled = false;
                    Button_Disconnect.Enabled = false;
                    Transfer_Progress_List.Items[0].SubItems[1].Text = "Establishing";
                    break;
                case "on":
                    Button_Connect.Enabled = false;
                    Button_Disconnect.Enabled = true;
                    Transfer_Progress_List.Items[0].SubItems[1].Text = "Connected";
                    break;
            }
            if (recording_status)
            {
                if (action == "stop") Button_Record.Enabled = false;
                else Button_Record.Enabled = true;
                Transfer_Progress_List.Items[2].SubItems[1].Text = "Recording";
                Button_Record.Text = "Stop";
            }
            else
            {
                if (action == "record") Button_Record.Enabled = false;
                else Button_Record.Enabled = true;
                Transfer_Progress_List.Items[2].SubItems[1].Text = "Stopped";
                Button_Record.Text = "Record";
            }
            if(transfer_status)
            {
                Button_Transfer.Enabled = false;
                Transfer_Progress_List.Items[1].SubItems[1].Text = "In Progress";
            }
            else
            {
                Button_Transfer.Enabled = true;
                Transfer_Progress_List.Items[1].SubItems[1].Text = "Down";
            }
            if(file_list_state)
            {
                foreach(ListViewItem item in Transfer_Progress_List.Groups[1].Items)
                {
                    item.Remove();
                }
                foreach(string filename in File_List)
                {
                    if (!(filename == ""))
                    {
                        Transfer_Progress_List.Items.Add(new ListViewItem(new string[] { filename, "Waiting" }, Transfer_Group));
                        Transfer_Progress_List.Items[Transfer_Progress_List.Items.Count - 1].EnsureVisible();
                    }
                }
                file_list_state = false;
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
                        MessageBox.Show(wrong.Message, "Error Message", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Possible setting file missing or broken! Please restore or create new.", "Setting File Missing", MessageBoxButtons.OK);
                }
                if (PiCam_List.SelectedIndex == -1 && !(PiCam_List.Items.Count == 0))
                {
                    PiCam_List.SelectedIndex = 0;
                }
                Device_List_Refresh_Timer.Enabled = false;
            }
        }

        private void Button_Browse_Click(object sender, EventArgs e)
        {
            Record_Dialog.Filter = "TS Files (*.ts)|*.ts|All Files (*.*)|*.*";
            Record_Dialog.CheckFileExists = true;
            Record_Dialog.Multiselect = false;
            Player_1.settings.mute = false;
            Player_1.settings.setMode("loop", true);
            //Player_1.settings.volume = 12;
            if (Record_Dialog.ShowDialog() != DialogResult.OK) return;
            Player_1.URL = Record_Dialog.FileName;
            Player_1.Ctlcontrols.play();
        }
    }
}
