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
            Image image = Image.FromFile("D:\\Capture.PNG");
            //Change "D:\\Capture.PNG" to match your image path and name.
            TextureBrush brush = new TextureBrush(image);
            Rectangle rect = new Rectangle(10, 10, 180, 150);
            e.Graphics.FillEllipse(brush, rect);
        }
    }
}
