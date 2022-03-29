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
        bool[] typeBool;
        public List<Pole> eleList;

        public Form1()
        {
            InitializeComponent();
            helper = new Helper();
            type = new int[7];
            typeBool = new bool[4]
                { true, true, true, true };
            eleList = new List<Pole>();

        }

       
        private void Button1_Click(object sender, EventArgs e)
        {
            eleList = new List<Pole>();

            for (int i = 0; i < iArkuszy.Value; i++)
            {
                Bitmap elemnt = new Bitmap(helper.Width, helper.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                int X4 = elemnt.Width / 4;
                int Y6 = elemnt.Height / 6;
                GenerujElement(elemnt, X4, Y6);
                GenerujElement(elemnt, 3 * X4, Y6);
                GenerujElement(elemnt, X4, 3 * Y6);
                GenerujElement(elemnt, 3 * X4, 3 * Y6);
                GenerujElement(elemnt, X4, 5 * Y6);
                GenerujElement(elemnt, 3 * X4, 5 * Y6);

                string name = "../../../Result/Arkusz" + i + " " + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".png";

                elemnt.Save(name, System.Drawing.Imaging.ImageFormat.Png);
            }

        }

        private void GenerujElement(Bitmap elemnt, int X, int Y)
        {
            Pole obj;
            bool nonRepet;
             Random random = new Random();
            do
            {
                decimal temp = random.Next(1, (int)przeszkody.Value + 1);
                nonRepet = true;
                for (int i = 0; i < 7; i++)
                {
                    if (temp > 0)
                    {
                        do
                        {
                            var los = random.Next(0, 4);
                            type[i] = los;
                        }
                        while (!typeBool[type[i]]);
                        if (type[i] != 0) temp--;
                    }
                    else
                    {
                        type[i] = 0;
                    }
                }
                obj = new Pole
                {
                    x = type
                };
                foreach (var ele in eleList)
                {
                    if (obj.Equals(ele))
                        nonRepet = false;                        
                };
            } while (nonRepet == false);

            eleList.Add(obj);

            int rX = helper.TrawaB.Width;
            int rY = helper.TrawaB.Height;
            helper.Draw(elemnt, type[0], X - ((3 * rX) / 4), Y - (rY / 2));
            helper.Draw(elemnt, type[1], X - ((3 * rX) / 4), Y + (rY / 2));
            helper.Draw(elemnt, type[2], X, Y - rY);
            helper.Draw(elemnt, type[3], X, Y);
            helper.Draw(elemnt, type[4], X, Y + rY);
            helper.Draw(elemnt, type[5], X + (3 * rX) / 4, Y - (rY / 2));
            helper.Draw(elemnt, type[6], X + (3 * rX) / 4, Y + (rY / 2));
        }


        private void GenerujZadanie(Bitmap elemnt, int X, int Y)
        {
            Pole obj;
            bool nonRepet;
            Random random = new Random();
            do
            {
                decimal temp = random.Next(1, (int)przeszkody.Value + 1);
                nonRepet = true;
                for (int i = 0; i < 7; i++)
                {
                    if (temp > 0)
                    {
                        do
                        {
                            var los = random.Next(0, 4);
                            type[i] = los;
                        }
                        while (!typeBool[type[i]]);
                        if (type[i] != 0) temp--;
                    }
                    else
                    {
                        type[i] = 0;
                    }
                }
                obj = new Pole
                {
                    x = type
                };
                foreach (var ele in eleList)
                {
                    if (obj.Equals(ele))
                        nonRepet = false;
                };
            } while (nonRepet == false);

            eleList.Add(obj);


            int rX = helper.TrawaB.Width;
            int rY = helper.TrawaB.Height;
            helper.Draw(elemnt, type[0], X - ((3 * rX) / 4), Y - (rY / 2));
            helper.Draw(elemnt, type[1], X - ((3 * rX) / 4), Y + (rY / 2));
            helper.Draw(elemnt, type[2], X, Y - rY);
            helper.Draw(elemnt, 5, X, Y);
            helper.Draw(elemnt, type[4], X, Y + rY);
            helper.Draw(elemnt, type[5], X + (3 * rX) / 4, Y - (rY / 2));
            helper.Draw(elemnt, type[6], X + (3 * rX) / 4, Y + (rY / 2));
        }


        private void GenerujZnalezisko(Bitmap elemnt, int X, int Y)
        {
            Pole obj;
            bool nonRepet;
            Random random = new Random();
            do
            {
                decimal temp = random.Next(1, (int)przeszkody.Value + 1);
                nonRepet = true;
                for (int i = 0; i < 7; i++)
                {
                    if (temp > 0)
                    {
                        do
                        {
                            var los = random.Next(0, 4);
                            type[i] = los;
                        }
                        while (!typeBool[type[i]]);
                        if (type[i] != 0) temp--;
                    }
                    else
                    {
                        type[i] = 0;
                    }
                }
                obj = new Pole
                {
                    x = type
                };
                foreach (var ele in eleList)
                {
                    if (obj.Equals(ele))
                        nonRepet = false;
                };
            } while (nonRepet == false);

            eleList.Add(obj);


            int rX = helper.TrawaB.Width;
            int rY = helper.TrawaB.Height;
            helper.Draw(elemnt, type[0], X - ((3 * rX) / 4), Y - (rY / 2));
            helper.Draw(elemnt, type[1], X - ((3 * rX) / 4), Y + (rY / 2));
            helper.Draw(elemnt, type[2], X, Y - rY);
            helper.Draw(elemnt, 6, X, Y);
            helper.Draw(elemnt, type[4], X, Y + rY);
            helper.Draw(elemnt, type[5], X + (3 * rX) / 4, Y - (rY / 2));
            helper.Draw(elemnt, type[6], X + (3 * rX) / 4, Y + (rY / 2));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Manual manual = new Manual(helper);
            manual.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Bitmap elemnt = new Bitmap(helper.Width, helper.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            int X = elemnt.Width / 2;
            int Y = elemnt.Height / 2;
            int rX = helper.TrawaB.Width;
            int rY = helper.TrawaB.Height;

            helper.Draw(elemnt, 0, X - 2 * rX + rX / 2 , Y - rY);
            helper.Draw(elemnt, 0, X - 2 * rX + rX / 2, Y);
            helper.Draw(elemnt, 0, X - 2 * rX + rX / 2, Y + rY);

            helper.Draw(elemnt, 0, X - ((3 * rX) / 4), Y - (rY / 2) -rY);
            helper.Draw(elemnt, 0, X - ((3 * rX) / 4), Y - (rY / 2));
            helper.Draw(elemnt, 0, X - ((3 * rX) / 4), Y + (rY / 2));
            helper.Draw(elemnt, 0, X - ((3 * rX) / 4), Y + (rY / 2) + rY);

            helper.Draw(elemnt, 0, X, Y - 2 * rY);
            helper.Draw(elemnt, 0, X, Y - rY);
            helper.Draw(elemnt, 4, X, Y);
            helper.Draw(elemnt, 0, X, Y + rY);
            helper.Draw(elemnt, 0, X, Y + 2 * rY);

            helper.Draw(elemnt, 0, X + (3 * rX) / 4, Y - (rY / 2) - rY);
            helper.Draw(elemnt, 0, X + (3 * rX) / 4, Y - (rY / 2));
            helper.Draw(elemnt, 0, X + (3 * rX) / 4, Y + (rY / 2));
            helper.Draw(elemnt, 0, X + (3 * rX) / 4, Y + (rY / 2) + rY);

            helper.Draw(elemnt, 0, X + 2 * rX - rX / 2, Y - rY);
            helper.Draw(elemnt, 0, X + 2 * rX - rX / 2, Y);
            helper.Draw(elemnt, 0, X + 2 * rX - rX / 2, Y + rY);



            string name = "../../../Result/Start" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".png";

            elemnt.Save(name, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            eleList = new List<Pole>();

            for (int i = 0; i < iArkuszy.Value; i++)
            {
                Bitmap elemnt = new Bitmap(helper.Width, helper.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                int X4 = elemnt.Width / 4;
                int Y6 = elemnt.Height / 6;
                GenerujZadanie(elemnt, X4, Y6);
                GenerujZadanie(elemnt, 3 * X4, Y6);
                GenerujZadanie(elemnt, X4, 3 * Y6);
                GenerujZadanie(elemnt, 3 * X4, 3 * Y6);
                GenerujZadanie(elemnt, X4, 5 * Y6);
                GenerujZadanie(elemnt, 3 * X4, 5 * Y6);

                string name = "../../../Result/Zadanie" + i + " " + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".png";

                elemnt.Save(name, System.Drawing.Imaging.ImageFormat.Png);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            eleList = new List<Pole>();

            for (int i = 0; i < iArkuszy.Value; i++)
            {
                Bitmap elemnt = new Bitmap(helper.Width, helper.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                int X4 = elemnt.Width / 4;
                int Y6 = elemnt.Height / 6;
                GenerujZnalezisko(elemnt, X4, Y6);
                GenerujZnalezisko(elemnt, 3 * X4, Y6);
                GenerujZnalezisko(elemnt, X4, 3 * Y6);
                GenerujZnalezisko(elemnt, 3 * X4, 3 * Y6);
                GenerujZnalezisko(elemnt, X4, 5 * Y6);
                GenerujZnalezisko(elemnt, 3 * X4, 5 * Y6);

                string name = "../../../Result/Znalezisko" + i + " " + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".png";

                elemnt.Save(name, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //woda
            typeBool[1] = !typeBool[1]  ;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //piasek
            typeBool[3] = !typeBool[3];
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //gory
            typeBool[2] = !typeBool[2];
        }

    }
}
