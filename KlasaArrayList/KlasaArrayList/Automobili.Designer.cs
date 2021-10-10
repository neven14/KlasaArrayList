
namespace KlasaArrayList
{
    partial class Automobili
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNovi = new System.Windows.Forms.Button();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.textBoxNovi = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(107, 57);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(125, 38);
            this.buttonNovi.TabIndex = 0;
            this.buttonNovi.Text = "Novi automobil";
            this.buttonNovi.UseVisualStyleBackColor = true;
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(380, 101);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(125, 38);
            this.buttonUnesi.TabIndex = 1;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(550, 182);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(125, 38);
            this.buttonObrisi.TabIndex = 2;
            this.buttonObrisi.Text = "Obrisi listu";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            // 
            // textBoxNovi
            // 
            this.textBoxNovi.Enabled = false;
            this.textBoxNovi.Location = new System.Drawing.Point(107, 117);
            this.textBoxNovi.Name = "textBoxNovi";
            this.textBoxNovi.Size = new System.Drawing.Size(187, 22);
            this.textBoxNovi.TabIndex = 3;
            this.textBoxNovi.TextChanged += new System.EventHandler(this.textBoxNovi_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(107, 182);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(398, 236);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Automobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxNovi);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.buttonNovi);
            this.Name = "Automobili";
            this.Text = "Automobili";
            this.Load += new System.EventHandler(this.Automobili_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovi;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.TextBox textBoxNovi;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

