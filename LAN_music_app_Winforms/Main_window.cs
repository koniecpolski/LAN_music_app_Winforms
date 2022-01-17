using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Collections;
using Vlc.DotNet.Core;

// https://github.com/ZeBobo5/Vlc.DotNet/wiki/Getting-started

namespace LAN_music_app_Winforms
{
    public partial class Main_window : Form
    {
        public int? odtwarzany = null; // nullable integer
        public bool serwer_aktywny = false;
        public static Hashtable clientsList = new Hashtable();

        public Main_window()
        {
            InitializeComponent();
            //vlcControl1.VlcLibDirectory = new DirectoryInfo(@"libvlc\win-x86\");
            vlcControl1.EndReached += StartNextSong; // dodanie zdarzenia na zakończenie odtwarzania utworu
        }

        #region Obsługa muzyki

        private void StartNextSong(object sender, VlcMediaPlayerEndReachedEventArgs e) // AUTOMATYCZNE przełączanie się utworów
        {
            ThreadPool.QueueUserWorkItem(state => { 
                this.vlcControl1.Stop(); 
                this.Play_next();
            });
        }

        private void vlc_Play(FileInfo plik = null) // funkcja odtwarzania nowego pliku
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

        private void vlc_Stop() // funkcja zatrzymywania odtwarzania
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { vlc_Stop(); });
            }
            else
            {
                if (serwer_aktywny)
                    broadcast("stop", "0", "null", true);
                vlcControl1.Stop();
            }
        }

        private void vlc_Pause() // funkcja pauzowania utworu
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { vlc_Pause(); });
            }
            else
            {
                if (serwer_aktywny)
                    broadcast("pauza", "0", "null", true);
                vlcControl1.Pause();
            }
        }

        private void vlc_Resume() // funkcja wznawiania odtwarzania
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { vlc_Resume(); });
            }
            else
            {
                if (serwer_aktywny)
                    broadcast("wznowienie", "0", "null", true);
                vlcControl1.Play();
            }
        }

        private void Change_Time(long czas) // Funkcja zmiana czasu odtwarzanego utworu
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { Change_Time(czas); });
            }
            else
            {
                if (serwer_aktywny)
                    broadcast("zmiana", czas.ToString(), "null", true);
                vlcControl1.Time = czas;
            }
        }

        public void Play_i(int index) // odtwarzanie utworu o danym indeksie na playliscie
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
                {
                    vlc_Stop();
                    Clear();
                }
                    
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
                if (serwer_aktywny)
                    broadcast("start", "0", path, true);
                vlc_Play(plik);//vlcControl1.Play(plik); // włączenie odtwarzania pliku
            }
        }

        public void Play_next() // funkcja odtwarzania kolejnego utworu na liście
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

        public void Clear() // funkcja czyszczenia wyświetlanego utworu
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

        private void button_start_Click(object sender, EventArgs e) // PRZYCISK START
        {
            if (list_playlist.Items.Count > 0)
            {
                if (list_playlist.SelectedItem != null) // Jeżeli jakiś element jest wybrany
                    Play_i(list_playlist.SelectedIndex); // Odtwórz go
                else
                    Play_i(0); // odtwórz pierwszy na liście
            }
        }

        #region Dodawanie utworów

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

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // OKNO wybierania pliku
            ofd.ShowDialog(); // pokaż OKNO

            if (ofd.FileName != "") // jeżeli wybrano jakiś plik - odtwórz go
                list_playlist.Items.Add(ofd.FileName);
        }

        #endregion

        private void list_playlist_DoubleClick(object sender, EventArgs e) // wybranie elementu z listy
        {
            if (list_playlist.SelectedItem != null) // Jeżeli jakiś element jest wybrany
                Play(list_playlist.SelectedItem.ToString()); // Odtwórz go
        }

        private void button_next_Click(object sender, EventArgs e) // PRZYCISK NEXT
        {
            Play_next();
        }

        private void list_playlist_KeyUp(object sender, KeyEventArgs e) // usuwanie elementów z listy
        {
            if (e.KeyCode == Keys.Delete)
                list_playlist.Items.RemoveAt(list_playlist.SelectedIndex);
        }

        private void button_pause_Click(object sender, EventArgs e) // PRZYCISK PAUZA
        {
            if (vlcControl1.IsPlaying)
            {
                button_pause.Text = "WZNÓW";
                vlc_Pause();
            }
            else
            {
                button_pause.Text = "PAUZA";
                vlc_Resume();
            }
        }

        private void button_stop_Click(object sender, EventArgs e) // PRZYCISK STOP
        {
            vlc_Stop();
            Clear();
        }

        private void button_set_Click(object sender, EventArgs e) // PRZYCISK USTAW
        {
            long czas = Convert.ToInt64(textBox_czas.Text);
            Change_Time(czas);
        }

        #endregion


        #region Obsługa połączeń

        public void msg(int akcja, string readData = null) // obsługa przychodzących informacji
        {

            switch(akcja)
            {
                case 1: // NOWY client
                    update_licznik(1);
                    break;

                case 2: // BYE
                    update_licznik(-1);
                    break;

                default:
                    // nic nie rob
                    break;
            }
        } 

        private void broadcast_playlist() // wątek cyklicznego rozsyłania bieżącego odtwarzanego utworu
        {
            long czas;
            string utwor;
            while (serwer_aktywny)
            {
                if (clientsList.Count>0)
                {
                    if (odtwarzany != null)
                    {
                        utwor = list_playlist.Items[(int)odtwarzany].ToString();
                        czas = vlcControl1.Time;
                        broadcast("gra", czas.ToString(), utwor, true);
                    }
                    else
                        broadcast("czeka", "0", "null", true);

                    Thread.Sleep(5000); // odczekaj 5  sekund
                }
            }
        }

        public static void broadcast(string akcja, string czas, string utwor, bool flag) // funkcja wysłyania do wszsystkich podłączonych clientów
        {
            foreach (DictionaryEntry Item in clientsList) // dla każdego clienta na liście
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null;

                if (flag == true) // utwór + czas 
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(akcja + ";" + utwor + ";" + czas);
                }
                else // tylko czas odtwarzanego
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(czas);
                }

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length); // przekaż wiadomość
                broadcastStream.Flush();
            }
        }  //end broadcast function

        private void update_licznik(int val)
        {
            if (label_connected.InvokeRequired) // na wypadek wywołania z innego wątk
            {
                Action safeWrite = delegate { update_licznik(val); };
                label_connected.Invoke(safeWrite);
            }
            else
            {
                label_connected.Text = (Convert.ToInt32(label_connected.Text) + val).ToString();
                label_connected.Refresh();
            }
        }

        private void przyjmowanie_polaczen() // Funkcja nasłuchująca połączeń od nowych clientów
        {
            int port = System.Convert.ToInt16(3333);
            IPAddress adresIP = IPAddress.Parse(text_IP.Text); // MÓJ adres IP
            TcpListener serverSocket = new TcpListener(adresIP, port);
            TcpClient clientSocket = default(TcpClient);
            int counter; // licznik połączonych clientów

            serverSocket.Start(); // otwarcie gniazda

            counter = 0;
            while (serwer_aktywny)
            {
                counter += 1;
                clientSocket = serverSocket.AcceptTcpClient(); // przyjęcie połączenia

                clientsList.Add(counter.ToString(), clientSocket); // dodanie clienta do listy gniazd


                msg(1);  // zwiekszenie licznika wyświetlanego

                // przeniesienie clienta do nowego obiektu, w którym będzie miał swój własny wątek
                handleClinet client = new handleClinet(this);
                client.startClient(clientSocket, counter.ToString(), clientsList);

            }
            serverSocket.Stop(); // zakończenie działania serwera
            serverSocket = null;
        }

        private void button_start_server_Click(object sender, EventArgs e)
        {
            if (!serwer_aktywny)
            {
                serwer_aktywny = true;
                button_start_server.Text = "ZATRZYMAJ\nSERWER";

                Thread ctThread = new Thread(przyjmowanie_polaczen); // start wątku nasłuchiwania dołączeń clientów
                ctThread.Start();
                Thread ctThread2 = new Thread(broadcast_playlist); // start wątku nasłuchiwania dołączeń clientów
                ctThread2.Start();
            }
            else
            {
                serwer_aktywny = false;
                button_start_server.Text = "URUCHOM\nSERWER";
            }
        }

        #endregion
    }


    public class handleClinet // klasa połączonego clienta
    {
        TcpClient clientSocket;
        string clNo; // nazwa clienta
        private Main_window theForm; // okno servera
        Hashtable clientsList;

        public handleClinet(Main_window theForm)
        {
            this.theForm = theForm; // przy deklaracji przepisanie instancji okna do zmiennej
        }

        public void startClient(TcpClient inClientSocket, string clineNo, Hashtable cList)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            this.clientsList = cList;
            Thread ctThread = new Thread(doChat); // wystartowanie wątku do odbierania przychodzących wiadomości
            ctThread.Start();
        }


        private void doChat()
        {
            int requestCount;
            int bufferSize = 10025;
            byte[] bytesFrom = new byte[bufferSize];
            string dataFromClient = null;
            string rCount = null;

            requestCount = 0;
            while ((theForm.serwer_aktywny)) // odbieranie informacji od clientow
            {
                try
                {
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, bufferSize);
                    dataFromClient = Encoding.ASCII.GetString(bytesFrom);
                    // odczytanie wiadomości aż do wystąpienia symbolu '$'
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    // wypisanie wiadomości w log'u
                    if (dataFromClient == "BYE")
                        break; // zakończ wątek
                    

                    rCount = Convert.ToString(requestCount); // licznik wykonanych wiadomości
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Klient się brutalnie rozłączył"); // w przypadku utraty połączenia zakończ wątek
                    break;
                }
            }//end while
            clientsList.Remove(clNo);
            theForm.msg(2); // zmniejsz licznik
            clientSocket.Close();
        }//end doChat
    } //end class handleClinet


}
