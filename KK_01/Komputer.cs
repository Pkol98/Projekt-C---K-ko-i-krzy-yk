using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace KK_01
{
    class Komputer
    {
        // PODRZĘDNA KLASA MODELU
        public static Posiadacz miejsceRuchuKomputera(Posiadacz[,] tablica)
        {
            Posiadacz ruch = new Posiadacz();
            ruch.setWartosc(Tablica.O);

            // sprawdza czy środek gry jest pusty
            if (tablica[1, 1].getWartosc() == Tablica.P)
            {
                ruch.setLokacja(new Point(1, 1));
                return ruch;
            }
            // sprawdzanie pionowo czy mamy możliwośc wygrania - algorytm ofensywy komputera-----------------------------------------------------------------------------------------------------
            
            for (int x = 0; x <3; x++)
            {
                // sprwdzamy czy występują w kolumnie w lokacjach 0,0 i 0,1 O
                if (tablica[x, 0].getWartosc() == Tablica.O && tablica[x, 1].getWartosc() == Tablica.O && tablica[x, 2].getWartosc() == Tablica.P)
                {
                    ruch.setLokacja(new Point(x, 2));
                    return ruch;
                }
            }
            for (int x = 0; x < 3; x++)
            {
                // sprwdzamy czy występują w kolumnie w lokacjach 0,1 i 0,2 O
                if (tablica[x, 0].getWartosc() == Tablica.P && tablica[x, 1].getWartosc() == Tablica.O && tablica[x, 2].getWartosc() == Tablica.O)
                {
                    ruch.setLokacja(new Point(x, 0));
                    return ruch;
                }
            }
            for (int x = 0; x < 3; x++)
            {

                if (tablica[x, 0].getWartosc() == Tablica.O && tablica[x, 1].getWartosc() == Tablica.P && tablica[x, 2].getWartosc() == Tablica.O)
                {
                    ruch.setLokacja(new Point(x, 1));
                    return ruch;
                }
            }
        // Sprawdzanie poziomo możliwości wygrania
            for (int y = 0; y < 3; y++)
            {

                if (tablica[0, y].getWartosc() == Tablica.O && tablica[1, y].getWartosc() == Tablica.O && tablica[2, y].getWartosc() == Tablica.P)
                {
                    ruch.setLokacja(new Point(2, y));
                    return ruch;
                }
            }
            for (int y = 0; y < 3; y++)
            {

                if (tablica[0, y].getWartosc() == Tablica.P && tablica[1, y].getWartosc() == Tablica.O && tablica[2, y].getWartosc() == Tablica.O)
                {
                    ruch.setLokacja(new Point(0, y));
                    return ruch;
                }
            }
            for (int y = 0; y < 3; y++)
            {

                if (tablica[0, y].getWartosc() == Tablica.P && tablica[1, y].getWartosc() == Tablica.P  && tablica[2, y].getWartosc() == Tablica.O)
                {
                    ruch.setLokacja(new Point(1, y));
                    return ruch;
                }
            }
        // Sprawdzanie wygranej na przekątnej
            if (tablica[0,0].getWartosc() == Tablica.O && tablica[1,1].getWartosc() == Tablica.O && tablica[2,2].getWartosc() == Tablica.P)
            {
                ruch.setLokacja(new Point(2, 2));
                return ruch;
            }
            else if (tablica[2, 0].getWartosc() == Tablica.O && tablica[1, 1].getWartosc() == Tablica.O && tablica[0, 2].getWartosc() == Tablica.P)
            {
                ruch.setLokacja(new Point(0, 2));
                return ruch;
            }
            //
            if (tablica[0, 2].getWartosc() == Tablica.O && tablica[1, 1].getWartosc() == Tablica.O && tablica[2, 0].getWartosc() == Tablica.P)
            {
                ruch.setLokacja(new Point(0, 2));
                return ruch;
            }
            else if (tablica[2, 2].getWartosc() == Tablica.O && tablica[1, 1].getWartosc() == Tablica.O && tablica[0, 0].getWartosc() == Tablica.P)
            {
                ruch.setLokacja(new Point(0, 0));
                return ruch;
            }
            if (tablica[0, 0].getWartosc() == Tablica.O && tablica[1, 1].getWartosc() == Tablica.P && tablica[2, 0].getWartosc() == Tablica.O)
            {
                ruch.setLokacja(new Point(1, 1));
                return ruch;
            }
            else if (tablica[0, 2].getWartosc() == Tablica.O && tablica[1, 1].getWartosc() == Tablica.P && tablica[2, 0].getWartosc() == Tablica.O)
            {
                ruch.setLokacja(new Point(1, 1));
                return ruch;
            }
            // koniec algorytmu odpowiadającego za ofensywe-----------------------------------------------------------------------------------------------------------------------------------

            // Defensywa Komputera ------------------------------------------------------------------------------------------------------------------------------------------------------------


            for (int x = 0; x < 3; x++)
            {
                // sprwdzamy czy występują w kolumnie w lokacjach X,0 i X,1 X
                if (tablica[x, 0].getWartosc() == Tablica.X && tablica[x, 1].getWartosc() == Tablica.X && tablica[x, 2].getWartosc() == Tablica.P)
                {
                    ruch.setLokacja(new Point(x, 2));
                    return ruch;
                }
            }
            for (int x = 0; x < 3; x++)
            {
                // sprwdzamy czy występują w kolumnie w lokacjach X,1 i X,2 X
                if (tablica[x, 0].getWartosc() == Tablica.P && tablica[x, 1].getWartosc() == Tablica.X && tablica[x, 2].getWartosc() == Tablica.X)
                {
                    ruch.setLokacja(new Point(x, 0));
                    return ruch;
                }
            }
            for (int x = 0; x < 3; x++)
            {
                // sprwdzamy czy występują w kolumnie w lokacjach X,0 i X,2  X
                if (tablica[x, 0].getWartosc() == Tablica.X && tablica[x, 1].getWartosc() == Tablica.P && tablica[x, 2].getWartosc() == Tablica.X)
                {
                    ruch.setLokacja(new Point(x, 1));
                    return ruch;
                }
            }
            // Sprawdzanie poziomo możliwości przegrania
            for (int y = 0; y < 3; y++)
            {
                // sprwdzamy czy występują w kolumnie w lokacjach 0,y i 1,y  X
                if (tablica[0, y].getWartosc() == Tablica.X && tablica[1, y].getWartosc() == Tablica.X && tablica[2, y].getWartosc() == Tablica.P)
                {
                    ruch.setLokacja(new Point(2, y));
                    return ruch;
                }
            }
            for (int y = 0; y < 3; y++)
            {
                // sprwdzamy czy występują w kolumnie w lokacjach 1,y i 2,y  X
                if (tablica[0, y].getWartosc() == Tablica.P && tablica[1, y].getWartosc() == Tablica.X && tablica[2, y].getWartosc() == Tablica.X)
                {
                    ruch.setLokacja(new Point(0, y));
                    return ruch;
                }
            }
            for (int y = 0; y < 3; y++)
            {
                // sprwdzamy czy występują w kolumnie w lokacjach 0,y i 2,y  X
                if (tablica[0, y].getWartosc() == Tablica.X && tablica[1, y].getWartosc() == Tablica.P && tablica[2, y].getWartosc() == Tablica.X)
                {
                    ruch.setLokacja(new Point(1, y));
                    return ruch;
                }
            }
            // Sprawdzanie przegranej na przekątnej
            if (tablica[0, 0].getWartosc() == Tablica.X && tablica[1, 1].getWartosc() == Tablica.X && tablica[2, 2].getWartosc() == Tablica.P)
            {
                ruch.setLokacja(new Point(2, 2));
                return ruch;
            }
            else if (tablica[2, 0].getWartosc() == Tablica.X && tablica[1, 1].getWartosc() == Tablica.X && tablica[0, 2].getWartosc() == Tablica.P)
            {
                ruch.setLokacja(new Point(0, 2));
                return ruch;
            }
            //
            if (tablica[0, 2].getWartosc() == Tablica.X && tablica[1, 1].getWartosc() == Tablica.X && tablica[2, 0].getWartosc() == Tablica.P)
            {
                ruch.setLokacja(new Point(0, 2));
                return ruch;
            }
            else if (tablica[2, 2].getWartosc() == Tablica.X && tablica[1, 1].getWartosc() == Tablica.X && tablica[0, 0].getWartosc() == Tablica.P)
            {
                ruch.setLokacja(new Point(0, 0));
                return ruch;
            }
            if (tablica[0, 0].getWartosc() == Tablica.X && tablica[1, 1].getWartosc() == Tablica.P && tablica[2, 0].getWartosc() == Tablica.X)
            {
                ruch.setLokacja(new Point(1, 1));
                return ruch;
            }
            else if (tablica[0, 2].getWartosc() == Tablica.X && tablica[1, 1].getWartosc() == Tablica.P && tablica[2, 0].getWartosc() == Tablica.X)
            {
                ruch.setLokacja(new Point(1, 1));
                return ruch;
            }
            //
            //
            //
            //
            // W przypadku nie osiągnięcia z żadnych ww. warunków ruszamy gdziekolwiek 

            List<Posiadacz> pusteMiejsca = new List<Posiadacz>();
            foreach (Posiadacz h in tablica)
            {
                if (h.getWartosc() == Tablica.P)
                {
                    pusteMiejsca.Add(h);
                }
            }
            ruch.setLokacja(pusteMiejsca.ToArray()[0].getLokacja());
            return ruch;
        }
    }
}
