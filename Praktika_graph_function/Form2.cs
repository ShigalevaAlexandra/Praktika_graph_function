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
    public partial class Font_style : Form
    {
        public Font_style()
        {
            InitializeComponent();
        }

        //смена шрифта
        public FontStyle New_font
        {
            get
            {
                if (radioBtn_italic.Checked) return FontStyle.Italic;
                if (radioBtn_bold.Checked) return FontStyle.Bold;
                if (radioBtn_regular.Checked) return FontStyle.Regular;

                return FontStyle.Underline;
            }
            set
            {
                if (value == FontStyle.Italic) radioBtn_italic.Checked = true;
                if (value == FontStyle.Bold) radioBtn_bold.Checked = true;
                if (value == FontStyle.Regular) radioBtn_regular.Checked = true;
            }
        }
    }
}
