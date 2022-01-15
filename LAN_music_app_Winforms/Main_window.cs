using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// https://github.com/ZeBobo5/Vlc.DotNet/wiki/Getting-started

namespace LAN_music_app_Winforms
{
    public partial class Main_window : Form
    {
        public Main_window()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo plik;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (ofd.FileName!="")
            {
                
                textBox_czas.Text = ofd.FileName;
                plik = new System.IO.FileInfo(ofd.FileName);
                vlcControl1.Play(plik);
                //label_connected.Text = VLCPlugin.playlist.itemCount.ToString();

            }
        }
    }
}
