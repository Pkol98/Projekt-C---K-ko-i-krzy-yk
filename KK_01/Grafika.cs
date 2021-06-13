using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace KK_01
{
    // VIEW **************************
    public class Grafika
    {
        private static Graphics gOb;
        public Grafika(Graphics g)
        {
            gOb = g;
            genTla();
        }
        // GENEROWANIE TŁA APLIKACJI
        public static void genTla()
        {
            Brush tlo = new SolidBrush(Color.PaleGreen);
            Pen linia = new Pen(Color.Black, 4);

            gOb.FillRectangle(tlo, new Rectangle(0, 0, 500, 600));
            // RYSOWANIE LINII OKREŚLAJACYCH SEKTORY
            gOb.DrawLine(linia, new Point(167, 0), new Point(167, 500));
            gOb.DrawLine(linia, new Point(334, 0), new Point(334, 500));
            gOb.DrawLine(linia, new Point(0, 167), new Point(500, 167));
            gOb.DrawLine(linia, new Point(0, 334), new Point(500, 334));
            gOb.DrawLine(linia, new Point(0, 500), new Point(500, 500));
         
        }
        // Rysowanie kształtu  X
        public static void drawX(Point loc)
        {
            Pen xPen = new Pen(Color.Red, 5);
            int xValue = loc.X * 167;
            int yValue = loc.Y * 167;

            gOb.DrawLine(xPen, xValue + 20, yValue + 20,xValue + 147, yValue + 147);
            gOb.DrawLine(xPen, xValue + 147, yValue + 20, xValue + 20, yValue + 147);
        }
        // Rysowanie kształtu O
        public static void drawO(Point loc)
        {
                Pen oPen = new Pen(Color.Blue, 5);
                int xValue = loc.X * 167;
                int yValue = loc.Y * 167;

            gOb.DrawEllipse(oPen, xValue + 10, yValue + 10, 147, 147);
        }
    }
}
