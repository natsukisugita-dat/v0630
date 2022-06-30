using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0630
{
    public partial class Form1 : Form
    {
        int vx = -5;
        int vy = -10;
        int vx1 = -5;
        int vy1 = -10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Left += vx;
            label1.Top += vy;

            label3.Left += vx1;
            label3.Top += vy1;

            if (label1.Left<0)
            {
                vx = -vx;
            }
            if(label1.Right>ClientSize.Width)
            {
                vx = -vx;
            }
            if (label1.Top < 0)
            {
                vy = -vy;
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -vy;
            }

            if (label3.Left < 0)
            {
                vx1 = -vx1;
            }
            if (label3.Right > ClientSize.Width)
            {
                vx1 = -vx1;
            }
            if (label3.Top < 0)
            {
                vy1 = -vy1;
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy1 = -vy1;
            }


            Point spos = MousePosition;
            Point fpos = PointToClient(spos);

            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
