namespace WFA24100901
{
    public partial class FrmBevLista : Form
    {
        public FrmBevLista()
        {
            InitializeComponent();
            txbUjTetel.TextChanged += TxbUjTetel_TextChanged;
            btnHozzaadas.Click += BtnHozzaadas_Click;
            btnOsszesTorlese.Click += BtnOsszesTorlese_Click;
            btnKijeloltTorlese.Click += BtnKijeloltTorlese_Click;
        }

        private void BtnKijeloltTorlese_Click(object? sender, EventArgs e)
        {
            while (lsbTetelek.SelectedItems.Count > 0)
                lsbTetelek.Items.Remove(lsbTetelek.SelectedItems[0]);
        }

        private void BtnOsszesTorlese_Click(object? sender, EventArgs e)
        {
            lsbTetelek.Items.Clear();
        }

        private void BtnHozzaadas_Click(object? sender, EventArgs e)
        {
            lsbTetelek.Items.Add(txbUjTetel.Text);
        }

        private void TxbUjTetel_TextChanged(object? sender, EventArgs e)
        {
            btnHozzaadas.Enabled = !string.IsNullOrWhiteSpace(txbUjTetel.Text);
        }
    }
}
