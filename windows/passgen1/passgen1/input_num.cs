using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passgen1
{
    public partial class input_num : Form
    {
        public ulong _num = 8;
        public bool l_slider = false;
        public input_num()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void input_num_Load(object sender, EventArgs e)
        {
            num_tb.Text = _num.ToString();
            sl_bool.Checked = l_slider;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            _num++;
            num_tb.Text = _num.ToString();

        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            _num--;
            num_tb.Text = _num.ToString();
        }

        private void num_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ulong x = Convert.ToUInt64(num_tb.Text);
                _num = x;
            }
            catch (Exception)
            {
                num_tb.Text = _num.ToString();
                
            }
        }

        private void sl_bool_CheckedChanged(object sender, EventArgs e)
        {
            l_slider = sl_bool.Checked;
        }
    }
}
