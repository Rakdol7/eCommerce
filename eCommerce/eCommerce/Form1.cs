using System.Text.Json;

namespace eCommerce
{
    public partial class Form1 : Form
    {
        private Carrello c1;
        private Prodotto p1;
        private Prodotto p2;
        private Prodotto p3;
        private Prodotto p4;
        private Prodotto p5;
        int conta = 0;
        int generatore = 0;

        public Form1()
        {
            InitializeComponent();
            c1 = new Carrello("12345");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aggiunta_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBox1.SelectedItem) == "FC25")
            {
                c1.aggiungiProdotto(p1 = new Prodotto("EA Sports", "FC25", Convert.ToString(generatore + 11111), 69.99));
                conta++;
                generatore++;
                AggiornaInterfaccia();
            }
            if (Convert.ToString(comboBox1.SelectedItem) == "The Legend of Zelda")
            {
                c1.aggiungiProdotto(p2 = new Prodotto("Nintendo", "The Legend of Zelda", Convert.ToString(generatore + 11111), 49.99));
                conta++;
                generatore++;
                AggiornaInterfaccia();
            }
            if (Convert.ToString(comboBox1.SelectedItem) == "Doom")
            {
                c1.aggiungiProdotto(p3 = new Prodotto("Bethesda", "Doom", Convert.ToString(generatore + 11111), 19.99));
                conta++;
                generatore++;
                AggiornaInterfaccia();
            }
            if (Convert.ToString(comboBox1.SelectedItem) == "WWE2K25")
            {
                c1.aggiungiProdotto(p4 = new Prodotto("2K", "WWE2K25", Convert.ToString(generatore + 11111), 59.99));
                conta++;
                generatore++;
                AggiornaInterfaccia();
            }
            if (Convert.ToString(comboBox1.SelectedItem) == "Assassin's Creed")
            {
                c1.aggiungiProdotto(p5 = new Prodotto("Ubisoft", "Assassin's Creed", Convert.ToString(generatore + 11111), 39.99));
                conta++;
                generatore++;
                AggiornaInterfaccia();
            }
            //p1 = new Prodotto(textBox2.Text , textBox1.Text , Convert.ToString(conta + 11111), 69.99);
            /*c1.aggiungiProdotto(p1);
            conta++;
            AggiornaInterfaccia();*/
            /*
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
            }*/
        }

        private void Rimozione_Click(object sender, EventArgs e)
        {
            c1.rimuoviUltimo(conta - 1);
            conta--;
            AggiornaInterfaccia();
        }

        private void AggiornaInterfaccia()
        {
            ListBoxCarrello.DataSource = null;
            ListBoxCarrello.DataSource = c1.Prodotti;
            ListBoxCarrello.DisplayMember = "Modello";
        }

        private void Svuota_Click(object sender, EventArgs e)
        {
            c1.svuotaCarrello();
            AggiornaInterfaccia();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Catalogo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Salva_Click(object sender, EventArgs e)
        {
            string file = "ListBoxCarrello.json";
            string json = JsonSerializer.Serialize(c1.Prodotti);
            File.WriteAllText(file, json);
            MessageBox.Show("Carrello salvato");
        }
    }
}
