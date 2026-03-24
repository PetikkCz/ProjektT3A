using System;

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
        }

        private void NovaHra()
        {
        }

        private void UpdateZobrazeni()
        {
        }

        private void ZkontrolujPismeno()
        {
        }

        private void BtnHadej_Click(object sender, EventArgs e)
        {
        }

        private void BtnNova_Click(object sender, EventArgs e)
        {
        }

        private void TxtZadani_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void NovaHraToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void lblSlovo_Click(object sender, EventArgs e)
        {

        }
    }
}