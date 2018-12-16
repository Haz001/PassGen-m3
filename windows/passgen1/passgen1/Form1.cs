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
    public partial class FormM : Form
    {
        //objects
        public Random _rn = new Random();
        public input_num _numd = new input_num();
        //variables
        public ulong _size = 16;
        private string _pass = "";
        private long _c = 0;
        private bool l_slider = false;
        public bool opt = false;


        public FormM()
        {
            InitializeComponent();
        }

        private void length_sb_ValueChanged(object sender, EventArgs e)
        {
            _size = Convert.ToUInt64(length_sb.Value);
            size_btn.Text = _size.ToString();
        }

        private void size_btn_Click(object sender, EventArgs e)
        {
            _size = num_input();
            if ((Convert.ToUInt64(length_sb.Maximum) >= _size)&&(_size >= Convert.ToUInt64(length_sb.Minimum)))
            {
                length_sb.Value = Convert.ToInt32(_size);
            }
            size_btn.Text = _size.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void gp_btn_Click(object sender, EventArgs e)
        {
            _pass = "";
            genorator g = new genorator();
            g.len = _size;
            g.ShowDialog();
            _pass = g.pass_x;
            _c++;
            if (_pass.Length > pv_tb.MaxLength)
            {
                pv_tb.Enabled = false;
                pv_tb.Text = "Can't Display";
                status_lb.Text = "Password " + _c + " Genorated|Length: "+_pass.Length.ToString()+"|Requested: "+_size.ToString()+"|Max Dispaly Limit: 1695";
            }
            else
            {
                pv_tb.Enabled = true;
                pv_tb.Text = _pass;
                status_lb.Text = "Password " + _c + " Genorated.";
            }
        }

        private void size_btn_DoubleClick(object sender, EventArgs e)
        {
            _size = num_input();
            if ((Convert.ToUInt64(length_sb.Maximum) >= _size) && (_size >= Convert.ToUInt64(length_sb.Minimum)))
            {
                length_sb.Value = Convert.ToInt32(_size);
            }
            size_btn.Text = _size.ToString();

        }
        public ulong num_input()
        {
            _numd = new input_num();
            _numd._num = _size;
            _numd.l_slider = l_slider;
            _numd.ShowDialog();
            if(_numd.l_slider != l_slider)
            {
                l_slider = _numd.l_slider;
                if (l_slider)
                {
                    length_sb.Minimum = 1;
                    length_sb.Maximum = 2048;
                }
                else
                {
                    length_sb.Minimum = 8;
                    length_sb.Maximum = 128;
                }
            }
            return _numd._num;
        }

        private void cp_btn_Click(object sender, EventArgs e)
        {
            if ((_pass != null) && (_pass != "")){
                Clipboard.SetText(_pass);
                status_lb.Text = "Copied to Cliboard.";

            }
            else
            {
                status_lb.Text = "Error: No password avalible.";
            }

        }

        private void pv_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pv_tb_DoubleClick(object sender, EventArgs e)
        {
            gp_btn_Click(sender, e);
        }

        private void opt_btn_Click(object sender, EventArgs e)
        {
            opt = !opt;
            if (opt)
            {
                options_pnl.Visible = true;
                this.Height = 450;
                options_pnl.Height = 150;
            }
            else
            {
                options_pnl.Visible = false;
                this.Height = 300;
                options_pnl.Height = 0;
            }
        }

        private void length_sb_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
