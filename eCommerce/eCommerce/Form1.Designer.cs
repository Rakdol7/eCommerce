namespace eCommerce
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Rimozione = new Button();
            Aggiunta = new Button();
            ListBoxCarrello = new ListBox();
            label1 = new Label();
            Svuota = new Button();
            comboBox1 = new ComboBox();
            Salva = new Button();
            SuspendLayout();
            // 
            // Rimozione
            // 
            Rimozione.BackColor = Color.Red;
            Rimozione.Location = new Point(312, 181);
            Rimozione.Name = "Rimozione";
            Rimozione.Size = new Size(120, 83);
            Rimozione.TabIndex = 1;
            Rimozione.Text = "RIMUOVI";
            Rimozione.UseVisualStyleBackColor = false;
            Rimozione.Click += Rimozione_Click;
            // 
            // Aggiunta
            // 
            Aggiunta.BackColor = Color.LimeGreen;
            Aggiunta.Location = new Point(186, 181);
            Aggiunta.Name = "Aggiunta";
            Aggiunta.Size = new Size(120, 83);
            Aggiunta.TabIndex = 2;
            Aggiunta.Text = "AGGIUNGI";
            Aggiunta.UseVisualStyleBackColor = false;
            Aggiunta.Click += Aggiunta_Click;
            // 
            // ListBoxCarrello
            // 
            ListBoxCarrello.FormattingEnabled = true;
            ListBoxCarrello.ItemHeight = 15;
            ListBoxCarrello.Location = new Point(557, 177);
            ListBoxCarrello.Name = "ListBoxCarrello";
            ListBoxCarrello.Size = new Size(181, 139);
            ListBoxCarrello.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(554, 129);
            label1.Name = "label1";
            label1.Size = new Size(184, 45);
            label1.TabIndex = 4;
            label1.Text = "CARRELLO";
            // 
            // Svuota
            // 
            Svuota.BackColor = Color.Black;
            Svuota.ForeColor = Color.White;
            Svuota.Location = new Point(251, 270);
            Svuota.Name = "Svuota";
            Svuota.Size = new Size(114, 83);
            Svuota.TabIndex = 5;
            Svuota.Text = "SVUOTA";
            Svuota.UseVisualStyleBackColor = false;
            Svuota.Click += Svuota_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "FC25", "The Legend of Zelda", "Doom", "WWE2K25", "Assassin's Creed" });
            comboBox1.Location = new Point(241, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 23);
            comboBox1.TabIndex = 6;
            // 
            // Salva
            // 
            Salva.BackColor = Color.Turquoise;
            Salva.ForeColor = Color.Black;
            Salva.Location = new Point(595, 338);
            Salva.Name = "Salva";
            Salva.Size = new Size(97, 46);
            Salva.TabIndex = 7;
            Salva.Text = "SALVA";
            Salva.UseVisualStyleBackColor = false;
            Salva.Click += Salva_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Salva);
            Controls.Add(comboBox1);
            Controls.Add(Svuota);
            Controls.Add(label1);
            Controls.Add(ListBoxCarrello);
            Controls.Add(Aggiunta);
            Controls.Add(Rimozione);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Rimozione;
        private Button Aggiunta;
        private ListBox ListBoxCarrello;
        private Label label1;
        private Button Svuota;
        private ComboBox comboBox1;
        private Button Salva;
    }
}
