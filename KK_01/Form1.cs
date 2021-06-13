using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK_01
{
    // KONTROLER ********************
    public partial class Form1 : Form
    {
        public Grafika generator;
        public Tablica tablica;
        public static bool graKomputer = false;

        // WYBRANIE GRY Z KOMPUTEREM
        public static bool grajzKomputerem()
        {
            return graKomputer;
        }
        public Form1()
        {
            InitializeComponent();
            
        }
        // 1 panel gry odpowiedzialny za szachownice
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Przekaz = panel1.CreateGraphics();
            generator = new Grafika(Przekaz);

            tablica = new Tablica();
            tablica.tworzTablice();

            odswiezLabel();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point mysz = Cursor.Position;
            mysz = panel1.PointToClient(mysz);
            // określa gdzie zostało kliknięte 
            tablica.wykryjMysz(mysz);
            // Odświeża Label w panelu
            odswiezLabel();
        }

        // RESET gry
        private void button1_Click(object sender, EventArgs e)
        {
            // Resetuje tablice
            tablica.reset();
            Grafika.genTla();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        // PRZYCIŚNIĘCIE PRZYCISKU WIĘCEJ
        private void aPrzycisk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Projekt wykonany na zajęcia inżynierii oprogramowania MT 2020/2021");
        }
        // PRZYCISNIECIE PRZYCISKU WYJSCIE
        private void wyjPrzycisk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // ODŚWIEŻANIE LABEL 1 W OKNIE GRACZA
        public void odswiezLabel()
        {
            String nowyTekst = " To kolej ";
            if (tablica.kolejnyGracz() == Tablica.X)
            {
                nowyTekst += "X";
            }
            else
            {
                nowyTekst += "O";
            }
            nowyTekst += "  \n";
            nowyTekst += " X wygrało " + tablica.gdyXwygra() + " razy \n O wygrało " + tablica.gdyOwygra() + " razy \n ";
            label1.Text = nowyTekst;
        }
        // OKNO WYBORU GRY Z KOMPUTEREM LUB GRY WE DWOJE
        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Czy chcesz grać z komputerem w", "Kółko i Krzyżyk", MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
                graKomputer = true; 
            }
        }
    }
}
