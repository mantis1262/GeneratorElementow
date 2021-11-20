using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Generator_map
{
    public partial class Manual : Form
    {
        Helper helper;
        public Manual(Helper helper)
        {
            this.helper = helper;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap elemnt = new Bitmap(800, 800, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            int X = elemnt.Width / 2;
            int Y = elemnt.Height / 2;
            int rX = helper.TrawaB.Width;
            int rY = helper.TrawaB.Height;
            helper.Draw(elemnt, leftTop.Value, X - ((3 * rX) / 4), Y - (rY / 2));
            helper.Draw(elemnt, leftBot.Value, X - ((3 * rX) / 4), Y + (rY / 2));
            helper.Draw(elemnt, top.Value, X, Y - rY);
            helper.Draw(elemnt, mid.Value, X, Y);
            helper.Draw(elemnt, bot.Value, X, Y + rY);
            helper.Draw(elemnt, rightTop.Value, X + (3 * rX) / 4, Y - (rY / 2));
            helper.Draw(elemnt, rightBot.Value, X + (3 * rX) / 4, Y + (rY / 2));
            string name = "element" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".png";

            elemnt.Save(name, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void LeftTop_Scroll(object sender, EventArgs e)
        {
            ChangeColor(leftTop);
        }

        private void Bot_Scroll(object sender, EventArgs e)
        {
            ChangeColor(bot);
        }

        private void LeftBot_Scroll(object sender, EventArgs e)
        {
            ChangeColor(leftBot);
        }

        private void Mid_Scroll(object sender, EventArgs e)
        {
            ChangeColor(mid);
        }

        private void RightTop_Scroll(object sender, EventArgs e)
        {
            ChangeColor(rightTop);
        }

        private void RightBot_Scroll(object sender, EventArgs e)
        {
            ChangeColor(rightBot);
        }
        private void Top_Scroll(object sender, EventArgs e)
        {
            ChangeColor(top);
        }

        private void ChangeColor(TrackBar track)
        {
            switch (track.Value)
            {
                case 0:
                    track.BackColor = Color.Green;
                    break;
                case 1:
                    track.BackColor = Color.Blue;
                    break;
                case 2:
                    track.BackColor = Color.Yellow;
                    break;
                case 3:
                    track.BackColor = Color.Brown;
                    break;
                default:
                    break;
            }
        }


    }
}
