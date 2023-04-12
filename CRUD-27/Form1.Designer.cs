namespace CRUD_27
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.rese = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.price2 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(32, 61);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(103, 20);
            this.Name.TabIndex = 0;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(225, 60);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 2;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezzo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(32, 132);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 5;
            this.Save.Text = "Salva";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(150, 132);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 6;
            this.delete.Text = "Cancella";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // rese
            // 
            this.rese.Location = new System.Drawing.Point(262, 132);
            this.rese.Name = "rese";
            this.rese.Size = new System.Drawing.Size(75, 23);
            this.rese.TabIndex = 7;
            this.rese.Text = "Ricerca";
            this.rese.UseVisualStyleBackColor = true;
            this.rese.Click += new System.EventHandler(this.rese_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(35, 192);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(75, 23);
            this.mod.TabIndex = 8;
            this.mod.Text = "Modifica";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // price2
            // 
            this.price2.Location = new System.Drawing.Point(150, 195);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(100, 20);
            this.price2.TabIndex = 10;
            this.price2.TextChanged += new System.EventHandler(this.price2_TextChanged);
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Location = new System.Drawing.Point(340, 179);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(60, 13);
            this.name2.TabIndex = 11;
            this.name2.Text = "New Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "New Prezzo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.rese);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button rese;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label label4;
    }
}

