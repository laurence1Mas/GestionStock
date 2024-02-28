namespace Gestion_stock
{
    partial class home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVente = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnFournisseur = new System.Windows.Forms.Button();
            this.btnApprov = new System.Windows.Forms.Button();
            this.btnproduit = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnVente);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnFournisseur);
            this.panel1.Controls.Add(this.btnApprov);
            this.panel1.Controls.Add(this.btnproduit);
            this.panel1.Controls.Add(this.btnclient);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 663);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Gestion_stock.Properties.Resources.NAR2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Location = new System.Drawing.Point(3, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 43);
            this.panel3.TabIndex = 16;
            // 
            // btnVente
            // 
            this.btnVente.BackColor = System.Drawing.Color.DarkBlue;
            this.btnVente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVente.FlatAppearance.BorderSize = 0;
            this.btnVente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVente.ForeColor = System.Drawing.Color.White;
            this.btnVente.Image = global::Gestion_stock.Properties.Resources.buy_30px;
            this.btnVente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVente.Location = new System.Drawing.Point(29, 513);
            this.btnVente.Name = "btnVente";
            this.btnVente.Size = new System.Drawing.Size(148, 41);
            this.btnVente.TabIndex = 15;
            this.btnVente.Text = "Vente";
            this.btnVente.UseVisualStyleBackColor = false;
            this.btnVente.Click += new System.EventHandler(this.btnVente_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.DarkBlue;
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = global::Gestion_stock.Properties.Resources.livestock_24px;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(29, 450);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(148, 41);
            this.btnStock.TabIndex = 14;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnFournisseur
            // 
            this.btnFournisseur.BackColor = System.Drawing.Color.DarkBlue;
            this.btnFournisseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFournisseur.FlatAppearance.BorderSize = 0;
            this.btnFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFournisseur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFournisseur.ForeColor = System.Drawing.Color.White;
            this.btnFournisseur.Image = global::Gestion_stock.Properties.Resources.customer_30px1;
            this.btnFournisseur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFournisseur.Location = new System.Drawing.Point(29, 388);
            this.btnFournisseur.Name = "btnFournisseur";
            this.btnFournisseur.Size = new System.Drawing.Size(148, 41);
            this.btnFournisseur.TabIndex = 13;
            this.btnFournisseur.Text = "   Fournisseur";
            this.btnFournisseur.UseVisualStyleBackColor = false;
            this.btnFournisseur.Click += new System.EventHandler(this.btnFournisseur_Click);
            // 
            // btnApprov
            // 
            this.btnApprov.BackColor = System.Drawing.Color.DarkBlue;
            this.btnApprov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprov.FlatAppearance.BorderSize = 0;
            this.btnApprov.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApprov.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprov.ForeColor = System.Drawing.Color.White;
            this.btnApprov.Image = global::Gestion_stock.Properties.Resources.basket_30px;
            this.btnApprov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprov.Location = new System.Drawing.Point(29, 328);
            this.btnApprov.Name = "btnApprov";
            this.btnApprov.Size = new System.Drawing.Size(148, 41);
            this.btnApprov.TabIndex = 12;
            this.btnApprov.Text = "    Approvision";
            this.btnApprov.UseVisualStyleBackColor = false;
            this.btnApprov.Click += new System.EventHandler(this.btnApprov_Click);
            // 
            // btnproduit
            // 
            this.btnproduit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnproduit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproduit.FlatAppearance.BorderSize = 0;
            this.btnproduit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnproduit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduit.ForeColor = System.Drawing.Color.White;
            this.btnproduit.Image = global::Gestion_stock.Properties.Resources.tags_30px;
            this.btnproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduit.Location = new System.Drawing.Point(29, 268);
            this.btnproduit.Name = "btnproduit";
            this.btnproduit.Size = new System.Drawing.Size(146, 41);
            this.btnproduit.TabIndex = 10;
            this.btnproduit.Text = "Produit";
            this.btnproduit.UseVisualStyleBackColor = false;
            this.btnproduit.Click += new System.EventHandler(this.btnproduit_Click);
            // 
            // btnclient
            // 
            this.btnclient.BackColor = System.Drawing.Color.DarkBlue;
            this.btnclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.ForeColor = System.Drawing.Color.White;
            this.btnclient.Image = global::Gestion_stock.Properties.Resources.customer_30px;
            this.btnclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclient.Location = new System.Drawing.Point(31, 205);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(146, 41);
            this.btnclient.TabIndex = 2;
            this.btnclient.Text = "Client";
            this.btnclient.UseVisualStyleBackColor = false;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(206, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 497);
            this.panel2.TabIndex = 1;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.White;
            this.container.Location = new System.Drawing.Point(209, 44);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1066, 590);
            this.container.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1087, 34);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Gestion_stock.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(1038, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(365, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NARADA SARL GOMA RDC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(468, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "copy-right 2023 designed by laurence mak tel: +243976729986";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1287, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NARADA-APP";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button btnproduit;
        private System.Windows.Forms.Button btnApprov;
        private System.Windows.Forms.Button btnFournisseur;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnVente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

