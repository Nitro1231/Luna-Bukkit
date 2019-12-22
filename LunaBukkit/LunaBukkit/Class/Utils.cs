using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace LunaBukkit.Class {
    class Utils {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(IntPtr hObject);

        public static void mouseMove(IntPtr handle) {
            ReleaseCapture();
            SendMessage(handle, 0xA1, 0x2, 0);
        }

        public static void smoothBorder(Form form, int round) {
            IntPtr ptr = CreateRoundRectRgn(0, 0, form.Width, form.Height, round, round);
            form.Region = Region.FromHrgn(ptr);
            DeleteObject(ptr);
        }

        public static void smoothBorder(Control ctl, int round) {
            IntPtr ptr = CreateRoundRectRgn(0, 0, ctl.Width, ctl.Height, round, round);
            ctl.Region = Region.FromHrgn(ptr);
            DeleteObject(ptr);
        }
    }
}
