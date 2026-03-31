using System.Drawing;
using System.Windows.Forms;

namespace Šibenice_Projekt_snad
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hraToolStripMenuItem = new ToolStripMenuItem();
            novaHraToolStripMenuItem = new ToolStripMenuItem();
            konecToolStripMenuItem = new ToolStripMenuItem();
            napovedaToolStripMenuItem = new ToolStripMenuItem();
            pravidlaToolStripMenuItem = new ToolStripMenuItem();
            panelSibenice = new Panel();
            lblSlovo = new Label();
            txtZadani = new TextBox();
            btnHadej = new Button();
            btnNova = new Button();
            lblPouzitaPismenaNadpis = new Label();
            lblPouzitaPismena = new Label();
            groupBoxKlavesnice = new GroupBox();
            panelKlavesnice = new Panel();
            btnĚ = new Button();
            btnŠ = new Button();
            btnČ = new Button();
            btnŘ = new Button();
            btnŽ = new Button();
            btnÝ = new Button();
            btnÁ = new Button();
            btnÍ = new Button();
            btnÉ = new Button();
            btnŤ = new Button();
            btnQ = new Button();
            btnW = new Button();
            btnE = new Button();
            btnR = new Button();
            btnT = new Button();
            btnZ = new Button();
            btnU = new Button();
            btnI = new Button();
            btnO = new Button();
            btnP = new Button();
            btnA = new Button();
            btnS = new Button();
            btnD = new Button();
            btnF = new Button();
            btnG = new Button();
            btnH = new Button();
            btnJ = new Button();
            btnK = new Button();
            btnL = new Button();
            btnY = new Button();
            btnX = new Button();
            btnC = new Button();
            btnV = new Button();
            btnB = new Button();
            btnN = new Button();
            btnM = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            groupBoxKlavesnice.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hraToolStripMenuItem, napovedaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hraToolStripMenuItem
            // 
            hraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaHraToolStripMenuItem, konecToolStripMenuItem });
            hraToolStripMenuItem.Name = "hraToolStripMenuItem";
            hraToolStripMenuItem.Size = new Size(38, 20);
            hraToolStripMenuItem.Text = "Hra";
            // 
            // novaHraToolStripMenuItem
            // 
            novaHraToolStripMenuItem.Name = "novaHraToolStripMenuItem";
            novaHraToolStripMenuItem.Size = new Size(122, 22);
            novaHraToolStripMenuItem.Text = "Nová hra";
            // 
            // konecToolStripMenuItem
            // 
            konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            konecToolStripMenuItem.Size = new Size(122, 22);
            konecToolStripMenuItem.Text = "Konec";
            // 
            // napovedaToolStripMenuItem
            // 
            napovedaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pravidlaToolStripMenuItem });
            napovedaToolStripMenuItem.Name = "napovedaToolStripMenuItem";
            napovedaToolStripMenuItem.Size = new Size(73, 20);
            napovedaToolStripMenuItem.Text = "Nápověda";
            // 
            // pravidlaToolStripMenuItem
            // 
            pravidlaToolStripMenuItem.Name = "pravidlaToolStripMenuItem";
            pravidlaToolStripMenuItem.Size = new Size(116, 22);
            pravidlaToolStripMenuItem.Text = "Pravidla";
            // 
            // panelSibenice
            // 
            panelSibenice.BackColor = Color.White;
            panelSibenice.BorderStyle = BorderStyle.FixedSingle;
            panelSibenice.Location = new Point(25, 45);
            panelSibenice.Name = "panelSibenice";
            panelSibenice.Size = new Size(300, 300);
            panelSibenice.TabIndex = 1;
            // 
            // lblSlovo
            // 
            lblSlovo.BackColor = Color.FromArgb(220, 240, 255);
            lblSlovo.BorderStyle = BorderStyle.FixedSingle;
            lblSlovo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblSlovo.ForeColor = Color.FromArgb(0, 100, 150);
            lblSlovo.Location = new Point(360, 45);
            lblSlovo.Name = "lblSlovo";
            lblSlovo.Size = new Size(500, 100);
            lblSlovo.TabIndex = 2;
            lblSlovo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtZadani
            // 
            txtZadani.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtZadani.Location = new Point(360, 165);
            txtZadani.MaxLength = 1;
            txtZadani.Name = "txtZadani";
            txtZadani.Size = new Size(60, 36);
            txtZadani.TabIndex = 3;
            txtZadani.TextAlign = HorizontalAlignment.Center;
            // 
            // btnHadej
            // 
            btnHadej.BackColor = Color.FromArgb(70, 180, 100);
            btnHadej.FlatStyle = FlatStyle.Flat;
            btnHadej.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHadej.ForeColor = Color.White;
            btnHadej.Location = new Point(435, 165);
            btnHadej.Name = "btnHadej";
            btnHadej.Size = new Size(85, 36);
            btnHadej.TabIndex = 4;
            btnHadej.Text = "Hádej";
            btnHadej.UseVisualStyleBackColor = false;
            // 
            // btnNova
            // 
            btnNova.BackColor = Color.FromArgb(200, 130, 50);
            btnNova.FlatStyle = FlatStyle.Flat;
            btnNova.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNova.ForeColor = Color.White;
            btnNova.Location = new Point(535, 165);
            btnNova.Name = "btnNova";
            btnNova.Size = new Size(100, 36);
            btnNova.TabIndex = 5;
            btnNova.Text = "Nová hra";
            btnNova.UseVisualStyleBackColor = false;
            // 
            // lblPouzitaPismenaNadpis
            // 
            lblPouzitaPismenaNadpis.AutoSize = true;
            lblPouzitaPismenaNadpis.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPouzitaPismenaNadpis.ForeColor = Color.FromArgb(0, 100, 150);
            lblPouzitaPismenaNadpis.Location = new Point(360, 220);
            lblPouzitaPismenaNadpis.Name = "lblPouzitaPismenaNadpis";
            lblPouzitaPismenaNadpis.Size = new Size(128, 20);
            lblPouzitaPismenaNadpis.TabIndex = 6;
            lblPouzitaPismenaNadpis.Text = "Použitá písmena:";
            // 
            // lblPouzitaPismena
            // 
            lblPouzitaPismena.BackColor = Color.FromArgb(250, 250, 255);
            lblPouzitaPismena.BorderStyle = BorderStyle.FixedSingle;
            lblPouzitaPismena.Font = new Font("Segoe UI", 12F);
            lblPouzitaPismena.Location = new Point(360, 250);
            lblPouzitaPismena.Name = "lblPouzitaPismena";
            lblPouzitaPismena.Padding = new Padding(10);
            lblPouzitaPismena.Size = new Size(500, 80);
            lblPouzitaPismena.TabIndex = 7;
            lblPouzitaPismena.Text = "(žádná)";
            // 
            // groupBoxKlavesnice
            // 
            groupBoxKlavesnice.Controls.Add(panelKlavesnice);
            groupBoxKlavesnice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxKlavesnice.ForeColor = Color.FromArgb(0, 100, 150);
            groupBoxKlavesnice.Location = new Point(25, 345);
            groupBoxKlavesnice.Name = "groupBoxKlavesnice";
            groupBoxKlavesnice.Size = new Size(835, 330);
            groupBoxKlavesnice.TabIndex = 8;
            groupBoxKlavesnice.TabStop = false;
            groupBoxKlavesnice.Text = "Klávesnice";
            // 
            // panelKlavesnice
            // 
            panelKlavesnice.Location = new Point(15, 28);
            panelKlavesnice.Name = "panelKlavesnice";
            panelKlavesnice.Size = new Size(805, 285);
            panelKlavesnice.TabIndex = 0;
            // 
            // tlačítka - 1. řada diakritika
            // 
            NastavPoziciTlacitka(btnĚ, 48, 10, "Ě");
            NastavPoziciTlacitka(btnŠ, 113, 10, "Š");
            NastavPoziciTlacitka(btnČ, 178, 10, "Č");
            NastavPoziciTlacitka(btnŘ, 243, 10, "Ř");
            NastavPoziciTlacitka(btnŽ, 308, 10, "Ž");
            NastavPoziciTlacitka(btnÝ, 373, 10, "Ý");
            NastavPoziciTlacitka(btnÁ, 438, 10, "Á");
            NastavPoziciTlacitka(btnÍ, 503, 10, "Í");
            NastavPoziciTlacitka(btnÉ, 568, 10, "É");
            NastavPoziciTlacitka(btnŤ, 633, 10, "Ť");
            // 
            // tlačítka - 2. řada QWERTZ
            // 
            NastavPoziciTlacitka(btnQ, 48, 78, "Q");
            NastavPoziciTlacitka(btnW, 113, 78, "W");
            NastavPoziciTlacitka(btnE, 178, 78, "E");
            NastavPoziciTlacitka(btnR, 243, 78, "R");
            NastavPoziciTlacitka(btnT, 308, 78, "T");
            NastavPoziciTlacitka(btnZ, 373, 78, "Z");
            NastavPoziciTlacitka(btnU, 438, 78, "U");
            NastavPoziciTlacitka(btnI, 503, 78, "I");
            NastavPoziciTlacitka(btnO, 568, 78, "O");
            NastavPoziciTlacitka(btnP, 633, 78, "P");
            // 
            // tlačítka - 3. řada
            // 
            NastavPoziciTlacitka(btnA, 80, 146, "A");
            NastavPoziciTlacitka(btnS, 145, 146, "S");
            NastavPoziciTlacitka(btnD, 210, 146, "D");
            NastavPoziciTlacitka(btnF, 275, 146, "F");
            NastavPoziciTlacitka(btnG, 340, 146, "G");
            NastavPoziciTlacitka(btnH, 405, 146, "H");
            NastavPoziciTlacitka(btnJ, 470, 146, "J");
            NastavPoziciTlacitka(btnK, 535, 146, "K");
            NastavPoziciTlacitka(btnL, 600, 146, "L");
            // 
            // tlačítka - 4. řada
            // 
            NastavPoziciTlacitka(btnY, 145, 206, "Y");
            NastavPoziciTlacitka(btnX, 210, 206, "X");
            NastavPoziciTlacitka(btnC, 275, 206, "C");
            NastavPoziciTlacitka(btnV, 340, 206, "V");
            NastavPoziciTlacitka(btnB, 405, 206, "B");
            NastavPoziciTlacitka(btnN, 470, 206, "N");
            NastavPoziciTlacitka(btnM, 535, 206, "M");

            panelKlavesnice.Controls.Add(btnĚ);
            panelKlavesnice.Controls.Add(btnŠ);
            panelKlavesnice.Controls.Add(btnČ);
            panelKlavesnice.Controls.Add(btnŘ);
            panelKlavesnice.Controls.Add(btnŽ);
            panelKlavesnice.Controls.Add(btnÝ);
            panelKlavesnice.Controls.Add(btnÁ);
            panelKlavesnice.Controls.Add(btnÍ);
            panelKlavesnice.Controls.Add(btnÉ);
            panelKlavesnice.Controls.Add(btnŤ);

            panelKlavesnice.Controls.Add(btnQ);
            panelKlavesnice.Controls.Add(btnW);
            panelKlavesnice.Controls.Add(btnE);
            panelKlavesnice.Controls.Add(btnR);
            panelKlavesnice.Controls.Add(btnT);
            panelKlavesnice.Controls.Add(btnZ);
            panelKlavesnice.Controls.Add(btnU);
            panelKlavesnice.Controls.Add(btnI);
            panelKlavesnice.Controls.Add(btnO);
            panelKlavesnice.Controls.Add(btnP);

            panelKlavesnice.Controls.Add(btnA);
            panelKlavesnice.Controls.Add(btnS);
            panelKlavesnice.Controls.Add(btnD);
            panelKlavesnice.Controls.Add(btnF);
            panelKlavesnice.Controls.Add(btnG);
            panelKlavesnice.Controls.Add(btnH);
            panelKlavesnice.Controls.Add(btnJ);
            panelKlavesnice.Controls.Add(btnK);
            panelKlavesnice.Controls.Add(btnL);

            panelKlavesnice.Controls.Add(btnY);
            panelKlavesnice.Controls.Add(btnX);
            panelKlavesnice.Controls.Add(btnC);
            panelKlavesnice.Controls.Add(btnV);
            panelKlavesnice.Controls.Add(btnB);
            panelKlavesnice.Controls.Add(btnN);
            panelKlavesnice.Controls.Add(btnM);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 718);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(57, 17);
            toolStripStatusLabel1.Text = "Připraven";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 250);
            ClientSize = new Size(900, 740);
            Controls.Add(groupBoxKlavesnice);
            Controls.Add(statusStrip1);
            Controls.Add(lblPouzitaPismena);
            Controls.Add(lblPouzitaPismenaNadpis);
            Controls.Add(btnNova);
            Controls.Add(btnHadej);
            Controls.Add(txtZadani);
            Controls.Add(lblSlovo);
            Controls.Add(panelSibenice);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(916, 779);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Šibenice";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxKlavesnice.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void NastavTlacitkoKlavesy(Button tlacitko, string text)
        {
            tlacitko.BackColor = Color.White;
            tlacitko.FlatStyle = FlatStyle.Flat;
            tlacitko.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            tlacitko.ForeColor = Color.FromArgb(0, 100, 150);
            tlacitko.Name = "btn" + text;
            tlacitko.Size = new Size(58, 58);
            tlacitko.TabIndex = 0;
            tlacitko.Text = text;
            tlacitko.UseVisualStyleBackColor = false;
        }

        private void NastavPoziciTlacitka(Button tlacitko, int x, int y, string text)
        {
            NastavTlacitkoKlavesy(tlacitko, text);
            tlacitko.Location = new Point(x, y);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hraToolStripMenuItem;
        private ToolStripMenuItem novaHraToolStripMenuItem;
        private ToolStripMenuItem konecToolStripMenuItem;
        private ToolStripMenuItem napovedaToolStripMenuItem;
        private ToolStripMenuItem pravidlaToolStripMenuItem;
        private Panel panelSibenice;
        private Label lblSlovo;
        private TextBox txtZadani;
        private Button btnHadej;
        private Button btnNova;
        private Label lblPouzitaPismenaNadpis;
        private Label lblPouzitaPismena;
        private GroupBox groupBoxKlavesnice;
        private Panel panelKlavesnice;
        private Button btnŤ;
        private Button btnĚ;
        private Button btnŠ;
        private Button btnČ;
        private Button btnŘ;
        private Button btnŽ;
        private Button btnÝ;
        private Button btnÁ;
        private Button btnÍ;
        private Button btnÉ;
        private Button btnQ;
        private Button btnW;
        private Button btnE;
        private Button btnR;
        private Button btnT;
        private Button btnZ;
        private Button btnU;
        private Button btnI;
        private Button btnO;
        private Button btnP;
        private Button btnA;
        private Button btnS;
        private Button btnD;
        private Button btnF;
        private Button btnG;
        private Button btnH;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnY;
        private Button btnX;
        private Button btnC;
        private Button btnV;
        private Button btnB;
        private Button btnN;
        private Button btnM;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}