using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaBukkit.FormControls {
    public partial class Dashboard : UserControl {
        public Dashboard() {
            InitializeComponent();
            BackColor = Class.Setting.backColor;
            dashboardTitle.Text = Class.Language.dashboardTitle;
            label1.Location = new Point(cpuProgressBar.Left + cpuProgressBar.Width / 2 - label1.Width / 2, cpuProgressBar.Top + cpuProgressBar.Height + 4);
            label2.Location = new Point(ramProgressBar.Left + ramProgressBar.Width / 2 - label2.Width / 2, ramProgressBar.Top + ramProgressBar.Height + 4);
            tTimeText.Text = Class.Language.tTimeText;
            tTimeText.Height = SystemChart.Top + SystemChart.Height + 4;
            sysChartText.Text = Class.Language.sysChartText;
            sysChartText.Location = new Point(SystemChart.Width - 200, SystemChart.Top + SystemChart.Height + 4);
            pcUserNameText.Text = Class.Language.pcUserNameText;
            pcBitText.Text = Class.Language.pcBitText;
            pcCPUName.Text = Class.Language.pcCPUName;
        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e) {
            Class.Utils.mouseMove(Splash.bukkit.Handle);
        }
    }
}
