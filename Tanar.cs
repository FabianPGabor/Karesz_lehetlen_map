using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
    public partial class Form1 : Form
    {
        string betöltendő_pálya = "palya004.txt";

        void TANÁR_ROBOTJAI()
        {
            new Robot("Karesz", 10, 10, 10, 10, 0, 1, 14, 1);


            Robot janesz = new Robot("Janesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 10, 1, 2);
            

            janesz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(40, 14)) == sárga)
                { 
                    janesz.Lőjj();
                    for (int j = 0; j < 7; j++)
                    {
                        janesz.Várj();
                    }

                }
            };

            Robot paresz = new Robot("paresz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 20, 1, 2);


            paresz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(40, 14)) == sárga)
                {
                    paresz.Lőjj();
                    for (int j = 0; j < 7; j++)
                    {
                        paresz.Várj();
                    }

                }
            };

            Robot matyesz = new Robot("matyesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 30, 1, 2);

            matyesz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(40, 14)) == sárga)
                {
                    matyesz.Lőjj();
                    for (int j = 0; j < 7; j++)
                    {
                        matyesz.Várj();
                    }

                }
            };

            Robot dagesz = new Robot("dagesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 5, 29, 0);

            dagesz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(40, 14)) == sárga)
                {
                    dagesz.Lőjj();
                    for (int j = 0; j < 7; j++)
                    {
                        dagesz.Várj();
                    }

                }
            };

            Robot makesz = new Robot("makesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 15, 29, 0);

            makesz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(40, 14)) == sárga)
                {
                    makesz.Lőjj();
                    for (int j = 0; j < 7; j++)
                    {
                        makesz.Várj();
                    }

                }
            };

            Robot vityesz = new Robot("matyesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 25, 29, 0);

            vityesz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(40, 14)) == sárga)
                {
                    vityesz.Lőjj();
                    for (int j = 0; j < 7; j++)
                    {
                        vityesz.Várj();
                    }

                }
            };

        }
    }
}
