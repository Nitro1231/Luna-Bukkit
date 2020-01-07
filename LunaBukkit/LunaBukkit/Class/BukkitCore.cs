using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaBukkit.Class {
    class BukkitCore {

        public string autoJavaPath() {
            if (Directory.Exists(@"C:\Program Files\Java")) {
                foreach (string path in Directory.GetDirectories(@"C:\Program Files\Java")) {
                    if (File.Exists(path + @""))
                        return "";
                }
            } else if (Directory.Exists(@"C:\Program Files (x86)\Java")) {
                foreach (string path in Directory.GetDirectories("C:\\Program Files (x86)\\Java")) {

                }
            }
            return "dne";
        }
    }
}
