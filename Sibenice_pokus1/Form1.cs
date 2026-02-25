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

        private void InitializeGame();
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
            hraMenuItem.DropDownItems.Add("Nová hra", null, NovaHra_Click);
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
            ToolStrip.Dock = DockStyle.Top;

            ToolStripButton novaHraButton = new ToolStripButton("Nová hra");
            novaHraButton.Click += NovaHra_Click;

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
            btnHadej.Location = new Point(160. 400);
            btnHadej.Size = new Size(80, 25);
            btnHadej.Click += BtnHadej_Click;
            this.Controls.Add(btnHadej);

        }

        private void NovaHra()
        {
            Random random = new Random();
            aktualniSlovo = slova[random.Next(slova.Length)];
            zobrazeniSlova = new char[aktualniSlovo.Length];

            for (int i=0, i<zobrazeniSlova.Length; i++)
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
