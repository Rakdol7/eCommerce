namespace eCommerce
{
    public partial class Form1 : Form
    {
        private Carrello c1;
        private Prodotto p1;
        private Prodotto p2;
        int conta = 0;
        
        public Form1()
        {
            InitializeComponent();
            c1 = new Carrello("12345");
            //p1 = new Prodotto("EA Sports", "FC25", "54321", 69.99);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aggiunta_Click(object sender, EventArgs e)
        {
            bool uguale = false;
            if (textBox1.Text != "")
            {
                p1 = new Prodotto("EA Sports", "FC25", textBox1.Text, 69.99);
                if (c1.Prodotti.Count == 0)
                {
                    c1.aggiungiProdotto(p1);
                    conta++;
                    AggiornaInterfaccia();
                }
                else
                {
                    for (int i = 0; i < c1.Prodotti.Count; i++)
                    {
                        if (this.p1.Identificativo == c1.Prodotti[i].Identificativo)
                        {
                            uguale = true;                          
                        }
                        
                    }
                    if(uguale == false)
                    {
                        c1.aggiungiProdotto(p1);
                        conta++;
                        AggiornaInterfaccia();
                    }
                }
            }
        }

        private void Rimozione_Click(object sender, EventArgs e)
        {
            c1.rimuoviUltimo(conta-1);
            conta--;
            AggiornaInterfaccia();
        }

        private void AggiornaInterfaccia()
        {
            ListBoxCarrello.DataSource = null;
            ListBoxCarrello.DataSource = c1.Prodotti;
            ListBoxCarrello.DisplayMember = "Identificativo";
        }

        private void Svuota_Click(object sender, EventArgs e)
        {
            c1.svuotaCarrello();
            AggiornaInterfaccia();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
