using System.Runtime.CompilerServices;

namespace Sibenice_pokus1
{
    public partial class Form1 : Form
    {
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
