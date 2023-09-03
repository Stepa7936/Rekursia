using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rekurs
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p1 = new Pen(Color.Blue, 5);
        int c = 6;
        int r;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.Clear(SystemColors.Control);
            g.TranslateTransform(0, c);
            draw_b(r);
            draw(c,c);
            draw_c(r);
            draw(c, -c);
            draw_d(r);
            draw(-c, -c);
            draw_a(r);
            draw(-c, c);
        }
        private void draw (int x, int y)
        {
            g.DrawLine(p1, 0, 0, x, y);
            g.TranslateTransform(x, y);
        }
        private void draw_b(int p)
        {
            if (p == 1)
            {
                draw(c,c);
                draw(0,c*2);
                draw(-c, c);
            }
            else
            {
                draw_b(p-1);
                draw(c, c);
                draw_c(p - 1);
                draw(0, c * 2);
                draw_a(p - 1);
                draw(-c, c);
                draw_b(p - 1);
            }
        }
        private void draw_c(int p)
        {
            if (p == 1)
            {
                draw(c, -c);
                draw(c*2, 0);
                draw(c, c);
            }
            else
            {
                draw_c(p - 1);
                draw(c, -c);
                draw_d(p - 1);
                draw(c * 2, 0);
                draw_b(p - 1);
                draw(c, c);
                draw_c(p - 1);
            }
        }
        private void draw_d(int p)
        {
            if (p == 1)
            {
                draw(-c,-c);
                draw(0, -c * 2);
                draw(c, -c);
            }
            else
            {
                draw_d(p - 1);
                draw(-c,-c);
                draw_a(p - 1);
                draw(0, -c * 2);
                draw_c(p - 1);
                draw(c, -c);
                draw_d(p - 1);
            }
        }
        private void draw_a(int p)
        {
            if (p == 1)
            {
                draw(-c, c);
                draw(-c * 2, 0);
                draw(-c, -c);
            }
            else
            {
                draw_a(p - 1);
                draw(-c, c);
                draw_b(p - 1);
                draw(-c * 2, 0);
                draw_d(p - 1);
                draw(-c, -c);
                draw_a(p - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                r = int.Parse(textBox1.Text);
            }
        }

    }
}
