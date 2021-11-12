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
        Image trawaB;
        Image wodaB;
        Image piasekB;
        Image goryB;
        int[] type; 
        public Form1()
        {
            InitializeComponent();
            trawaB = Image.FromFile("elementy/trawa.png");
            wodaB = Image.FromFile("elementy/woda.png");
            piasekB = Image.FromFile("elementy/piasek.png");
            goryB = Image.FromFile("elementy/gory.png");
            type = new int[7];
        }

        private void Draw(Bitmap bitmap, int intType, int midX, int midY)
        {
            Bitmap type = null ;
            switch (intType)
            {
                case 0:
                    type = new Bitmap(trawaB);
                    break;
                case 1:
                    type = new Bitmap(wodaB);
                    break;
                case 2:
                    type = new Bitmap(piasekB);
                    break;
                case 3:
                    type = new Bitmap(goryB);
                    break;
                default:
                    break;
            }


            for (int i = 0; i < type.Width; i++)
                for (int j = 0; j < type.Height; j++)
                {
                    Color color = type.GetPixel(i, j);
                    if(color.A !=0)
                    bitmap.SetPixel(midX + (i - type.Width / 2), midY + (j - type.Height / 2), color);

                }
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


            Draw(elemnt, type[0], 310, 348);
            Draw(elemnt, type[1], 310, 452);
            Draw(elemnt, type[2], 400, 296);
            Draw(elemnt, type[3], 400, 400);
            Draw(elemnt, type[4], 400, 504);
            Draw(elemnt, type[5], 490, 348);
            Draw(elemnt, type[6], 490, 452);
            string name = "element" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".png";
            
            elemnt.Save(name,System.Drawing.Imaging.ImageFormat.Png);

        }
    }
}
