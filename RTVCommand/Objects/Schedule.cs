using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTVCommand.Objects
{
    public class Schedule
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public string TargetPlaylist { get; set; }
    }
}
