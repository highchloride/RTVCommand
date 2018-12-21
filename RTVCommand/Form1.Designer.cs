namespace RTVCommand
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeletePlaylist = new System.Windows.Forms.Button();
            this.btnLoadPlaylist = new System.Windows.Forms.Button();
            this.btnSavePlaylist = new System.Windows.Forms.Button();
            this.btnNewPlaylist = new System.Windows.Forms.Button();
            this.dgvPlaylistViewer = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditMediaMetadata = new System.Windows.Forms.Button();
            this.btnFilterSettings = new System.Windows.Forms.Button();
            this.dgvMediaViewer = new System.Windows.Forms.DataGridView();
            this.btnAddNewMedia = new System.Windows.Forms.Button();
            this.btnRemoveMedia = new System.Windows.Forms.Button();
            this.dgvScheduleControl = new System.Windows.Forms.DataGridView();
            this.btnConfigurePlayer = new System.Windows.Forms.Button();
            this.btnRemoveFromSchedule = new System.Windows.Forms.Button();
            this.btnAddToSchedule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerPath = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistViewer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediaViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleControl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPlayerPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConfigurePlayer);
            this.groupBox1.Controls.Add(this.dgvScheduleControl);
            this.groupBox1.Controls.Add(this.btnRemoveFromSchedule);
            this.groupBox1.Controls.Add(this.btnAddToSchedule);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scheduler Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeletePlaylist);
            this.groupBox2.Controls.Add(this.btnLoadPlaylist);
            this.groupBox2.Controls.Add(this.btnSavePlaylist);
            this.groupBox2.Controls.Add(this.btnNewPlaylist);
            this.groupBox2.Controls.Add(this.dgvPlaylistViewer);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(867, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playlist Builder";
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.Location = new System.Drawing.Point(347, 164);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(81, 23);
            this.btnDeletePlaylist.TabIndex = 4;
            this.btnDeletePlaylist.Text = "Delete Playlist";
            this.btnDeletePlaylist.UseVisualStyleBackColor = true;
            this.btnDeletePlaylist.Click += new System.EventHandler(this.btnDeletePlaylist_Click);
            // 
            // btnLoadPlaylist
            // 
            this.btnLoadPlaylist.Location = new System.Drawing.Point(229, 164);
            this.btnLoadPlaylist.Name = "btnLoadPlaylist";
            this.btnLoadPlaylist.Size = new System.Drawing.Size(93, 23);
            this.btnLoadPlaylist.TabIndex = 3;
            this.btnLoadPlaylist.Text = "Load Playlist...";
            this.btnLoadPlaylist.UseVisualStyleBackColor = true;
            this.btnLoadPlaylist.Click += new System.EventHandler(this.btnLoadPlaylist_Click);
            // 
            // btnSavePlaylist
            // 
            this.btnSavePlaylist.Location = new System.Drawing.Point(119, 164);
            this.btnSavePlaylist.Name = "btnSavePlaylist";
            this.btnSavePlaylist.Size = new System.Drawing.Size(85, 23);
            this.btnSavePlaylist.TabIndex = 2;
            this.btnSavePlaylist.Text = "Save Playlist...";
            this.btnSavePlaylist.UseVisualStyleBackColor = true;
            this.btnSavePlaylist.Click += new System.EventHandler(this.btnSavePlaylist_Click);
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.Location = new System.Drawing.Point(19, 164);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(75, 23);
            this.btnNewPlaylist.TabIndex = 1;
            this.btnNewPlaylist.Text = "New Playlist";
            this.btnNewPlaylist.UseVisualStyleBackColor = true;
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // dgvPlaylistViewer
            // 
            this.dgvPlaylistViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylistViewer.Location = new System.Drawing.Point(7, 20);
            this.dgvPlaylistViewer.Name = "dgvPlaylistViewer";
            this.dgvPlaylistViewer.Size = new System.Drawing.Size(854, 138);
            this.dgvPlaylistViewer.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditMediaMetadata);
            this.groupBox3.Controls.Add(this.btnFilterSettings);
            this.groupBox3.Controls.Add(this.dgvMediaViewer);
            this.groupBox3.Controls.Add(this.btnAddNewMedia);
            this.groupBox3.Controls.Add(this.btnRemoveMedia);
            this.groupBox3.Location = new System.Drawing.Point(12, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(867, 204);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Media Browser";
            // 
            // btnEditMediaMetadata
            // 
            this.btnEditMediaMetadata.Location = new System.Drawing.Point(383, 168);
            this.btnEditMediaMetadata.Name = "btnEditMediaMetadata";
            this.btnEditMediaMetadata.Size = new System.Drawing.Size(81, 23);
            this.btnEditMediaMetadata.TabIndex = 9;
            this.btnEditMediaMetadata.Text = "Edit Metadata";
            this.btnEditMediaMetadata.UseVisualStyleBackColor = true;
            this.btnEditMediaMetadata.Click += new System.EventHandler(this.btnEditMediaMetadata_Click);
            // 
            // btnFilterSettings
            // 
            this.btnFilterSettings.Location = new System.Drawing.Point(267, 168);
            this.btnFilterSettings.Name = "btnFilterSettings";
            this.btnFilterSettings.Size = new System.Drawing.Size(81, 23);
            this.btnFilterSettings.TabIndex = 8;
            this.btnFilterSettings.Text = "Filter Settings";
            this.btnFilterSettings.UseVisualStyleBackColor = true;
            this.btnFilterSettings.Click += new System.EventHandler(this.btnFilterSettings_Click);
            // 
            // dgvMediaViewer
            // 
            this.dgvMediaViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMediaViewer.Location = new System.Drawing.Point(7, 19);
            this.dgvMediaViewer.Name = "dgvMediaViewer";
            this.dgvMediaViewer.Size = new System.Drawing.Size(854, 143);
            this.dgvMediaViewer.TabIndex = 1;
            // 
            // btnAddNewMedia
            // 
            this.btnAddNewMedia.Location = new System.Drawing.Point(19, 168);
            this.btnAddNewMedia.Name = "btnAddNewMedia";
            this.btnAddNewMedia.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewMedia.TabIndex = 5;
            this.btnAddNewMedia.Text = "Add New...";
            this.btnAddNewMedia.UseVisualStyleBackColor = true;
            this.btnAddNewMedia.Click += new System.EventHandler(this.btnAddNewMedia_Click);
            // 
            // btnRemoveMedia
            // 
            this.btnRemoveMedia.Location = new System.Drawing.Point(129, 168);
            this.btnRemoveMedia.Name = "btnRemoveMedia";
            this.btnRemoveMedia.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveMedia.TabIndex = 6;
            this.btnRemoveMedia.Text = "Remove Media";
            this.btnRemoveMedia.UseVisualStyleBackColor = true;
            this.btnRemoveMedia.Click += new System.EventHandler(this.btnRemoveMedia_Click);
            // 
            // dgvScheduleControl
            // 
            this.dgvScheduleControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduleControl.Location = new System.Drawing.Point(7, 19);
            this.dgvScheduleControl.Name = "dgvScheduleControl";
            this.dgvScheduleControl.Size = new System.Drawing.Size(854, 91);
            this.dgvScheduleControl.TabIndex = 5;
            // 
            // btnConfigurePlayer
            // 
            this.btnConfigurePlayer.Location = new System.Drawing.Point(291, 116);
            this.btnConfigurePlayer.Name = "btnConfigurePlayer";
            this.btnConfigurePlayer.Size = new System.Drawing.Size(136, 23);
            this.btnConfigurePlayer.TabIndex = 7;
            this.btnConfigurePlayer.Text = "Configure Media Player";
            this.btnConfigurePlayer.UseVisualStyleBackColor = true;
            this.btnConfigurePlayer.Click += new System.EventHandler(this.btnConfigurePlayer_Click);
            // 
            // btnRemoveFromSchedule
            // 
            this.btnRemoveFromSchedule.Enabled = false;
            this.btnRemoveFromSchedule.Location = new System.Drawing.Point(142, 116);
            this.btnRemoveFromSchedule.Name = "btnRemoveFromSchedule";
            this.btnRemoveFromSchedule.Size = new System.Drawing.Size(127, 23);
            this.btnRemoveFromSchedule.TabIndex = 6;
            this.btnRemoveFromSchedule.Text = "Remove from Schedule";
            this.btnRemoveFromSchedule.UseVisualStyleBackColor = true;
            this.btnRemoveFromSchedule.Click += new System.EventHandler(this.btnRemoveFromSchedule_Click);
            // 
            // btnAddToSchedule
            // 
            this.btnAddToSchedule.Enabled = false;
            this.btnAddToSchedule.Location = new System.Drawing.Point(19, 116);
            this.btnAddToSchedule.Name = "btnAddToSchedule";
            this.btnAddToSchedule.Size = new System.Drawing.Size(101, 23);
            this.btnAddToSchedule.TabIndex = 5;
            this.btnAddToSchedule.Text = "Add to Schedule";
            this.btnAddToSchedule.UseVisualStyleBackColor = true;
            this.btnAddToSchedule.Click += new System.EventHandler(this.btnAddToSchedule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Media Player Path:";
            // 
            // txtPlayerPath
            // 
            this.txtPlayerPath.AutoEllipsis = true;
            this.txtPlayerPath.Location = new System.Drawing.Point(537, 121);
            this.txtPlayerPath.Name = "txtPlayerPath";
            this.txtPlayerPath.Size = new System.Drawing.Size(324, 18);
            this.txtPlayerPath.TabIndex = 9;
            this.txtPlayerPath.Text = "C:\\Path\\To\\Player.exe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 585);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RTV Command";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistViewer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediaViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPlaylistViewer;
        private System.Windows.Forms.Button btnDeletePlaylist;
        private System.Windows.Forms.Button btnLoadPlaylist;
        private System.Windows.Forms.Button btnSavePlaylist;
        private System.Windows.Forms.Button btnNewPlaylist;
        private System.Windows.Forms.Button btnEditMediaMetadata;
        private System.Windows.Forms.Button btnFilterSettings;
        private System.Windows.Forms.DataGridView dgvMediaViewer;
        private System.Windows.Forms.Button btnAddNewMedia;
        private System.Windows.Forms.Button btnRemoveMedia;
        private System.Windows.Forms.Label txtPlayerPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigurePlayer;
        private System.Windows.Forms.DataGridView dgvScheduleControl;
        private System.Windows.Forms.Button btnRemoveFromSchedule;
        private System.Windows.Forms.Button btnAddToSchedule;
    }
}

