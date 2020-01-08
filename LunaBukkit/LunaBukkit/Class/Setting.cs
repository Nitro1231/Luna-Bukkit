using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaBukkit.Class {
    class Setting {
        public static string javaPath;
        public static string version = "V0.0.1";
        public static int buildNumber = 1;
        public static string lastUpdate = "12/2/2019";

        #region Theme
        public static Color backColor = Color.FromArgb(35, 35, 35),
            brightBackColor = Color.FromArgb(40, 40, 40),
            darkBackColor = Color.FromArgb(28, 28, 28),
            hoverBackColor = Color.FromArgb(48, 48, 48),
            selectedBackColor = Color.FromArgb(60, 60, 60);
        public static Color fontColor = Color.White;
        public static Color themeColor = Color.FromArgb(18, 203, 196); // Main theme color

        public static void loadThemeSetting() {

        }

        public static void saveThemeSetting() {

        }
        #endregion
    }
}
