using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using RTVCommand.Objects;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System.Windows.Forms;

namespace RTVCommand.Core
{
    /// <summary>
    /// The MediaLibrary is what it says on the tin, managing the CurrentLibrary list of Media objects. 
    /// CurrentLibrary is saved/loaded on startup/shutdown.
    /// </summary>
    public class MediaLibrary
    {
        //Internal to this class
        private string ProgramPath;
        private const string _rtvConfigPath = @"\data\";
        private const string _rtvLibraryFile = "RTVlibrary.dat";

        public List<Media> CurrentLibrary = new List<Media>();

        public MediaLibrary(string programPath)
        {
            ProgramPath = programPath;
            LoadLibrary();
        }

        /// <summary>
        /// Populates a Media object with the provided full-path file string, then adds it to the CurrentLibrary.
        /// </summary>
        /// <param name="file"></param>
        public void AddToLibrary(string file)
        {
            FileInfo fileInfo = new FileInfo(file);

            //First, we'll make a Media object
            Media media = new Media();
            media.Name = Path.GetFileNameWithoutExtension(fileInfo.Name);            
            media.MediaPath = fileInfo.DirectoryName;
            media.MediaExtension = fileInfo.Extension;
            

            //Retreive the media properties via the WindowsAPICodePack Nuget package
            //Grants direct shell access to values
            using (var shell = ShellObject.FromParsingName(file))
            {
                IShellProperty duration = shell.Properties.System.Media.Duration;
                var t = (ulong)duration.ValueAsObject;
                media.Length = TimeSpan.FromTicks((long)t);

                //Ensure values aren't null before adding them to prevent crashes
                IShellProperty encoding = shell.Properties.System.Media.EncodedBy;
                if(encoding.ValueAsObject != null)
                {
                    var e = (string)encoding.ValueAsObject;
                    media.Encoding = e;
                }
                
            }

            //Add the processed Media object to the Library list
            CurrentLibrary.Add(media);
        }

        /// <summary>
        /// Scans the CurrentLibrary for passed Media object. If found, it'll be removed.
        /// </summary>
        /// <param name="media"></param>
        public void RemoveFromLibrary(Media media)
        {
            var mediaToRemove = CurrentLibrary.FirstOrDefault(m => m.Name == media.Name);
            if(mediaToRemove != null)
            {
                CurrentLibrary.Remove(mediaToRemove);
            }
        }

        //Create Media Library Columns
        public void CreateLibraryColumns(DataGridView dataGridView)
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

            DataGridViewColumn dc3 = new DataGridViewColumn()
            {
                CellTemplate = cell,
                Name = "Extension",
                ValueType = typeof(string)
            };

            DataGridViewColumn dc4 = new DataGridViewColumn()
            {
                CellTemplate = cell,
                Name = "Category",
                ValueType = typeof(string)
            };

            DataGridViewColumn dc5 = new DataGridViewColumn()
            {
                CellTemplate = cell,
                Name = "SubCategory",
                ValueType = typeof(string)
            };

            dataGridView.Columns.Add(dc1);
            dataGridView.Columns.Add(dc2);
            dataGridView.Columns.Add(dc3);
            dataGridView.Columns.Add(dc4);
            dataGridView.Columns.Add(dc5);
        }

        /// <summary>
        /// Write the existing CurrentLibrary to _rtvLibraryFile.
        /// </summary>
        public void SaveLibrary()
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(ProgramPath + _rtvConfigPath + _rtvLibraryFile, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, CurrentLibrary);
            }
        }

        /// <summary>
        /// Load in the existing _rtvLibraryFile to the CurrentLibrary. If no _rtvLibraryFile exists, one will be created.
        /// </summary>
        public void LoadLibrary()
        {
            if (File.Exists(ProgramPath + _rtvConfigPath + _rtvLibraryFile))
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(ProgramPath + _rtvConfigPath + _rtvLibraryFile, FileMode.Open, FileAccess.Read))
                {
                    CurrentLibrary = (List<Media>)formatter.Deserialize(stream);
                }
            }
            else
            {
                if (!Directory.Exists(ProgramPath + _rtvConfigPath))
                {
                    Directory.CreateDirectory(ProgramPath + _rtvConfigPath);
                }

                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(ProgramPath + _rtvConfigPath + _rtvLibraryFile, FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, CurrentLibrary);
                }
            }
        }
    }
}
