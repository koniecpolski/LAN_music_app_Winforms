
namespace LAN_music_app_Winforms
{
    partial class Main_window
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_window));
            this.panel_left = new System.Windows.Forms.Panel();
            this.label_connected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_start_server = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_played = new System.Windows.Forms.TextBox();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.label2 = new System.Windows.Forms.Label();
            this.button_set = new System.Windows.Forms.Button();
            this.textBox_czas = new System.Windows.Forms.TextBox();
            this.list_playlist = new System.Windows.Forms.ListBox();
            this.panel_left.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_left.Controls.Add(this.label_connected);
            this.panel_left.Controls.Add(this.label1);
            this.panel_left.Controls.Add(this.button_start_server);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(139, 344);
            this.panel_left.TabIndex = 0;
            // 
            // label_connected
            // 
            this.label_connected.AutoSize = true;
            this.label_connected.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_connected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_connected.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_connected.Location = new System.Drawing.Point(57, 79);
            this.label_connected.Name = "label_connected";
            this.label_connected.Size = new System.Drawing.Size(19, 20);
            this.label_connected.TabIndex = 4;
            this.label_connected.Text = "0";
            this.label_connected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczba połączonych";
            // 
            // button_start_server
            // 
            this.button_start_server.Location = new System.Drawing.Point(32, 25);
            this.button_start_server.Name = "button_start_server";
            this.button_start_server.Size = new System.Drawing.Size(75, 34);
            this.button_start_server.TabIndex = 0;
            this.button_start_server.Text = "URUCHOM\r\nSERWER";
            this.button_start_server.UseVisualStyleBackColor = true;
            this.button_start_server.Click += new System.EventHandler(this.button_start_server_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(114, 71);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "NEXT";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(33, 71);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_main.Controls.Add(this.button_stop);
            this.panel_main.Controls.Add(this.button_pause);
            this.panel_main.Controls.Add(this.label5);
            this.panel_main.Controls.Add(this.label4);
            this.panel_main.Controls.Add(this.button_dodaj);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.button_next);
            this.panel_main.Controls.Add(this.text_played);
            this.panel_main.Controls.Add(this.button_start);
            this.panel_main.Controls.Add(this.vlcControl1);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.button_set);
            this.panel_main.Controls.Add(this.textBox_czas);
            this.panel_main.Controls.Add(this.list_playlist);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(139, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(389, 344);
            this.panel_main.TabIndex = 1;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(278, 72);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 13;
            this.button_stop.Text = "STOP";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(196, 72);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(75, 23);
            this.button_pause.TabIndex = 12;
            this.button_pause.Text = "PAUZA";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lista plików do odtwarzania:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aby dodać plik, przeciągnij go i upuść \r\nlub skorzystaj z przycisku:\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_dodaj
            // 
            this.button_dodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_dodaj.Location = new System.Drawing.Point(279, 301);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(75, 23);
            this.button_dodaj.TabIndex = 9;
            this.button_dodaj.Text = "DODAJ";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Odtwarzany utwór:";
            // 
            // text_played
            // 
            this.text_played.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_played.Location = new System.Drawing.Point(33, 45);
            this.text_played.Name = "text_played";
            this.text_played.ReadOnly = true;
            this.text_played.Size = new System.Drawing.Size(321, 20);
            this.text_played.TabIndex = 7;
            // 
            // vlcControl1
            // 
            this.vlcControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(372, 12);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(5, 5);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 6;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.Visible = false;
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odtwarzana minuta:";
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(142, 127);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(75, 23);
            this.button_set.TabIndex = 4;
            this.button_set.Text = "USTAW";
            this.button_set.UseVisualStyleBackColor = true;
            // 
            // textBox_czas
            // 
            this.textBox_czas.Location = new System.Drawing.Point(36, 130);
            this.textBox_czas.Name = "textBox_czas";
            this.textBox_czas.Size = new System.Drawing.Size(100, 20);
            this.textBox_czas.TabIndex = 3;
            // 
            // list_playlist
            // 
            this.list_playlist.AllowDrop = true;
            this.list_playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_playlist.FormattingEnabled = true;
            this.list_playlist.Location = new System.Drawing.Point(33, 197);
            this.list_playlist.Name = "list_playlist";
            this.list_playlist.Size = new System.Drawing.Size(321, 95);
            this.list_playlist.TabIndex = 1;
            this.list_playlist.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_playlist_DragDrop);
            this.list_playlist.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_playlist_DragEnter);
            this.list_playlist.DoubleClick += new System.EventHandler(this.list_playlist_DoubleClick);
            this.list_playlist.KeyUp += new System.Windows.Forms.KeyEventHandler(this.list_playlist_KeyUp);
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 344);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_left);
            this.Name = "Main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAN music app";
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_connected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_start_server;
        private System.Windows.Forms.ListBox list_playlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.TextBox textBox_czas;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_played;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_pause;
    }
}

