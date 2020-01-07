using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaBukkit {
    public partial class Bukkit : Form {
        private Controls.SideButton dashboard, server, newServer, setting;

        public Bukkit() {
            InitializeComponent();

            #region Theme
            // At this section, program will change the theme color based on setting.
            logoPanel.BackColor = Class.Setting.themeColor;
            colorPanel.BackColor = Class.Setting.themeColor;
            sideFlowLayoutPanel.BackColor = Class.Setting.darkBackColor;
            mainPanel.BackColor = Class.Setting.backColor;
            #endregion

            // Setup the side buttons
            dashboard = new Controls.SideButton(0, true, null);
            server = new Controls.SideButton(1, false, null);
            newServer = new Controls.SideButton(2, false, null);
            setting = new Controls.SideButton(3, false, null);
            setting.Margin = new Padding(0, 175, 0, 0);

            // Add controls to the layout panel
            sideFlowLayoutPanel.Controls.Add(dashboard);
            sideFlowLayoutPanel.Controls.Add(server);
            sideFlowLayoutPanel.Controls.Add(newServer);
            sideFlowLayoutPanel.Controls.Add(setting);
        }

        private void Bukkit_Load(object sender, EventArgs e) {

        }

        public void sideButtonClick() {
            // De-select evey contorls in layout panel
            foreach(Controls.SideButton sb in sideFlowLayoutPanel.Controls)
                sb.buttonClicked(false);

            foreach (Controls.SideButton sb in sideFlowLayoutPanel.Controls) {
                if (sb.ifSelected()) { // Find the button that user clicked
                    switch (sb.getIndex()) { // Switch the tab
                        case 0: // Dashboard

                            break;
                        case 1: // Server

                            break;
                        case 2: // New Server

                            break;
                        case 3: // Setting

                            break;
                    }
                }
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e) { // Draw the shadow
            RectangleF rectFToFill = new RectangleF(0, 0, 20, mainPanel.Height);
            using (LinearGradientBrush shadowBrush = new LinearGradientBrush(rectFToFill, Color.FromArgb(255, Color.FromArgb(15, 15, 15)), Color.FromArgb(1, Class.Setting.backColor), 360))
                e.Graphics.FillRectangle(shadowBrush, rectFToFill);
        }
        private void Bukkit_Paint(object sender, PaintEventArgs e) {
            // Impove and increase the drawing speed
            e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;
        }
        private void Bukkit_MouseMove(object sender, MouseEventArgs e) {
            Class.Utils.mouseMove(Handle); // Form movement
        }
        private void minBox_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized; // Minimized button
        }
        private void closeBox_Click(object sender, EventArgs e) {
            Close(); // Close button 
        }
    }
}
