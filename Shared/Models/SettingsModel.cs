using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    public class SettingsModel
    {
        [XmlIgnore]
        public Exception Ex { get; internal set; }
        public string DataFolder { get; set; }
        [XmlAttribute]
        public int Size { get; set; }
        [XmlAttribute]
        public bool Change { get; set; }
        [XmlAttribute]
        public bool Subtract { get; set; }
        [XmlAttribute]
        public bool Archive { get; set; }
        [XmlAttribute]
        public bool Statistic { get; set; }
        public long DataSize { get; set; }

        public bool Serialize(string settingsFile)
        {
            var ser = new XmlSerializer(GetType());
            try
            {
                using (var stream = new StreamWriter(settingsFile))
                {
                    ser.Serialize(stream, this);
                    Ex = null;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Ex = ex;
            }
            return false;
        }


        public static SettingsModel Deserialize(string settingsFile)
        {
            var ser = new XmlSerializer(typeof(SettingsModel));
            if (File.Exists(settingsFile))
            {
                try
                {
                    using (var stream = new StreamReader(settingsFile))
                    {
                        return ser.Deserialize(stream) as SettingsModel;
                    }
                }
                catch (Exception ex)
                {
                    return new SettingsModel { Ex = ex };
                }
            }
            return new SettingsModel { Ex = new Exception("Settings file was not found") };
        }
    }
}
