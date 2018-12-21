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

namespace RTVCommand.Core
{
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

        //Add a file to the library - accepts a full path to the media file
        public void AddToLibrary(string file)
        {
            FileInfo fileInfo = new FileInfo(file);

            //First, we'll make a Media object
            Media media = new Media();
            media.Name = fileInfo.Name;
            media.MediaPath = fileInfo.DirectoryName;

            //Retreive the duration via the WindowsAPICodePack Nuget package
            //Grants direct shell access to values and we can probably get much more than just the length
            using (var shell = ShellObject.FromParsingName(file))
            {
                IShellProperty duration = shell.Properties.System.Media.Duration;
                var t = (ulong)duration.ValueAsObject;
                media.Length = TimeSpan.FromTicks((long)t);
            }

            //Add the processed Media object to the Library list
            CurrentLibrary.Add(media);
        }

        //Remove a file from the library
        public void RemoveFromLibrary(Media media)
        {
            var mediaToRemove = CurrentLibrary.FirstOrDefault(m => m.Name == media.Name);
            if(mediaToRemove != null)
            {
                CurrentLibrary.Remove(mediaToRemove);
            }
        }

        //Update DGV
        public void UpdateLibraryView()
        {
            foreach(Media media in CurrentLibrary)
            {
                System.Diagnostics.Debug.WriteLine(media.Name);
            }
        }

        //Write the library data out
        public void SaveLibrary()
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(ProgramPath + _rtvConfigPath + _rtvLibraryFile, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, CurrentLibrary);
            }
        }

        //Load existing library data
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
