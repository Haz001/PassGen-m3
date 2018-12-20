using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace passgen1
{
    public partial class genorator : Form
    {
        public genorator()
        {
            InitializeComponent();
            length = len;
        }
        public string pass_x = "";
        public ulong len = 0;
        private float theta = 0f;


        public Thread pgen = new Thread(new ThreadStart(passgen));


        public static Random _rn = new Random();
        public static ulong length = 8;
        public static string pass = "";
        public static ulong prog = 0;
        public static bool done = false;

        private void genorator_Load(object sender, EventArgs e)
        {
            length = len;
            pgen.Start();
        }
        public static void passgen()
        {
            pass = "";
            for (prog = 1; prog <= length; prog++)
            {
                
                pass += ((char)(_rn.Next(33, 126))).ToString();
            }
            
            done = true;
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            string percent = "";
            if (length != 0)
            {

                try
                {
                    progressBar1.Value = (int)((((float)prog / (float)length)) * 1000f);
                    theta = (int)((((float)prog / (float)length)) * 360f);

                    percent = (((((float)prog / (float)length)) * 100f)).ToString();
                }
                catch (Exception)
                {
                    Console.Write("Error");
                }
                
            }
            
            label1.Text = prog.ToString() + "/" + length.ToString()+"\n"+percent+"%";
            if ((done)&&(prog >= length))
            {
                pass_x = pass;
                this.Close();
            }
        }

        private void genorator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("h: "+this.Height.ToString()+"|w: "+ this.Width.ToString());
        }
    }
}
