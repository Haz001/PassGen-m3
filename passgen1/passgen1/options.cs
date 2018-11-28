using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passgen1
{
    public partial class options : UserControl
    {
        public short style = 0;
        public options()
        {
            InitializeComponent();
        }

        private void options_Load(object sender, EventArgs e)
        {
            style_lst.SelectedIndex = 0;
        }

        private void style_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            style = Convert.ToInt16(style_lst.SelectedIndex);
            if(style == 0)
            {

            }

        }
    }
}
