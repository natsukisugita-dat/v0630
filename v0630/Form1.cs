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
        int vx = rand.Next(-10, 11);
        int vy = rand.Next(-10, 11);
        // 静的=最初に決めておく <> 動的=実行時に変更可能
        static Random rand = new Random();
        
        int vx1 = rand.Next(-10, 50);
        int vy1 = rand.Next(-10, 50);
        int vx2 = rand.Next(-10, 20);
        int vy2 = rand.Next(-10, 20);
        int vx3 = rand.Next(-10, 20);
        int vy3 = rand.Next(-10, 20);

        public Form1()
        {
            InitializeComponent();

            {
                label1.Left = rand.Next(ClientSize.Width - label1.Width);
                label1.Top = rand.Next(ClientSize.Height - label1.Height);
                label3.Left = rand.Next(ClientSize.Width - label3.Width);
                label3.Top = rand.Next(ClientSize.Height - label3.Height);
                label4.Left = rand.Next(ClientSize.Width - label4.Width);
                label4.Top = rand.Next(ClientSize.Height - label4.Height);
                label5.Left = rand.Next(ClientSize.Width - label5.Width);
                label5.Top = rand.Next(ClientSize.Height - label5.Height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled  = true;
            timer1.Interval = 100;
            
            {
                label1.Left += vx;
                label1.Top += vy;

                label3.Left += vx1;
                label3.Top += vy1;

                label4.Left += vx2;
                label4.Top += vy2;

                label5.Left += vx3;
                label5.Top += vy3;
            }
            
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
                    vx1 = Math.Abs(vx1);
                }
                if (label3.Right > ClientSize.Width)
                {
                    vx1 = -Math.Abs(vx1);
                }
                if (label3.Top < 0)
                {
                    vy1 = Math.Abs(vy1);
                }
                if (label3.Bottom > ClientSize.Height)
                {
                    vy1 = -Math.Abs(vy1);
                }

                if (label4.Left < 0)
                {
                    vx2 = Math.Abs(vx2);
                }
                if (label4.Right > ClientSize.Width)
                {
                    vx2 = -Math.Abs(vx2);
                }
                if (label4.Top < 0)
                {
                    vy2 = Math.Abs(vy2);
                }
                if (label4.Bottom > ClientSize.Height)
                {
                    vy2 = -Math.Abs(vy2);
                }

                if (label5.Left < 0)
                {
                    vx3 = Math.Abs(vx3);
                }
                if (label5.Right > ClientSize.Width)
                {
                    vx3 = -Math.Abs(vx3);
                }
                if (label5.Top < 0)
                {
                    vy3 = Math.Abs(vy3);
                }
                if (label5.Bottom > ClientSize.Height)
                {
                    vy3 = -Math.Abs(vy3);
                }
            }


            Point spos = MousePosition;
            Point fpos = PointToClient(spos);

            //label1にマウスカーソルが重なったらタイマー停止
            {
                if ((fpos.X >= label1.Left)
                && (fpos.X < label1.Right)
                && (fpos.Y >= label1.Top)
                && (fpos.Y < label1.Bottom))
                {
                    timer1.Enabled = false;
                }
                if ((fpos.X >= label3.Left)
                && (fpos.X < label3.Right)
                && (fpos.Y >= label3.Top)
                && (fpos.Y < label3.Bottom))
                {
                    timer1.Enabled = false;
                }
                if ((fpos.X >= label4.Left)
                && (fpos.X < label4.Right)
                && (fpos.Y >= label4.Top)
                && (fpos.Y < label4.Bottom))
                {
                    timer1.Enabled = false;
                }
                if ((fpos.X >= label5.Left)
                && (fpos.X < label5.Right)
                && (fpos.Y >= label5.Top)
                && (fpos.Y < label5.Bottom))
                {
                    timer1.Enabled = false;
                }
            }

            label2.Left = fpos.X - label2.Width  / 2;
            label2.Top  = fpos.Y - label2.Height / 2;
        }
    }
}
