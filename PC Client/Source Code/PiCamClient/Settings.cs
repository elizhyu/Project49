using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSCP;

namespace PiCamClient
{
    public partial class Settings : Form
    {

        string[,] device_list = new string[10, 4];
        int i = 0;
        int j = 0;
        int last_index = 0;
        bool last_visible = false;

        public Settings()
        {
            InitializeComponent();
        }

        private void Device_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(button_save.Enabled)
            {
                if(!(Device_Select.SelectedIndex == last_index))
                {
                    if (MessageBox.Show("Do you want to discard the changes you made?", "Change Unsaved", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        Device_Select.SelectedIndex = last_index;
                    }
                    else
                    {
                        last_index = Device_Select.SelectedIndex;
                        text_name.Text = device_list[Device_Select.SelectedIndex, 0];
                        text_hostname.Text = device_list[Device_Select.SelectedIndex, 1];
                        text_username.Text = device_list[Device_Select.SelectedIndex, 2];
                        text_password.Text = device_list[Device_Select.SelectedIndex, 3];
                        //text_fingerprint.Text = device_list[Device_Select.SelectedIndex, 4];
                        button_save.Enabled = false;
                    }
                }
            }
            else
            {
                last_index = Device_Select.SelectedIndex;
                text_name.Text = device_list[Device_Select.SelectedIndex, 0];
                text_hostname.Text = device_list[Device_Select.SelectedIndex, 1];
                text_username.Text = device_list[Device_Select.SelectedIndex, 2];
                text_password.Text = device_list[Device_Select.SelectedIndex, 3];
                //text_fingerprint.Text = device_list[Device_Select.SelectedIndex, 4];
                button_save.Enabled = false;
            }
        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {
            button_save.Enabled = true;
        }

        private void text_hostname_TextChanged(object sender, EventArgs e)
        {
            button_save.Enabled = true;
        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {
            button_save.Enabled = true;
        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {
            button_save.Enabled = true;
        }

        private void text_fingerprint_TextChanged(object sender, EventArgs e)
        {
            button_save.Enabled = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            device_list[Device_Select.SelectedIndex, 0] = text_name.Text;
            device_list[Device_Select.SelectedIndex, 1] = text_hostname.Text;
            device_list[Device_Select.SelectedIndex, 2] = text_username.Text;
            device_list[Device_Select.SelectedIndex, 3] = text_password.Text;
            //device_list[Device_Select.SelectedIndex, 4] = text_fingerprint.Text;
            button_save.Enabled = false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"config.txt");
            for (j = 0; j < 10; j++)
            {
                if(device_list[j, 0] != null)
                {
                    writer.WriteLine("----");
                    for (i = 0; i < 4; i++)
                    {
                        writer.WriteLine(device_list[j, i]);
                    }
                }
            }
            writer.Close();
            //Main.
            last_visible = false;
            this.Hide();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(last_visible.ToString());
        }

        private void Check_Visibility_Timer_Tick(object sender, EventArgs e)
        {
            if(this.Visible && !last_visible)
            {
                last_visible = true;
                if (File.Exists(@"config.txt"))
                {
                    try
                    {
                        StreamReader reader = new StreamReader(@"config.txt");
                        i = 0;
                        Device_Select.Items.Clear();
                        while (true)
                        {
                            if (string.Equals(reader.ReadLine(), "----"))
                            {
                                device_list[i, 0] = reader.ReadLine();
                                Device_Select.Items.Add(device_list[i, 0]);
                                device_list[i, 1] = reader.ReadLine();
                                device_list[i, 2] = reader.ReadLine();
                                device_list[i, 3] = reader.ReadLine();
                                //device_list[i, 4] = reader.ReadLine();
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception haha)
                    {
                        MessageBox.Show(haha.Message, "Error Message", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Possible setting file missing or broken! Please restore or create new.", "Setting File Missing", MessageBoxButtons.OK);
                }
                if (Device_Select.SelectedIndex == -1 && !(Device_Select.Items.Count == 0))
                {
                    Device_Select.SelectedIndex = 0;
                }
            }
        }
    }
}
