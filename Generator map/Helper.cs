using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Generator_map
{
    public class Helper
    {

        Image trawaB;
        Image wodaB;
        Image piasekB;
        Image goryB;
        Image ufoB;
        Image questB;


        public Image TrawaB { get => trawaB; set => trawaB = value; }
        public Image WodaB { get => wodaB; set => wodaB = value; }
        public Image PiasekB { get => piasekB; set => piasekB = value; }
        public Image GoryB { get => goryB; set => goryB = value; }
        public Image UfoB { get => ufoB; set => ufoB = value; }
        public Image QuestB { get => questB; set => questB = value; }



        public Helper()
        {
            trawaB = Image.FromFile("elementy/trawa.png");
            wodaB = Image.FromFile("elementy/woda.png");
            piasekB = Image.FromFile("elementy/piasek.png");
            goryB = Image.FromFile("elementy/gory.png");
            ufoB = Image.FromFile("elementy/trawa-UFO.png");
            questB = Image.FromFile("elementy/trawa-zadanie.png");
        }

        public void Draw(Bitmap bitmap, int intType, int midX, int midY)
        {
            Bitmap type = null;
            switch (intType)
            {
                case 0:
                    type = new Bitmap(TrawaB);
                    break;
                case 1:
                    type = new Bitmap(WodaB);
                    break;
                case 2:
                    type = new Bitmap(PiasekB);
                    break;
                case 3:
                    type = new Bitmap(GoryB);
                    break;
                case 4:
                    type = new Bitmap(UfoB);
                    break;
                case 5:
                    type = new Bitmap(QuestB);
                    break;

                default:
                    break;
            }


            for (int i = 0; i < type.Width; i++)
                for (int j = 0; j < type.Height; j++)
                {
                    Color color = type.GetPixel(i, j);
                    if (color.A != 0)
                        bitmap.SetPixel(midX + (i - type.Width / 2), midY + (j - type.Height / 2), color);

                }
        }
    }
}
