
namespace LAN_music_app_Winforms_client
{
    partial class Main_window_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_window_client));
            this.panel_bot = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_IP = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.label2 = new System.Windows.Forms.Label();
            this.list_log = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_played = new System.Windows.Forms.TextBox();
            this.panel_bot.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bot
            // 
            this.panel_bot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_bot.Controls.Add(this.label_status);
            this.panel_bot.Controls.Add(this.label1);
            this.panel_bot.Controls.Add(this.text_IP);
            this.panel_bot.Controls.Add(this.button_connect);
            this.panel_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bot.Location = new System.Drawing.Point(0, 212);
            this.panel_bot.Name = "panel_bot";
            this.panel_bot.Size = new System.Drawing.Size(407, 79);
            this.panel_bot.TabIndex = 0;
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_status.Location = new System.Drawing.Point(248, 37);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(149, 20);
            this.label_status.TabIndex = 3;
            this.label_status.Text = "NIEPOŁĄCZONY";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adres IP Serwera:";
            // 
            // text_IP
            // 
            this.text_IP.Location = new System.Drawing.Point(44, 39);
            this.text_IP.Name = "text_IP";
            this.text_IP.Size = new System.Drawing.Size(117, 20);
            this.text_IP.TabIndex = 1;
            this.text_IP.Text = "192.168.0.38";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(167, 37);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "POŁĄCZ";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_main.Controls.Add(this.vlcControl1);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.list_log);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.text_played);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(407, 212);
            this.panel_main.TabIndex = 1;
            // 
            // vlcControl1
            // 
            this.vlcControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(390, 12);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(5, 5);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 13;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.Visible = false;
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Historia:";
            // 
            // list_log
            // 
            this.list_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_log.FormattingEnabled = true;
            this.list_log.Location = new System.Drawing.Point(44, 91);
            this.list_log.Name = "list_log";
            this.list_log.Size = new System.Drawing.Size(321, 95);
            this.list_log.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Odtwarzany utwór:";
            // 
            // text_played
            // 
            this.text_played.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_played.Location = new System.Drawing.Point(44, 43);
            this.text_played.Name = "text_played";
            this.text_played.ReadOnly = true;
            this.text_played.Size = new System.Drawing.Size(321, 20);
            this.text_played.TabIndex = 9;
            // 
            // Main_window_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 291);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_bot);
            this.Name = "Main_window_client";
            this.Text = "LAN music app";
            this.panel_bot.ResumeLayout(false);
            this.panel_bot.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_bot;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_played;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_IP;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_log;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
    }
}

