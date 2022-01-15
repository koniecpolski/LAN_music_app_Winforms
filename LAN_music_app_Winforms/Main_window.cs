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

// https://github.com/ZeBobo5/Vlc.DotNet/wiki/Getting-started

namespace LAN_music_app_Winforms
{
    public partial class Main_window : Form
    {
        private int? odtwarzany = null; // nullable integer
        //private bool next = false;
        delegate void StringParameterDelegate(string value);

        public Main_window()
        {
            InitializeComponent();
        }

        private void vlc_Play(FileInfo plik = null)
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { vlc_Play(plik); });
            }
            else
            {
                if (plik == null)
                    vlcControl1.Play();
                else
                {
                    try
                    {
                        vlcControl1.Play(plik);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
                    
            }

        }

        private void vlc_Stop()
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { vlc_Stop(); });
            }
            else
            {
                vlcControl1.Stop();
            }
        }

        private void vlc_Pause()
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { vlc_Pause(); });
            }
            else
            {
                vlcControl1.Pause();
            }
        }

        public void Play_i(int index)
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { Play_i(index); });
            }
            else
            {
                if (list_playlist.Items.Count > index) // Jeżeli indeks ma sens
                {
                    odtwarzany = index;
                    list_playlist.SelectedIndex = index;
                    Play(list_playlist.Items[index].ToString()); // odtwórz plik o tym indeksie
                }
                else
                    vlc_Stop();//vlcControl1.Stop();
            }
        }

        public void Play(string path) // funkcja ODTWARZANIA pliku dźwiękowego
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { Play(path); });
                //BeginInvoke(new StringParameterDelegate(Play), new object[] { path });
                return;
            }
            else
            {
                FileInfo plik = new System.IO.FileInfo(path); // konwersja ścieżki na format pliku
                string nazwa = Path.GetFileName(path); // wydobycie nazwy pliku
                text_played.Text = nazwa; // wypisanie nazwy pliku na ekranie
                vlc_Play(plik);//vlcControl1.Play(plik); // włączenie odtwarzania pliku
            }
        }

        public void Play_next()
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { Play_next(); });
            }
            else
            {
                int? nowy;
                if (odtwarzany != null)
                    nowy = odtwarzany + 1;
                else
                    nowy = 0;

                Play_i((int)nowy);
            }
        }

        public void Clear()
        {
            if (this.InvokeRequired)
                Invoke((Action)delegate { Clear(); });
            else
            {
                odtwarzany = null;
                list_playlist.ClearSelected();
                text_played.Text = "";
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (list_playlist.Items.Count > 0)
            {
                if (list_playlist.SelectedItem != null) // Jeżeli jakiś element jest wybrany
                    Play_i(list_playlist.SelectedIndex); // Odtwórz go
                else
                    Play_i(0);
            }
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

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // OKNO wybierania pliku
            ofd.ShowDialog(); // pokaż OKNO

            if (ofd.FileName != "") // jeżeli wybrano jakiś plik - odtwórz go
                list_playlist.Items.Add(ofd.FileName);
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            Play_next();
        }

        private void list_playlist_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                list_playlist.Items.RemoveAt(list_playlist.SelectedIndex);
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying)
            {
                button_pause.Text = "WZNÓW";
                vlc_Pause();//vlcControl1.Pause();
            }
            else
            {
                button_pause.Text = "PAUZA";
                vlc_Play();//vlcControl1.Play();
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            vlc_Stop();//vlcControl1.Stop();
        }

        private void vlcControl1_Stopped(object sender, Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs e)
        {
            //MessageBox.Show("Playlista się skończyła");
            (Application.OpenForms["Main_window"] as Main_window).Clear();
        }

        private void vlcControl1_EndReached(object sender, Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs e)
        {
            //base.Invoke((Action)delegate { Play_next(); });
            (Application.OpenForms["Main_window"] as Main_window).Play_next();
        }

    }
}
