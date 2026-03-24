using System.Windows.Forms;

namespace Šibenice_Projekt_snad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
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
            lblSlovo.Text = "_ _ _ _ _";
            lblSlovo.TextAlign = ContentAlignment.MiddleCenter;
            lblSlovo.Click += lblSlovo_Click;
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
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 22);
            statusStrip1.TabIndex = 8;
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
            ClientSize = new Size(900, 450);
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
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Šibenice";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}