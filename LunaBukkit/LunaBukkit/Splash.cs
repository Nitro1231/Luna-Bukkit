using System;
using System.Threading;
using System.Windows.Forms;

namespace LunaBukkit {
    public partial class Splash : Form {
        public static Bukkit bukkit;

        public Splash() {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e) {
            Show();
            while (Opacity < 1) { // Fade In
                Opacity += 0.01;
                logo.Update();
                Thread.Sleep(10);
            }

            // do something
            bukkit = new Bukkit();
            Thread.Sleep(1000);

            while (Opacity > 0) { // Fade Out
                Opacity -= 0.01;
                logo.Update();
                Thread.Sleep(10);
            }
            Hide();
            bukkit.Show();
        }
    }
}
