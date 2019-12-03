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
        public static string lastUpdated = "12/2/2019";

        #region DarkTheme
        public static Color themeColor = Color.FromArgb(18, 203, 196); // Main theme color
        public static Color selectedBackColor = Color.FromArgb(50, 50, 50);
        public static Color brightBackColor = Color.FromArgb(40, 40, 40);
        public static Color backColor = Color.FromArgb(30, 30, 30);
        public static Color darkBackColor = Color.FromArgb(20, 20, 20);
        #endregion
    }
}
