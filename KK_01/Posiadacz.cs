using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;


namespace KK_01
{
    // PODRZĘDNA KLASA MODELU
    public class Posiadacz
    {
        private Point lokacja;
        private int wartosc = Tablica.P;
        // USTAWIANIE LOKACJI 
        public void setLokacja(Point p)
        {
            lokacja = p;
        }
        // POBIERANIE LOKACJI 
        public Point getLokacja()
        {
            return lokacja;
        }
        // USTAWIANIE WARTSCI SEKTORA 
        public void setWartosc(int i)
        {
            wartosc = i;
        }
        // POBIERANIE WARTOSCI SEKTORA
        public int getWartosc()
        {
            return wartosc;
        }

    }
}
