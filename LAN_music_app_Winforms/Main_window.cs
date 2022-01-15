using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void Play(string path) // funkcja ODTWARZANIA pliku dźwiękowego
        {
            System.IO.FileInfo plik = new System.IO.FileInfo(path); // konwersja ścieżki na format pliku
            string nazwa = Path.GetFileName(path); // wydobycie nazwy pliku
            text_played.Text = nazwa; // wypisanie nazwy pliku na ekranie
            vlcControl1.Play(plik); // włączenie odtwarzania pliku
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // OKNO wybierania pliku
            ofd.ShowDialog(); // pokaż OKNO

            if (ofd.FileName!="") // jeżeli wybrano jakiś plik - odtwórz go
                Play(ofd.FileName);
        }

        private void list_playlist_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                list_playlist.Items.Add(file);
        }

        private void list_playlist_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) 
                e.Effect = DragDropEffects.Copy;
        }

        private void list_playlist_DoubleClick(object sender, EventArgs e)
        {
            if (list_playlist.SelectedItem != null) // Jeżeli jakiś element jest wybrany
                Play(list_playlist.SelectedItem.ToString()); // Odtwórz go
        }
    }
}
