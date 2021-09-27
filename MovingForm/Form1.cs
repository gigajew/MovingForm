using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            Point mpos = MousePosition;
            Point fpos = Location;

            int xmodifier = 0;
            int ymodifier = 0;
            if( mpos.X <= fpos.X + (Width / 2)  )
            {
                xmodifier++;
            } 
            if (mpos.X >= fpos.X + (Width /2))
            {
                xmodifier--;
            }
            if(mpos.Y <= fpos.Y  +(Height / 2))
            {
                ymodifier++;

            } if ( mpos.Y >= fpos.Y + (Height / 2) )
            {
                ymodifier--;
            }


            this.Location = new Point(this.Location.X + xmodifier , this.Location.Y + ymodifier );
            base.OnMouseMove(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good job!");
        }
    }
}
