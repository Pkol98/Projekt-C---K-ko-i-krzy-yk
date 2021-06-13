using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace KK_01
{
    // MODEL *******************
    public class Tablica : Form1
    {
        // OKREŚLA KTÓRY RUCH
        public int ruch = 0;
        // OKREŚLA ILE WYGRAŁO RAZY O
        public int Owygrywa = 0;
        // OKREŚLA ILE WYGRAŁO RAZY X
        public int Xwygrywa = 0;
        
        private Posiadacz[,] posiadacze = new Posiadacz[3, 3];
        // WARTOŚĆ SEKCJI Z  X
        public const int X = 0;
        // WARTOŚĆ SEKCJI Z  O
        public const int O = 1;
        // WARTOŚĆ SEKCJI Z  PUSTEJ
        public const int P = 2;

        public int kolejGracza = X;
        public int kolejnyGracz()
        {
            return kolejGracza;
        }
        public int gdyOwygra()
        {
            return Owygrywa;
        }
        public int gdyXwygra()
        {
            return Xwygrywa;
        }
        // GENERUJEMY TABLICE [3,3] PUSTYCH LOKACJI
        public void tworzTablice()
            {
            for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                    posiadacze[i, j] = new Posiadacz();
                    posiadacze[i, j].setWartosc(P);
                    posiadacze[i, j].setLokacja(new Point(i, j));
                    }

                }
            }
        public void wykryjMysz(Point loc)
        {
            // Sprawdzamy czy kliknięcie jest w tablice gry i dokładnie w którym sektorze kliknelismy 
            if (loc.Y <= 500)
            {
                int x = 0;
                int y = 0;
                if (loc.X < 167)
                {
                    x = 0;
                }
                else if (loc.X > 167 && loc.X < 334)
                {
                    x = 1;
                }
                else if (loc.X > 334)
                {
                    x = 2;
                }
                if (loc.Y < 167)
                {
                    y = 0;
                }
                else if (loc.Y > 167 && loc.Y < 334)
                {
                    y = 1;
                }
                else if (loc.Y > 334 && loc.Y < 500)
                {
                    y = 2;
                }
                
                // SPRAWDZAMY CZY KOLEJ RUCHU X
                if (ruch % 2 ==0 )
                {
                    Grafika.drawX(new Point(x, y));
                    if (posiadacze[x, y].getWartosc() == 2)
                    {


                        posiadacze[x, y].setWartosc(X);
                        if (szukanieWygranej())
                        {
                            MessageBox.Show("Wygrałeś gracz X");
                            Xwygrywa++;
                            reset();
                            Grafika.genTla();

                        }
                        if (tablicaPelna())
                        {
                            reset();
                            ruch++;

                        }
                    }
                    // SPRAWDZAMY CZY KOLEJ RUCHU KOMPUTERA
                    if (Form1.grajzKomputerem() && !szukanieWygranej() && !tablicaPelna())
                    {
                        Posiadacz ruchKomputera = Komputer.miejsceRuchuKomputera(posiadacze);
                       
                        Grafika.drawO(ruchKomputera.getLokacja());
                        posiadacze[ruchKomputera.getLokacja().X, ruchKomputera.getLokacja().Y ].setWartosc(O);
                        if (szukanieWygranej())
                        {
                            MessageBox.Show("Wygrał komputer");
                            Owygrywa++;
                            reset();
                            Grafika.genTla();
                        }
                        ruch++;
                        kolejGracza = X;

                    }
                    kolejGracza = O;
                }
                // W INNYM PRZYPADKU JEST TO KOLEJ GRACZA O
                else
                {
                    Grafika.drawO(new Point(x, y));
                    posiadacze[x, y].setWartosc(O);
                    if (szukanieWygranej())
                    {
                        MessageBox.Show("Wygrałeś gracz O");
                        Owygrywa++;
                        reset();
                        Grafika.genTla();
                    }
                    kolejGracza = X;
                }
                ruch++;

                // pokazywanie orientacji kliknięcia oraz sektora
                // MessageBox.Show(x.ToString() + "," + y.ToString() + "\n\n" + loc.ToString());

            }
        }
        // Sprawdzanie wygranej 
        public bool szukanieWygranej()
        {  
            bool Wygrana = false;
            // Sprawdzanie wygranych na liniach poziomych, pionowych oraz przekątnych
            for (int x = 0; x < 3; x++)
            {
                if (posiadacze[x, 0].getWartosc() == X && posiadacze[x, 1].getWartosc() == X && posiadacze[x, 2].getWartosc() == X)
                {
                    return true;
                }
                if (posiadacze[x, 0].getWartosc() == O && posiadacze[x, 1].getWartosc() == O && posiadacze[x, 2].getWartosc() == O)
                {
                    return true;
                }
                switch (x)
                {
                    case 0:
                        if (posiadacze[x, 0].getWartosc() ==  X && posiadacze[x+1, 1].getWartosc() == X && posiadacze[x+2, 2].getWartosc() == X)
                        {
                            return true;
                        }
                        if (posiadacze[x, 0].getWartosc() == O && posiadacze[x + 1, 1].getWartosc() == O && posiadacze[x + 2, 2].getWartosc() == O)
                        {
                            return true;
                        }
                        break;
                    case 2:
                        if (posiadacze[x, 0].getWartosc() == X && posiadacze[x - 1, 1].getWartosc() == X && posiadacze[x - 2, 2].getWartosc() == X)
                        {
                            return true;
                        }
                        if (posiadacze[x, 0].getWartosc() == O && posiadacze[x - 1, 1].getWartosc() == O && posiadacze[x - 2, 2].getWartosc() == O)
                        {
                            return true;
                        }
                        break;

                }
            }
            for (int y = 0; y < 3; y++)
            {
                if (posiadacze[0, y].getWartosc() == X && posiadacze[1, y].getWartosc() == X && posiadacze[2, y].getWartosc() == X)
                {
                    return true;
                }
                if (posiadacze[0, y].getWartosc() == O && posiadacze[1, y].getWartosc() == O && posiadacze[2, y].getWartosc() == O)
                {
                    return true;
                }
            }
            return Wygrana;

        }
        // RESETOWANIE TABLICY
        public void reset()
        {
            posiadacze = new Posiadacz[3, 3];
            tworzTablice();
        }
        // SPRAWDZANIE CZY TABLICA NIE JEST ZAPEŁNIONA CAŁKOWICIE- W TAKIM PRZYPADKU NIE MA RUCHU
        public bool tablicaPelna()
        {
            bool pelna = true;
            foreach (Posiadacz h in posiadacze)
            {
                if (h.getWartosc() == Tablica.P)
                {
                    pelna = false;
                }
            }  
            return pelna;
        }
    }
}
