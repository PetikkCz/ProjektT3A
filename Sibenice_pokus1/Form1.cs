using System.Runtime.CompilerServices;

namespace Sibenice_pokus1
{
    public partial class Form1 : Form
    {

        private string[] slova = { "LIDL" };
        private string aktualniSlovo;
        private char[] zobrazeniSlova;
        private int chyby = 0;
        private const int maxChyby = 6;
        private TextBox txtZadani;
        private Button btnHadej;
        private Label lblSlovo;
        private Panel panelSibenice;


        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.Text = "Šibenice";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            CreateMainMenu();
            CreateToolbar();
            CreateStatusStrip();
            CreateGamePanel();
            NovaHra();

        }

        private void CreateMainMenu()
        {
            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem hraMenuItem = new ToolStripMenuItem("Hra");
            hraMenuItem.DropDownItems.Add("Nová hra", null, Novahra_Click);
            hraMenuItem.DropDownItems.Add("Konec", null, Konec_Click);

            ToolStripMenuItem nastrojeMenuItem = new ToolStripMenuItem("Nástroje");
            nastrojeMenuItem.DropDownItems.Add("Nastavení", null, Nastaveni_Click);

            menuStrip.Items.Add(hraMenuItem);
            menuStrip.Items.Add(nastrojeMenuItem);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

        }

        private void CreateToolbar()
        {
            ToolStrip toolStrip = new ToolStrip();
            toolStrip.Dock = DockStyle.Top;

            ToolStripButton novaHraButton = new ToolStripButton("Nová hra");
            novaHraButton.Click += Novahra_Click;

            ToolStripButton konecButton = new ToolStripButton("Konec");
            konecButton.Click += Konec_Click;

            toolStrip.Items.Add(novaHraButton);
            toolStrip.Items.Add(konecButton);

            this.Controls.Add(toolStrip);
        }

        private void CreateStatusStrip()
        {
            StatusStrip statusStrip = new StatusStrip();
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel("Vítejte ve høe Šibenice!");
            statusStrip.Items.Add(statusLabel);

            this.Controls.Add(statusStrip);
        }

        private void CreateGamePanel()
        {
            
            panelSibenice = new Panel();
            panelSibenice.Size = new Size(300, 300);
            panelSibenice.Location = new Point(50, 150);
            panelSibenice.BackColor = Color.White;
            panelSibenice.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panelSibenice);

            lblSlovo = new Label();
            lblSlovo.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lblSlovo.Location = new Point(50, 100);
            lblSlovo.Size = new Size(400, 30);
            this.Controls.Add(lblSlovo);

            txtZadani = new TextBox();
            txtZadani.Location = new Point(50, 400);
            txtZadani.Size = new Size(100, 25);
            txtZadani.MaxLength = 1;
            this.Controls.Add(txtZadani);

            btnHadej = new Button();
            btnHadej.Text = "Hádej";
            btnHadej.Location = new Point(160, 400);
            btnHadej.Size = new Size(80, 25);
            btnHadej.Click += BtnHadej_Click;
            this.Controls.Add(btnHadej);

        }

        private void NovaHra()
        {
            Random random = new Random();
            aktualniSlovo = slova[random.Next(slova.Length)];
            zobrazeniSlova = new char[aktualniSlovo.Length];

            for (int i = 0; i < zobrazeniSlova.Length; i++)
            {
                zobrazeniSlova[i] = '_';
            }

            chyby = 0;
            UpdateZobrazeniSlova();
            panelSibenice.Invalidate();
        }

        private void UpdateZobrazeniSlova()
        {
            string zobrazeni = "";
            foreach (char c in zobrazeniSlova)
            {
                zobrazeni += c + " ";
            }

            lblSlovo.Text = zobrazeni;
        }
            
        private void BtnHadej_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtZadani.Text))
            {
                MessageBox.Show("Zadejte písmeno!");
                return;
            }

            char hadanePismeno = txtZadani.Text.ToUpper()[0];

            if (!char.IsLetter(hadanePismeno))
            {
                MessageBox.Show("Zadávat se smí pouze písmena!");
                txtZadani.Clear();
                return;
            }

            bool spravne = false;
            for (int i = 0; i < aktualniSlovo.Length; i++)
            {
                if (aktualniSlovo[i] == hadanePismeno)
                {
                    zobrazeniSlova[i] = hadanePismeno;
                    spravne = true;
                }
            }

            if (!spravne)
            {
                chyby++;
                MessageBox.Show($"Špatnì! Poèet chyb: {chyby}/{maxChyby}");
            }

            UpdateZobrazeniSlova();
            VykresliSibenici();

            if (string.Join("", zobrazeniSlova) == aktualniSlovo)
            {
                MessageBox.Show("Gratulujeme! Vyhráli jste!");
                NovaHra();
            }
            else if (chyby >= maxChyby)
            {
                MessageBox.Show($"Prohráli jste! Správné slovo bylo: {aktualniSlovo}");
                NovaHra();
            }

            txtZadani.Clear();
        }

        private void VykresliSibenici()
        {
            panelSibenice.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e) 
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Pen pero = new Pen(Color.Black, 3);

            g.DrawLine(pero, 50, 250, 250, 250);
            g.DrawLine(pero, 100, 250, 100, 50);
            g.DrawLine(pero, 100, 50, 200, 50);
            g.DrawLine(pero, 200, 50, 200, 80);


            if (chyby >= 1) // Hlava
            {
                g.DrawEllipse(pero, 185, 80, 30, 30);
            }

            if (chyby >= 2) // Tìlo
            {
                g.DrawLine(pero, 200, 110, 200, 170);
            }

            if (chyby >= 3) // Levá ruka
            {
                g.DrawLine(pero, 200, 130, 170, 150);
            }

            if (chyby >= 4) // Pravá ruka
            {
                g.DrawLine(pero, 200, 130, 230, 150);
            }

            if (chyby >= 5) // Levá noha
            {
                g.DrawLine(pero, 200, 170, 170, 200);
            }

            if (chyby >= 6) // Pravá noha
            {
                g.DrawLine(pero, 200, 170, 230, 200);
            }

            pero.Dispose();


        }

        private void Novahra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nová hra byla spuštìna!");
        }

        private void Konec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nastaveni_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nastavení hry");
        }


    }
}
