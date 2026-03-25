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
        }

        private void BtnHadej_Click(object sender, EventArgs e)
        {
        }

        private void BtnNova_Click(object sender, EventArgs e)
        {
            NovaHra();
        }

        private void TxtZadani_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void NovaHraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaHra();
        }

        private void KonecToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PravidlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PanelSibenice_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}