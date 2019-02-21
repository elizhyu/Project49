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

namespace PiCamClient
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if(File.Exists(@"config.txt"))
            {
                try
                {
                    StreamReader reader = new StreamReader(@"config.txt");
                    while(true)
                    {
                        if (string.Equals(reader.ReadLine(), "----"))
                        {
                            text_name.Text = reader.ReadLine();

                        }
                        else
                        {
                            break;
                        }
                    }
                }
                catch(Exception haha)
                {
                    MessageBox.Show(haha.Message, "Error Message", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Possible setting file missing or broken! Please restore or create new.", "Setting File Missing", MessageBoxButtons.OK);
            }
        }
    }
}
