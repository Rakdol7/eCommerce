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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Rimozione
            // 
            Rimozione.BackColor = Color.Red;
            Rimozione.Location = new Point(567, 317);
            Rimozione.Name = "Rimozione";
            Rimozione.Size = new Size(114, 83);
            Rimozione.TabIndex = 1;
            Rimozione.Text = "RIMUOVI";
            Rimozione.UseVisualStyleBackColor = false;
            Rimozione.Click += Rimozione_Click;
            // 
            // Aggiunta
            // 
            Aggiunta.BackColor = Color.LimeGreen;
            Aggiunta.Location = new Point(205, 167);
            Aggiunta.Name = "Aggiunta";
            Aggiunta.Size = new Size(114, 83);
            Aggiunta.TabIndex = 2;
            Aggiunta.Text = "AGGIUNGI";
            Aggiunta.UseVisualStyleBackColor = false;
            Aggiunta.Click += Aggiunta_Click;
            // 
            // ListBoxCarrello
            // 
            ListBoxCarrello.FormattingEnabled = true;
            ListBoxCarrello.ItemHeight = 15;
            ListBoxCarrello.Location = new Point(479, 172);
            ListBoxCarrello.Name = "ListBoxCarrello";
            ListBoxCarrello.Size = new Size(181, 139);
            ListBoxCarrello.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(476, 124);
            label1.Name = "label1";
            label1.Size = new Size(184, 45);
            label1.TabIndex = 4;
            label1.Text = "CARRELLO";
            // 
            // Svuota
            // 
            Svuota.BackColor = Color.Black;
            Svuota.ForeColor = Color.White;
            Svuota.Location = new Point(447, 317);
            Svuota.Name = "Svuota";
            Svuota.Size = new Size(114, 83);
            Svuota.TabIndex = 5;
            Svuota.Text = "SVUOTA";
            Svuota.UseVisualStyleBackColor = false;
            Svuota.Click += Svuota_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 201);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 8;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 154);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 9;
            label3.Text = "Modello:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
    }
}
