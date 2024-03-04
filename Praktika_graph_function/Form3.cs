using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_graph_function
{
    public partial class Color_ : Form
    {
        public Color_()
        {
            InitializeComponent();
        }

        //смена цвета
        public Color New_color
        {
            get
            {
                if (radioBtn_green.Checked) return Color.Green;
                if (radioBtn_blue.Checked) return Color.Blue;
                if (radioBtn_yellow.Checked) return Color.Yellow;

                return Color.Black;
            }
            set
            {
                if (value == Color.Green) radioBtn_green.Checked = true;
                if (value == Color.Blue) radioBtn_blue.Checked = true;
                if (value == Color.Yellow) radioBtn_yellow.Checked = true;
            }
        }
    }
}
