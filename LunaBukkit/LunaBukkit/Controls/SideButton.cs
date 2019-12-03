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
        public bool selected = false;
        public int index = 0;

        public SideButton(int indexInt, bool ifSelected) {
            InitializeComponent();
            index = indexInt;
            selected = ifSelected;
            //BackColor

            
        }
    }
}
