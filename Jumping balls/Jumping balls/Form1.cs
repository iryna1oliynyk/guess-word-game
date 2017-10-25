using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jumping_balls
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        int x;
        int y;
        int xv = 1;
        int yv = 1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = Height.ToString() +" " + Width.ToString();
            bool right = true;
            bool down = true;

            x = x + xv;
            y = y + yv;

            if (x <= 0)
            {
                right = false;
                xv = -xv;
            }

            if (y <= 0)
            {
                right = false;
                yv = -yv;
            }

            if (x > Width-50)
            { 
                xv = -xv;
            }

            if ( y > Height-70)
            {
                yv = -yv;
            }


            Refresh();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        
            e.Graphics.DrawEllipse(new Pen(Brushes.Blue, 50),x, y, 10, 10);
            
            //e.Graphics.DrawEllipse(new Pen(Brushes.Blue, 50), 0, 0, 100, 10);
        }

    }
}
