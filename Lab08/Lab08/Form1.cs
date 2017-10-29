using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap("D:\\Capture.PNG");

            this.SetClientSizeCore(bmp.Width, bmp.Height);
            Rectangle destrect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            Brush myBrush = new SolidBrush(Color.Coral);
            e.Graphics.DrawImage(bmp, destrect);
            e.Graphics.DrawString("Hello World",                               //string
                                   new Font("Verdana", 20, FontStyle.Bold),         // Font , size
                                   myBrush,
                                   0,       // x position to display font
                                   0);      // y position to display font

            g.Dispose();
        }
    }
}
