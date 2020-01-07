using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaBukkit.Controls {
    public partial class SideButton : UserControl {
        private bool selected = false;
        private int index = 0;

        public SideButton(int indexInt, bool ifSelected, Image icon) {
            InitializeComponent();
            index = indexInt;
            selected = ifSelected;
            if (ifSelected) {
                BackColor = Class.Setting.selectedBackColor;
                selectPanel.BackColor = Class.Setting.themeColor;
            } else {
                BackColor = Class.Setting.brightBackColor;
            }
            menuPictureBox.Image = icon;
        }

        private void SideButton_Click(object sender, EventArgs e) {
            Splash.bukkit.sideButtonClick();
            buttonClicked(true);
        }

        public void buttonClicked(bool clicked) {
            if (clicked) {
                selected = true;
                BackColor = Class.Setting.selectedBackColor;
                selectPanel.BackColor = Class.Setting.themeColor;
            } else {
                selected = false;
                BackColor = Class.Setting.brightBackColor;
                selectPanel.BackColor = Class.Setting.brightBackColor;
            }
        }

        public int getIndex() { return index; }
        public bool ifSelected() { return selected; }
        private void SideButton_MouseHover(object sender, EventArgs e) {
            if(!selected)
                BackColor = Class.Setting.hoverBackColor; }
        private void SideButton_MouseLeave(object sender, EventArgs e) {
            if (!selected)
                BackColor = Class.Setting.brightBackColor; }
        private void SideButton_MouseMove(object sender, MouseEventArgs e) {
            Class.Utils.mouseMove(Splash.bukkit.Handle); }
    }
}
