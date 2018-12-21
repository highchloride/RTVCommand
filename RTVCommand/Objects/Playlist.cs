using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTVCommand.Objects
{
    public class Playlist
    {
        public DateTime PlaylistDate { get { return PlaylistDate; } set { PlaylistDate = value.Date; } }
        public string PlaylistPeriod { get; set; }
        public List<Media> PlaylistItems { get; set; }
    }
}
