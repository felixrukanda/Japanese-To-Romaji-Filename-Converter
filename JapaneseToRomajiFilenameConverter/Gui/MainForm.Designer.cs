using JapaneseToRomajiFilenameConverter.Gui;

namespace JapaneseToRomajiFilenameConverter {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ConvertBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.DragDropLabel = new System.Windows.Forms.Label();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.totalFilesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedFilesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HistoryBTN = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.CheckBox();
            this.Title = new System.Windows.Forms.CheckBox();
            this.Artist = new System.Windows.Forms.CheckBox();
            this.Album = new System.Windows.Forms.CheckBox();
            this.AlbumArtist = new System.Windows.Forms.CheckBox();
            this.StartServerBTN = new System.Windows.Forms.Button();
            this.StopServerBTN = new System.Windows.Forms.Button();
            this.FilesBox = new JapaneseToRomajiFilenameConverter.Gui.FileBox();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertBTN
            // 
            this.ConvertBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertBTN.Enabled = false;
            this.ConvertBTN.Location = new System.Drawing.Point(1080, 12);
            this.ConvertBTN.Name = "ConvertBTN";
            this.ConvertBTN.Size = new System.Drawing.Size(117, 45);
            this.ConvertBTN.TabIndex = 1;
            this.ConvertBTN.Text = "Convert";
            this.ConvertBTN.UseVisualStyleBackColor = true;
            this.ConvertBTN.Click += new System.EventHandler(this.ConvertBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBTN.Location = new System.Drawing.Point(1080, 402);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(117, 35);
            this.AddBTN.TabIndex = 2;
            this.AddBTN.Text = "Add Files";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBTN.Enabled = false;
            this.RemoveBTN.Location = new System.Drawing.Point(1080, 443);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(117, 35);
            this.RemoveBTN.TabIndex = 3;
            this.RemoveBTN.Text = "Remove Files";
            this.RemoveBTN.UseVisualStyleBackColor = true;
            this.RemoveBTN.Click += new System.EventHandler(this.RemoveBTN_Click);
            // 
            // DragDropLabel
            // 
            this.DragDropLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragDropLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DragDropLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DragDropLabel.Location = new System.Drawing.Point(36, 37);
            this.DragDropLabel.Name = "DragDropLabel";
            this.DragDropLabel.Size = new System.Drawing.Size(1017, 444);
            this.DragDropLabel.TabIndex = 0;
            this.DragDropLabel.Text = "Drag and Drop Files";
            this.DragDropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearBTN
            // 
            this.ClearBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBTN.Enabled = false;
            this.ClearBTN.Location = new System.Drawing.Point(1080, 484);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(117, 35);
            this.ClearBTN.TabIndex = 3;
            this.ClearBTN.Text = "Clear Files";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalFilesLabel,
            this.selectedFilesLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 529);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1209, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "Status Strip";
            // 
            // totalFilesLabel
            // 
            this.totalFilesLabel.Name = "totalFilesLabel";
            this.totalFilesLabel.Size = new System.Drawing.Size(70, 17);
            this.totalFilesLabel.Text = "Total Files: 0";
            // 
            // selectedFilesLabel
            // 
            this.selectedFilesLabel.Name = "selectedFilesLabel";
            this.selectedFilesLabel.Size = new System.Drawing.Size(89, 17);
            this.selectedFilesLabel.Text = "Selected Files: 0";
            // 
            // HistoryBTN
            // 
            this.HistoryBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryBTN.Location = new System.Drawing.Point(1080, 63);
            this.HistoryBTN.Name = "HistoryBTN";
            this.HistoryBTN.Size = new System.Drawing.Size(117, 45);
            this.HistoryBTN.TabIndex = 1;
            this.HistoryBTN.Text = "View Conversion History";
            this.HistoryBTN.UseVisualStyleBackColor = true;
            this.HistoryBTN.Click += new System.EventHandler(this.HistoryBTN_Click);
            // 
            // FileName
            // 
            this.FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileName.AutoSize = true;
            this.FileName.Checked = true;
            this.FileName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FileName.Location = new System.Drawing.Point(1080, 124);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(108, 17);
            this.FileName.TabIndex = 6;
            this.FileName.Text = "Convert Filename";
            this.FileName.UseVisualStyleBackColor = true;
            this.FileName.CheckedChanged += new System.EventHandler(this.FileName_CheckedChanged);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Checked = true;
            this.Title.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Title.Location = new System.Drawing.Point(1080, 147);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(86, 17);
            this.Title.TabIndex = 7;
            this.Title.Text = "Convert Title";
            this.Title.UseVisualStyleBackColor = true;
            this.Title.CheckedChanged += new System.EventHandler(this.Title_CheckedChanged);
            // 
            // Artist
            // 
            this.Artist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Artist.AutoSize = true;
            this.Artist.Checked = true;
            this.Artist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Artist.Location = new System.Drawing.Point(1080, 170);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(89, 17);
            this.Artist.TabIndex = 8;
            this.Artist.Text = "Convert Artist";
            this.Artist.UseVisualStyleBackColor = true;
            this.Artist.CheckedChanged += new System.EventHandler(this.Artist_CheckedChanged);
            // 
            // Album
            // 
            this.Album.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Album.AutoSize = true;
            this.Album.Checked = true;
            this.Album.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Album.Location = new System.Drawing.Point(1080, 193);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(95, 17);
            this.Album.TabIndex = 9;
            this.Album.Text = "Convert Album";
            this.Album.UseVisualStyleBackColor = true;
            this.Album.CheckedChanged += new System.EventHandler(this.Album_CheckedChanged);
            // 
            // AlbumArtist
            // 
            this.AlbumArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumArtist.AutoSize = true;
            this.AlbumArtist.Checked = true;
            this.AlbumArtist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlbumArtist.Location = new System.Drawing.Point(1080, 216);
            this.AlbumArtist.Name = "AlbumArtist";
            this.AlbumArtist.Size = new System.Drawing.Size(121, 17);
            this.AlbumArtist.TabIndex = 10;
            this.AlbumArtist.Text = "Convert Album Artist";
            this.AlbumArtist.UseVisualStyleBackColor = true;
            this.AlbumArtist.CheckedChanged += new System.EventHandler(this.AlbumArtist_CheckedChanged);
            // 
            // StartServerBTN
            // 
            this.StartServerBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartServerBTN.Location = new System.Drawing.Point(1080, 251);
            this.StartServerBTN.Name = "StartServerBTN";
            this.StartServerBTN.Size = new System.Drawing.Size(117, 45);
            this.StartServerBTN.TabIndex = 11;
            this.StartServerBTN.Text = "Start Translator Server";
            this.StartServerBTN.UseVisualStyleBackColor = true;
            this.StartServerBTN.Click += new System.EventHandler(this.StartServerBTN_Click);
            // 
            // StopServerBTN
            // 
            this.StopServerBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopServerBTN.Location = new System.Drawing.Point(1080, 302);
            this.StopServerBTN.Name = "StopServerBTN";
            this.StopServerBTN.Size = new System.Drawing.Size(117, 45);
            this.StopServerBTN.TabIndex = 12;
            this.StopServerBTN.Text = "Stop Translator Server";
            this.StopServerBTN.UseVisualStyleBackColor = true;
            this.StopServerBTN.Click += new System.EventHandler(this.StopServerBTN_Click);
            // 
            // FilesBox
            // 
            this.FilesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilesBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilesBox.FormattingEnabled = true;
            this.FilesBox.HorizontalScrollbar = true;
            this.FilesBox.IntegralHeight = false;
            this.FilesBox.ItemHeight = 100;
            this.FilesBox.Location = new System.Drawing.Point(13, 13);
            this.FilesBox.Name = "FilesBox";
            this.FilesBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.FilesBox.Size = new System.Drawing.Size(1061, 505);
            this.FilesBox.TabIndex = 0;
            this.FilesBox.SelectedIndexChanged += new System.EventHandler(this.FilesBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 551);
            this.Controls.Add(this.StopServerBTN);
            this.Controls.Add(this.StartServerBTN);
            this.Controls.Add(this.AlbumArtist);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.DragDropLabel);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.HistoryBTN);
            this.Controls.Add(this.ConvertBTN);
            this.Controls.Add(this.FilesBox);
            this.MinimumSize = new System.Drawing.Size(433, 550);
            this.Name = "MainForm";
            this.Text = "Japanese to Romaji Filename Converter " + ProductVersion;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConvertBTN;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button RemoveBTN;
        private System.Windows.Forms.Label DragDropLabel;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel totalFilesLabel;
        private System.Windows.Forms.ToolStripStatusLabel selectedFilesLabel;
        private System.Windows.Forms.Button HistoryBTN;
        private FileBox FilesBox;
        private System.Windows.Forms.CheckBox FileName;
        private System.Windows.Forms.CheckBox Title;
        private System.Windows.Forms.CheckBox Artist;
        private System.Windows.Forms.CheckBox Album;
        private System.Windows.Forms.CheckBox AlbumArtist;
        private System.Windows.Forms.Button StartServerBTN;
        private System.Windows.Forms.Button StopServerBTN;
    }
}

