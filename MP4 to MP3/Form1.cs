using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP4_to_MP3
{
    public partial class Form1 : Form
    {

        string videoName, videoPath, musicPath, musicName;

        public Form1()
        {
            InitializeComponent();
        }



        private void openvideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Filter = "MP4 File|*mp4" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPath = openFileDialog.FileName;
                videoName = openFileDialog.SafeFileName;
            }
            openvi.Text = videoPath;
        }

        private void savepath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog()==DialogResult.OK)
            {
                musicPath = folderBrowserDialog.SelectedPath;
                musicName = videoName.Substring(0, videoName.Length - 4);
                musicPath += ("\\" + musicName + ".mp3");
            }
            saveto.Text = musicPath;
        }

        private void convert_Click(object sender, EventArgs e)
        {
            var convert = new NReco.VideoConverter.FFMpegConverter();
            convert.ConvertMedia(openvi.Text.Trim(), saveto.Text.Trim(), "mp3");
            MessageBox.Show("Process completed!", "Information Window");

        }
    }
}
