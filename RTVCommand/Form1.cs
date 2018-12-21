using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RTVCommand.Core;
using RTVCommand.Objects;

namespace RTVCommand
{
    //Probably tacky to leave this as Form1 "but you're just gonna power through it aren't you"
    public partial class Form1 : Form
    {
        //Setup our Managers
        public ConfigManager ConfigManager;
        public MediaLibrary MediaLibrary;

        //MAIN INSERT
        public Form1()
        {
            //Init Config - this creates the manager and generates the managed object
            ConfigManager = new ConfigManager();

            MediaLibrary = new MediaLibrary(ConfigManager.ProgramPath);

            //Start the Form, Buttons, Labels, etc
            InitializeComponent();

            //We'll want to ensure we're selecting the entire row as each row represents a complete Media object
            dgvMediaViewer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlaylistViewer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Populate values for DGVs and Text Labels
            RefreshMediaLibraryGrid();
            RefreshPlaylistGrid();
            RefreshTextLabels();            
        }

        //Updates the MediaLibrary DGV
        private void RefreshMediaLibraryGrid()
        {
            

            //Populate the columns if none
            if (dgvMediaViewer.Rows.Count <= 0)
            {
                DataGridViewCell cell = new DataGridViewTextBoxCell();

                DataGridViewColumn dc1 = new DataGridViewColumn()
                {
                    CellTemplate = cell,
                    Name = "Name",
                    ValueType = typeof(string)
                };

                DataGridViewColumn dc2 = new DataGridViewColumn()
                {
                    CellTemplate = cell,
                    Name = "Length",
                    ValueType = typeof(int)
                };
                
                dgvMediaViewer.Columns.Add(dc1);
                dgvMediaViewer.Columns.Add(dc2);
            }            

            //Populate new rows - Invoke Media object from the CurrentLibrary
            foreach(Media media in MediaLibrary.CurrentLibrary)
            {
                dgvMediaViewer.Rows.Add(media.Name, media.Length.TotalSeconds + " seconds");
            }
        }

        private void RefreshPlaylistGrid()
        {

        }

        //This function will update all text labels
        private void RefreshTextLabels()
        {
            txtPlayerPath.Text = ConfigManager.configuration.PlayerPath;
        }

        //Button Event Handlers
        //Scheduler
        private void btnAddToSchedule_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromSchedule_Click(object sender, EventArgs e)
        {

        }

        private void btnConfigurePlayer_Click(object sender, EventArgs e)
        {
            //Allow the user to select a media player EXE, and record it to the Configuration.
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Title = "Select media player...",
                Filter = "exe files (*.exe)|*.exe",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                InitialDirectory = @"C:\"            
            };

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                ConfigManager.configuration.PlayerPath = fileDialog.FileName;
                RefreshTextLabels();
            }
    }

        //Playlist Configurations
        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletePlaylist_Click(object sender, EventArgs e)
        {

        }

        //Media Operations
        //This button invokes the OpenFileDialog to add the selected media files to the MediaLibrary.
        private void btnAddNewMedia_Click(object sender, EventArgs e)
        {
            //Allow the user to select one or more media files and add them into the library
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Title = "Select media...",
                Filter = "Media Files|*.mkv,*.mpg;*.mpeg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3;*.wmv|All Files|*.*",
                FilterIndex = 1,
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = true,
                //InitialDirectory = @"C:\"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in fileDialog.FileNames)
                {
                    MediaLibrary.AddToLibrary(file);
                }
            }

            //Refresh the GridView
            RefreshMediaLibraryGrid();
        }

        //Remove media from the library
        private void btnRemoveMedia_Click(object sender, EventArgs e)
        {
            if(dgvMediaViewer.SelectedRows.Count > 0)
            {
                //Remove it from the backend
                for(int x = 0; x < dgvMediaViewer.SelectedRows.Count; x++)
                {
                    Media item = new Media();
                    item.Name = (string)dgvMediaViewer.SelectedRows[x].Cells[0].Value;
                    //System.Diagnostics.Debug.WriteLine(item.Name);
                    MediaLibrary.RemoveFromLibrary(item);
                }

                //Then take it out of the DGV
                foreach (DataGridViewRow row in dgvMediaViewer.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvMediaViewer.Rows.RemoveAt(row.Index);
                    }
                }

                //No need to refresh
                //RefreshMediaLibraryGrid();
            }
            else
            {
                //if no rows are selected somehow
                string message = "Select an item to remove.";
                MessageBox.Show(message);
            }

        }

        //Filter the DGV 
        private void btnFilterSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnEditMediaMetadata_Click(object sender, EventArgs e)
        {

        }

        //Before shutdown, save the configuration
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigManager.SaveConfiguration();
            MediaLibrary.SaveLibrary();
        }
    }
}
