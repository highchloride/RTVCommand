using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTVCommand.Objects
{
    /// <summary>
    /// This is the object which holds all configuration variables for the software. It is serializable and stored in a file called rtvconfig.dat.
    /// Access Configuration as a child of ConfigManager.
    /// </summary>
    [Serializable]
    public class Configuration
    {
        public string PlayerPath;
    }
}
