using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangCayCanh
{
    public class Common
    {
        public static int CheckEmptyId(DataTable dt, string columOfId)
        {
            int number = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i != GetNumberOfId(dt.Rows[i][columOfId].ToString()))
                {
                    number = i; break;
                }
            }
            return number == 0 ? GetMaxId(dt, columOfId) + 1 : number;
        }

        public static int GetNumberOfId(string strId)
        {
            return int.Parse(strId.Split('_')[1]);
        }

        public static int GetMaxId(DataTable dt, string columOfId)
        {
            if(dt.Rows.Count < 1)
            {
                return -1;
            }
            int maxId = GetNumberOfId(dt.Rows[0][columOfId].ToString());
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                int value = GetNumberOfId(dt.Rows[i][columOfId].ToString());
                if (value > maxId)
                {
                    maxId = value;
                }
            }
            return maxId;
        }
        public static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                //Load your file path here
                string path = "D:\\CDUD\\chuyendeungdung\\BanHangCayCanh\\BanHangCayCanh\\App.config";
                ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                configFileMap.ExeConfigFilename = path;
                System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
                //Get the appsettings value
                var settings = config.AppSettings.Settings;
                //check if input key is new or already existing
                if (settings[key] == null)
                {
                    //if new then add the value
                    settings.Add(key, value);
                }
                else
                {
                    //if not then update the key value
                    settings[key].Value = value;
                }
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException exs)
            {
                throw new Exception("Error writing app settings" + exs.InnerException);
            }
        }
    }
}
