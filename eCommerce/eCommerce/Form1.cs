namespace eCommerce
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Carrello carrello = new Carrello("12345");
            Prodotto prodotto = new Prodotto("EA Sports", "FC25", "54321", 69.99); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aggiunta_Click(object sender, EventArgs e)
        {
           
        }

        private void Rimozione_Click(object sender, EventArgs e)
        {

        }
    }
}
