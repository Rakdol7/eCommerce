namespace eCommerce
{
    public partial class Form1 : Form
    {
        private Carrello c1;
        private Prodotto p1;
        private Prodotto p2;
        public Form1()
        {
            InitializeComponent();
            c1 = new Carrello("12345");
            p1 = new Prodotto("EA Sports", "FC25", "54321", 69.99);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aggiunta_Click(object sender, EventArgs e)
        {
            c1.aggiungiProdotto(p1);
            AggiornaInterfaccia();
        }

        private void Rimozione_Click(object sender, EventArgs e)
        {
            c1.rimuoviProdottoVistaInClasse(p1);
            AggiornaInterfaccia();
        }

        private void AggiornaInterfaccia()
        {
            ListBoxCarrello.DataSource = null;
            ListBoxCarrello.DataSource = c1.Prodotti;
            ListBoxCarrello.DisplayMember = "Modello";
        }
    }
}
