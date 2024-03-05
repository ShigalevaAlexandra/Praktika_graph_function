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
    public partial class Font_ : Form
    {
        public Font_()
        {
            InitializeComponent();
        }

        //смена шрифта
        public Font New_font
        {
            get
            {
                if (radioBtn_Modern.Checked) return new Font("Modern No", 10);
                if (radioBtn_Palatino_Linotype.Checked) return new Font("Palatino Linotype", 10);
                if (radioBtn_Tahoma.Checked) return new Font("Tahoma", 10);

                return new Font("Microsoft Sans Serif", 10);
            }
            set
            {
                if (value == new Font("Modern No", 10)) radioBtn_Modern.Checked = true;
                if (value == new Font("Palatino Linotype", 10)) radioBtn_Palatino_Linotype.Checked = true;
                if (value == new Font("Tahoma", 10)) radioBtn_Tahoma.Checked = true;
            }
        }
    }
}
