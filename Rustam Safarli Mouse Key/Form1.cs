using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rustam_Safarli_Mouse_Key
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y, x2, y2, r, s, score=0;

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
               
                timer1.Stop();
                MessageBox.Show("ZAP!!! Lightning caught!");
                pictureBox1.Location = new Point(64, 261);
                pictureBox2.Location = new Point(617, 80);
                score++;
                label2.Text = score.ToString();
                timer1.Start();
                pictureBox1.Location = new Point(64, 261);
                pictureBox2.Location = new Point(617, 80);

            }
            if (r < x2)
            {
                pictureBox2.Location = new Point(r, s);
                r+=10;
            }
            else
            {
                pictureBox2.Location = new Point(r, s);
                r-=10;
            }
            if (s < y2)
            {
                pictureBox2.Location = new Point(r, s);
                s+=10;
            }
            else
            {
                pictureBox2.Location = new Point(r, s);
                s-=10;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.Left && x > 0)
            {
                x -= 5;
            }
            if (e.KeyCode == Keys.Right && x < 816)
            {
                x += 5;
            }
            if (e.KeyCode == Keys.Up && y > 0)
            {
                y -= 5;
            }
            if (e.KeyCode == Keys.Down && y < 489)
            {
                y += 5;
            }
            pictureBox1.Location = new Point(x, y);
        }
    }
}
