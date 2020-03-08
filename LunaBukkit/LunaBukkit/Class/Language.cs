using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Reflection;
using LunaBukkit.Properties;

namespace LunaBukkit.Class {
    class Language {
        public static int TargetVer = 1;

        public static string titleText = "Luna Bukkit";

        #region Dashboard
        public static string dashboardTitle = "Dashboard";
        public static string tTimeText = "20 seconds";
        public static string sysChartText = "CPU / RAM usage";
        public static string pcUserNameText = "User Name: ";
        public static string pcBitText = "Process Bitness: ";
        public static string pcCPUName = "CPU Name: ";
        #endregion

        public static void readLang(string lang) {
            try {
                byte[] langFile;
                switch (lang) {
                    case "en":
                        langFile = Resources.en;
                        break;
                    case "ko":
                        //langFile = Resources.ko;
                        break;
                    default:
                        langFile = Resources.en;
                        break;
                }

                File.WriteAllBytes(Setting.path + @"\LunaBukkit\Language\" + Resources.en.ToString(), Resources.en);
                string json = File.ReadAllText(Setting.path + @"\LunaBukkit\Language\" + Resources.en.ToString());
                JObject jsonToken = JObject.Parse(json);

                JToken tokenSelected = jsonToken.SelectToken("Main");
                titleText = tokenSelected.SelectToken("titleText").ToString();

                tokenSelected = jsonToken.SelectToken("Dashboard");
                dashboardTitle = tokenSelected.SelectToken("dashboardTitle").ToString();
                tTimeText = tokenSelected.SelectToken("tTimeText").ToString();
                sysChartText = tokenSelected.SelectToken("sysChartText").ToString();
                pcUserNameText = tokenSelected.SelectToken("pcUserNameText").ToString();
                pcBitText = tokenSelected.SelectToken("pcBitText").ToString();
                pcCPUName = tokenSelected.SelectToken("pcCPUName").ToString();
            } catch (Exception e) {
                // error occurred. use the English for lang
                //titleText = e.ToString();
            }
        }
    }
}
