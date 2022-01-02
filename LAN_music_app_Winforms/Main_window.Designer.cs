﻿
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.VLCPlugin = new AxAXVLC.AxVLCPlugin2();
            this.list_playlist = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_start_server = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_connected = new System.Windows.Forms.Label();
            this.textBox_czas = new System.Windows.Forms.TextBox();
            this.button_set = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_left.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlugin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_left.Controls.Add(this.label_connected);
            this.panel_left.Controls.Add(this.label1);
            this.panel_left.Controls.Add(this.button_next);
            this.panel_left.Controls.Add(this.button_start);
            this.panel_left.Controls.Add(this.button_start_server);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(139, 377);
            this.panel_left.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.button_set);
            this.panel_main.Controls.Add(this.textBox_czas);
            this.panel_main.Controls.Add(this.progressBar);
            this.panel_main.Controls.Add(this.list_playlist);
            this.panel_main.Controls.Add(this.VLCPlugin);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(139, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(389, 377);
            this.panel_main.TabIndex = 1;
            // 
            // VLCPlugin
            // 
            this.VLCPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VLCPlugin.Enabled = true;
            this.VLCPlugin.Location = new System.Drawing.Point(33, 25);
            this.VLCPlugin.Name = "VLCPlugin";
            this.VLCPlugin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VLCPlugin.OcxState")));
            this.VLCPlugin.Size = new System.Drawing.Size(321, 156);
            this.VLCPlugin.TabIndex = 0;
            // 
            // list_playlist
            // 
            this.list_playlist.FormattingEnabled = true;
            this.list_playlist.Location = new System.Drawing.Point(33, 255);
            this.list_playlist.Name = "list_playlist";
            this.list_playlist.Size = new System.Drawing.Size(321, 95);
            this.list_playlist.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(33, 187);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(321, 23);
            this.progressBar.TabIndex = 2;
            // 
            // button_start_server
            // 
            this.button_start_server.Location = new System.Drawing.Point(26, 25);
            this.button_start_server.Name = "button_start_server";
            this.button_start_server.Size = new System.Drawing.Size(75, 23);
            this.button_start_server.TabIndex = 0;
            this.button_start_server.Text = "URUCHOM";
            this.button_start_server.UseVisualStyleBackColor = true;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(26, 187);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(26, 226);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "NEXT";
            this.button_next.UseVisualStyleBackColor = true;
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
            // textBox_czas
            // 
            this.textBox_czas.Location = new System.Drawing.Point(146, 216);
            this.textBox_czas.Name = "textBox_czas";
            this.textBox_czas.Size = new System.Drawing.Size(100, 20);
            this.textBox_czas.TabIndex = 3;
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(253, 216);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(75, 23);
            this.button_set.TabIndex = 4;
            this.button_set.Text = "USTAW";
            this.button_set.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odtwarzana minuta:";
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 377);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_left);
            this.Name = "Main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAN music app";
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlugin)).EndInit();
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox list_playlist;
        private AxAXVLC.AxVLCPlugin2 VLCPlugin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.TextBox textBox_czas;
    }
}
