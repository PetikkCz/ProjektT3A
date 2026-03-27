using System;
using System.Drawing;
using System.Windows.Forms;

namespace Šibenice_Projekt_snad
{
    public partial class Form1 : Form
    {
        private string[] slova =
        {
            "SWITCH", "ROUTER", "VLAN", "DHCP", "FIREWALL",
            "MALWARE", "PHISHING", "SOC", "ENKRYPCE", "VPN",
            "PROXY", "SERVER", "CLIENT", "PORT", "PROTOKOL",
            "SSL", "TLS"
        };

        private string aktualniSlovo;
        private char[] zobrazeniSlova;
        private int chyby = 0;
        private const int maxChyb = 6;
        private Random r = new Random();
        private string pouzitaPismena = "";

        public Form1()
        {
            InitializeComponent();

            panelSibenice.Paint += PanelSibenice_Paint;
            btnHadej.Click += BtnHadej_Click;
            btnNova.Click += BtnNova_Click;
            txtZadani.KeyDown += TxtZadani_KeyDown;
            novaHraToolStripMenuItem.Click += NovaHraToolStripMenuItem_Click;
            konecToolStripMenuItem.Click += KonecToolStripMenuItem_Click;
            pravidlaToolStripMenuItem.Click += PravidlaToolStripMenuItem_Click;

            NovaHra();
        }

        private void NovaHra()
        {
            aktualniSlovo = slova[r.Next(slova.Length)];
            zobrazeniSlova = new char[aktualniSlovo.Length];

            for (int i = 0; i < zobrazeniSlova.Length; i++)
            {
                zobrazeniSlova[i] = '_';
            }

            chyby = 0;
            pouzitaPismena = "";

            UpdateZobrazeni();
            txtZadani.Clear();
            txtZadani.Focus();
            panelSibenice.Invalidate();
        }

        private void UpdateZobrazeni()
        {
            lblSlovo.Text = string.Join(" ", zobrazeniSlova);
            lblPouzitaPismena.Text = pouzitaPismena == "" ? "(žádná)" : pouzitaPismena;
            toolStripStatusLabel1.Text = "Chyby: " + chyby + " / " + maxChyb;
        }

        private void ZkontrolujPismeno()
        {
            if (txtZadani.Text.Length == 0)
            {
                MessageBox.Show("Zadej písmeno.");
                return;
            }

            char pismeno = char.ToUpper(txtZadani.Text[0]);

            if (!char.IsLetter(pismeno))
            {
                MessageBox.Show("Zadat můžeš jen písmeno.");
                txtZadani.Clear();
                return;
            }

            if (pouzitaPismena.Contains(pismeno.ToString()))
            {
                MessageBox.Show("Tohle písmeno už bylo použité.");
                txtZadani.Clear();
                return;
            }

            pouzitaPismena += pismeno + " ";

            bool nalezeno = false;

            for (int i = 0; i < aktualniSlovo.Length; i++)
            {
                if (aktualniSlovo[i] == pismeno)
                {
                    zobrazeniSlova[i] = pismeno;
                    nalezeno = true;
                }
            }

            if (!nalezeno)
            {
                chyby++;
            }

            UpdateZobrazeni();
            panelSibenice.Invalidate();

            if (string.Join("", zobrazeniSlova) == aktualniSlovo)
            {
                MessageBox.Show("Vyhrál jsi! Slovo bylo: " + aktualniSlovo);
                NovaHra();
                return;
            }

            if (chyby >= maxChyb)
            {
                MessageBox.Show("Prohrál jsi! Slovo bylo: " + aktualniSlovo);
                NovaHra();
                return;
            }

            txtZadani.Clear();
            txtZadani.Focus();
        }

        private void BtnHadej_Click(object sender, EventArgs e)
        {
            ZkontrolujPismeno();
        }

        private void BtnNova_Click(object sender, EventArgs e)
        {
            NovaHra();
        }

        private void TxtZadani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ZkontrolujPismeno();
                e.SuppressKeyPress = true;
            }
        }

        private void NovaHraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaHra();
        }

        private void KonecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PravidlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pravidla =
                                "                           PRAVIDLA HRY ŠIBENICE\n\n" +
                                "Cíl hry:\n" +
                                "Uhádnout tajné slovo dříve, než se vyčerpají všechny pokusy.\n\n" +

                                "Jak hrát:\n" +
                                "• Zadáváš vždy jedno písmeno\n" +
                                "• Pokud je písmeno ve slově, odkryje se na správných místech\n" +
                                "• Pokud tam není, přičte se chyba a kreslí se šibenice\n" +
                                "• Potvrdit písmeno lze i pomocí klávesy ENTER\n\n" +

                                "Pravidla:\n" +
                                "• Máš maximálně 6 chyb\n" +
                                "• Nemůžeš zadat stejné písmeno dvakrát\n" +
                                "• Zadávat můžeš jen písmena (žádná čísla ani znaky)\n\n" +

                                "Konec hry:\n" +
                                "• Výhra: uhodneš celé slovo\n" +
                                "• Prohra: dosáhneš 6 chyb\n\n" +

                                "Po skončení hry se automaticky spustí nová hra.\n" +
                                "Ale nemusíš hádat, pokud se ti nebude chtít ;D";

            MessageBox.Show(pravidla, "Pravidla hry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PanelSibenice_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pero = new Pen(Color.Black, 3);

            g.DrawLine(pero, 30, 250, 180, 250);
            g.DrawLine(pero, 60, 250, 60, 30);
            g.DrawLine(pero, 60, 30, 150, 30);
            g.DrawLine(pero, 150, 30, 150, 60);

            if (chyby >= 1)
            {
                g.DrawEllipse(pero, 130, 60, 40, 40);
            }

            if (chyby >= 2)
            {
                g.DrawLine(pero, 150, 100, 150, 160);
            }

            if (chyby >= 3)
            {
                g.DrawLine(pero, 150, 115, 120, 140);
            }

            if (chyby >= 4)
            {
                g.DrawLine(pero, 150, 115, 180, 140);
            }

            if (chyby >= 5)
            {
                g.DrawLine(pero, 150, 160, 125, 200);
            }

            if (chyby >= 6)
            {
                g.DrawLine(pero, 150, 160, 175, 200);
            }
        }
    }
}