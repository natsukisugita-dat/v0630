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
        int vx2 = -5;
        int vy2 = -10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
            label1.Left += vx;
            label1.Top += vy;

            label3.Left += vx1;
            label3.Top += vy1;

            label4.Left += vx2;
            label4.Top += vy2;
            {
                if (label1.Left < 0)
                {
                    vx = Math.Abs(vx);
                }
                if (label1.Right > ClientSize.Width)
                {
                    vx = -Math.Abs(vx);
                }
                if (label1.Top < 0)
                {
                    vy = Math.Abs(vy);
                }
                if (label1.Bottom > ClientSize.Height)
                {
                    vy = -Math.Abs(vy);
                }

                if (label3.Left < 0)
                {
                    vx1 = Math.Abs(vx);
                }
                if (label3.Right > ClientSize.Width)
                {
                    vx1 = -Math.Abs(vx);
                }
                if (label3.Top < 0)
                {
                    vy1 = Math.Abs(vy);
                }
                if (label3.Bottom > ClientSize.Height)
                {
                    vy1 = -Math.Abs(vy);
                }

                if (label4.Left < 0)
                {
                    vx2 = Math.Abs(vx);
                }
                if (label4.Right > ClientSize.Width)
                {
                    vx2 = -Math.Abs(vx2);
                }
                if (label4.Top < 0)
                {
                    vy2 = Math.Abs(vy);
                }
                if (label4.Bottom > ClientSize.Height)
                {
                    vy2 = -Math.Abs(vy);
                }
            }


            Point spos = MousePosition;
            Point fpos = PointToClient(spos);

            if (( fpos.X >= label1.Left)
            && (  fpos.X <  label1.Right)
            && (  fpos.Y >= label1.Top)
            && (  fpos.Y <  label1.Bottom))
            {
                timer1.Enabled = false;
            }

            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
