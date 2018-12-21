using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTVCommand.Interfaces;

namespace RTVCommand.Objects
{
    /// <summary>
    /// Base Media class
    /// </summary>
    [Serializable]
    public class Media
    {
        //Basic properties
        public string Name { get; set; }
        public string MediaPath { get; set; }
        public string MediaExtension { get; set; }

        //File metadata
        public TimeSpan Length { get; set; }
        public string Encoding { get; set; }

        //RTV metadata
        public DateTime DateAdded { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public int TimesPlayed { get; set; }        
    }
}
