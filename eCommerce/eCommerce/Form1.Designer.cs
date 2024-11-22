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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            Rimozione = new Button();
            Aggiunta = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(409, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 203);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Aggiunta);
            Controls.Add(Rimozione);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Rimozione;
        private Button Aggiunta;
    }
}
