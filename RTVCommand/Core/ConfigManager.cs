using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using RTVCommand.Objects;

namespace RTVCommand.Core
{
    /// <summary>
    /// The ConfigManager handles saving/loading the RTVconfig.dat file. It will generate a new one if none exists.
    /// The Configuration object is a child of this class. Change Configuration values via ConfigManager.Configuration.value.
    /// </summary>
    public class ConfigManager
    {
        //privates
        private string _programPath;

        //Internal to this class
        private const string _rtvConfigPath = @"\data\";
        private const string _rtvConfigFile = "RTVconfig.dat";

        //Accessors
        public string ProgramPath { get { return _programPath; } set { _programPath = value; } }

        //Generate the Configuration class
        public Configuration configuration = new Configuration();

        //Constructors
        public ConfigManager()
        {
            ProgramPath = Directory.GetCurrentDirectory();
            LoadConfiguration();           
        }

        //Write the config data out
        public void SaveConfiguration()
        {
            IFormatter formatter = new BinaryFormatter();
            using(Stream stream = new FileStream(ProgramPath + _rtvConfigPath + _rtvConfigFile, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, configuration);
            }            
        }

        //Load existing config data
        public void LoadConfiguration()
        {
            if(File.Exists(ProgramPath + _rtvConfigPath + _rtvConfigFile))
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(ProgramPath + _rtvConfigPath + _rtvConfigFile, FileMode.Open, FileAccess.Read))
                {
                    configuration = (Configuration)formatter.Deserialize(stream);
                }
            }
            else
            {
                if(!Directory.Exists(ProgramPath + _rtvConfigPath))
                {
                    Directory.CreateDirectory(ProgramPath + _rtvConfigPath);
                }

                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(ProgramPath + _rtvConfigPath + _rtvConfigFile, FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, configuration);
                }
            }
        }
    }
}
