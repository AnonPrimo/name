using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationFishes
{
    public partial class Form1 : Form
    {
            Graphics g;
        Image imgFish;

        public Form1()
        {
            InitializeComponent();
            Bitmap bt = Properties.Resources.SmallFish1;
            bt.MakeTransparent();
            imgFish = ResizeImg(bt, 100, 100);
            
            Image imgBG = ResizeImg(Properties.Resources.Field, 1000, 900);
            this.BackgroundImage = imgBG;
           // Rectangle r = new Rectangle(100, 100, imgFish.Width, imgFish.Height);
            g = Graphics.FromImage(BackgroundImage);
            g.DrawImage(imgFish, 0,0);

           // g.DrawRectangle(Pens.Black, r.X, r.Y, r.Width - 1, r.Height - 1);
            //this.Invalidate(r);
            this.Refresh();



        }

        public Image ResizeImg(Image b, int nWidth, int nHeight)
        {
            Image result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(b, 0, 0, nWidth, nHeight);
                g.Dispose();
            }
            return result;
        }
    }
}
