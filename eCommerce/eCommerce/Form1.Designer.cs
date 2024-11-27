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
            SuspendLayout();
            // 
            // Rimozione
            // 
            Rimozione.BackColor = Color.Red;
            Rimozione.Location = new Point(153, 255);
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
            Aggiunta.Location = new Point(153, 135);
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
            ListBoxCarrello.Location = new Point(428, 164);
            ListBoxCarrello.Name = "ListBoxCarrello";
            ListBoxCarrello.Size = new Size(181, 139);
            ListBoxCarrello.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(428, 116);
            label1.Name = "label1";
            label1.Size = new Size(184, 45);
            label1.TabIndex = 4;
            label1.Text = "CARRELLO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
