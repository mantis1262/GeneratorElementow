using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_map
{
    public partial class Form1 : Form
    {
        Helper helper;
        int[] type; 
        public Form1()
        {
            InitializeComponent();
            helper = new Helper();
            type = new int[7];
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            decimal temp = przeszkody.Value;
            Random random = new Random();
            Bitmap elemnt = new Bitmap(800, 800, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            if (radioButton1.Checked)
            {
                for(int i=0; i<7; i++)
                {
                    if (temp > 0)
                    {
                        var los = random.Next(0, 4);
                        type[i] = los;
                        type[i] = los;
                        if (los != 0) temp--;
                    } else
                    {
                        type[i] = 0;
                    }
                }
                
            }

            int X = elemnt.Width / 2;
            int Y = elemnt.Height/ 2;
            int rX = helper.TrawaB.Width;
            int rY = helper.TrawaB.Height;
            helper.Draw(elemnt, type[0], X - ((3 * rX) / 4), Y - (rY / 2));
            helper.Draw(elemnt, type[1], X - ((3 * rX) / 4), Y + (rY / 2));
            helper.Draw(elemnt, type[2], X, Y - rY);
            helper.Draw(elemnt, type[3], X, Y);
            helper.Draw(elemnt, type[4], X, Y+rY);
            helper.Draw(elemnt, type[5], X + (3 * rX) / 4, Y - (rY / 2));
            helper.Draw(elemnt, type[6], X + (3 * rX) / 4, Y + (rY / 2));
            string name = "element" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".png";
            
            elemnt.Save(name,System.Drawing.Imaging.ImageFormat.Png);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manual manual = new Manual(helper);
            manual.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
