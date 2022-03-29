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
        Image tresB;

        int width;
        int height;


        public Image TrawaB { get => trawaB; set => trawaB = value; }
        public Image WodaB { get => wodaB; set => wodaB = value; }
        public Image PiasekB { get => piasekB; set => piasekB = value; }
        public Image GoryB { get => goryB; set => goryB = value; }
        public Image UfoB { get => ufoB; set => ufoB = value; }
        public Image QuestB { get => questB; set => questB = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Image TresB { get => tresB; set => tresB = value; }

        public Helper()
        {
            trawaB = Image.FromFile("elementy/PoleTrawy.png");
            wodaB = Image.FromFile("elementy/PoleWody.png");
            piasekB = Image.FromFile("elementy/PolePustynii.png");
            goryB = Image.FromFile("elementy/PoleGor.png");
            ufoB = Image.FromFile("elementy/PoleBazy.png");
            tresB = Image.FromFile("elementy/PoleSpecjalne.png");
            questB = Image.FromFile("elementy/PoleZadania.png");

            Width = trawaB.Width * 5; //5 - stykanie, 6- odzilne
            Height = trawaB.Height * 9; //0 - stykanie, 10- odzielnie
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
                case 6:
                    type = new Bitmap(TresB);
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

    public class Pole
    {
        public int[] x = new int[7];

        public override bool Equals(object obj)
        {
            var p2 = (Pole)obj;
            return ((x[0] == p2.x[0]) && (x[1] == p2.x[1])
                 && (x[2] == p2.x[2]) && (x[3] == p2.x[3])
                 && (x[4] == p2.x[4]) && (x[5] == p2.x[5])
                  && (x[6] == p2.x[6])) ? true : false; 
        }
    }

}
