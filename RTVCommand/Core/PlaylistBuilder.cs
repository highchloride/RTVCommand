using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using RTVCommand.Objects;

namespace RTVCommand.Core
{
    public class PlaylistBuilder
    {


        public PlaylistBuilder()
        {

        }

        /// <summary>
        /// Write the existing CurrentLibrary to _rtvLibraryFile.
        /// </summary>
        public void SavePlaylist(string file, Playlist playlist)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, playlist);
            }
        }

        /// <summary>
        /// Load in the existing _rtvLibraryFile to the CurrentLibrary. If no _rtvLibraryFile exists, one will be created.
        /// </summary>
        public Playlist LoadPlaylist(string file)
        {
            Playlist loadedList = new Playlist();
            if (File.Exists(file))
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    loadedList = (Playlist)formatter.Deserialize(stream);
                }
                return loadedList;
            }
            else
            {
                return null;
            }
        }
    }
}
