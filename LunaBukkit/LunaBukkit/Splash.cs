using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace LunaBukkit {
    public partial class Splash : Form {
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
            Thread.Sleep(1000);

            while (Opacity > 0) { // Fade Out
                Opacity -= 0.01;
                logo.Update();
                Thread.Sleep(10);
            }
            Hide();

            Bukkit bukkit = new Bukkit();
            bukkit.Show();
        }
    }
}
