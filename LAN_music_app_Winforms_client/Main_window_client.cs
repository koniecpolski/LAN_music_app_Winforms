using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net; // do typu IPAddress
using System.Collections;
using System.IO;

namespace LAN_music_app_Winforms_client
{
    public partial class Main_window_client : Form
    {
        TcpClient clientSocket;
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        bool polaczenia_aktywne = false;
        Thread ctThread;
        string odtwarzany;

        public Main_window_client()
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

        private void vlc_Resume()
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { vlc_Resume(); });
            }
            else
            {
                vlcControl1.Play();
            }
        }


        private void Play(string path, long czas = 0, bool sync = false)
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
                odtwarzany = path;
                vlc_Play(plik);//vlcControl1.Play(plik); // włączenie odtwarzania pliku
                if(sync)
                    vlcControl1.Time = czas;
            }
        }

        private void Change_Time(long czas)
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)delegate { Change_Time(czas); });
                return;
            }
            else
            {
                vlcControl1.Time = czas;
            }
        }

        private void aktualizacja(string akcja, string plik, long czas)
        {
            switch(akcja)
            {
                case "gra": // synchronizacja z odtwarzaniem

                    if (plik != odtwarzany)
                    {
                        if(Math.Abs(czas - vlcControl1.Time) > 3000) // 3s różnycy nie wymagają synchronizacji
                            Play(plik, czas, true);
                        else
                            Play(plik, czas, false);
                    }
                    break;

                case "zmiana": // ręczne ustawienie czasu 
                    Change_Time(czas);
                    break;

                case "czeka": // bezczynność - nic nie jest grane
                    break;

                case "pauza": // pauzowanie utworu
                    vlc_Pause();
                    break;

                case "wznowienie": // odpauzowanie utworu
                    vlc_Resume();
                    break;

                case "stop": // zatrzymanie odtwarzania
                    vlc_Stop();
                    break;

                case "start": // rozpoczęcie grania nowego utworu
                    Play(plik,czas, false);
                    break;

                default:
                    break;

            }
            

        }

        private void getMessage() // funkcja odczytująca wiadomości przychodzące
        {
            while (polaczenia_aktywne)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 10025;
                byte[] inStream = new byte[buffSize];
                serverStream.Read(inStream, 0, buffSize); // ODCZYTANIE
                string returndata = Encoding.ASCII.GetString(inStream);

                string[] part = returndata.Split(new char[] { ';' }, 3);

                if (part[1] != "null")
                    readData = part[0].ToUpper() + " - "+ part[1] + " ("+part[2]+")";
                else
                    readData = part[0].ToUpper();
                msg(); // Dodanie linii chat'u

                aktualizacja(part[0], part[1], Convert.ToInt64(part[2]));
            }
            clientSocket.Close(); // jeżeli połączenie jest zakończone, zamknij gniazdo
        }
        private void msg() // funkcja dodawania linii log'u
        {
            if (list_log.InvokeRequired) // jeżeli wywołano spoza głównego wątku
            {
                Action safeWrite = delegate { msg(); };
                list_log.Invoke(safeWrite);
            }
            else
            {
                list_log.Items.Add(readData);
            }

        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (!polaczenia_aktywne)
            {
                // zablokowanie pól tekstowych z danymi do połączenia
                text_IP.Enabled = false;

                // odczytanie wprowadzonych danych dla połączenia
                int port = System.Convert.ToInt16(3333); // numer portu
                IPAddress adresIP = IPAddress.Parse(text_IP.Text); // adres IP servera

                readData = "Połączono z serwerem";
                msg();

                // otworzenie gniazda
                clientSocket = new TcpClient();
                clientSocket.Connect(adresIP, port);
                serverStream = clientSocket.GetStream();

                // zmiana opisu przycisku
                polaczenia_aktywne = true;
                label_status.Text = "POŁĄCZONY";
                button_connect.Text = "ROZŁĄCZ";

                // rozpoczęcie wątku nasłuchującego przychodzących wiadomości
                ctThread = new Thread(getMessage);
                ctThread.Start();
            }
            else
            {
                byte[] outStream = Encoding.ASCII.GetBytes("BYE" + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                readData = "Rozłączono z serwerem";
                msg();

                polaczenia_aktywne = false;
                label_status.Text = "ROZŁĄCZONY";
                button_connect.Text = "POŁĄCZ";

                // odblokowanie pól tekstowych z danymi do połączenia
                text_IP.Enabled = true;

            }
        }
    }
}
