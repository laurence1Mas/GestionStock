namespace Gestion_stock.usercontols
{
    partial class approvisionnemnt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgachat = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgfournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgproduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquantiteA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprixau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdateachat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdateAchat = new System.Windows.Forms.DateTimePicker();
            this.cmbproduit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquantiteAchat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbfournisseur = new System.Windows.Forms.ComboBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtprixAU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.btn_bon_entrer = new System.Windows.Forms.Button();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.btncheckdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgachat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrecherche
            // 
            this.txtrecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.Location = new System.Drawing.Point(126, 317);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(178, 30);
            this.txtrecherche.TabIndex = 24;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(33, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Reherche:";
            // 
            // dgachat
            // 
            this.dgachat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgachat.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgachat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgachat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgachat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgfournisseur,
            this.dgproduit,
            this.dgquantiteA,
            this.dgprixau,
            this.dgdateachat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgachat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgachat.Location = new System.Drawing.Point(32, 353);
            this.dgachat.Name = "dgachat";
            this.dgachat.Size = new System.Drawing.Size(998, 215);
            this.dgachat.TabIndex = 22;
            this.dgachat.DoubleClick += new System.EventHandler(this.dgachat_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "ID";
            this.dgcode.HeaderText = "code";
            this.dgcode.Name = "dgcode";
            // 
            // dgfournisseur
            // 
            this.dgfournisseur.DataPropertyName = "fournisseur_id1";
            this.dgfournisseur.HeaderText = "fournisseur";
            this.dgfournisseur.Name = "dgfournisseur";
            // 
            // dgproduit
            // 
            this.dgproduit.DataPropertyName = "Produit_id";
            this.dgproduit.HeaderText = "produit";
            this.dgproduit.Name = "dgproduit";
            // 
            // dgquantiteA
            // 
            this.dgquantiteA.DataPropertyName = "Quantite_achat";
            this.dgquantiteA.HeaderText = "quantite";
            this.dgquantiteA.Name = "dgquantiteA";
            // 
            // dgprixau
            // 
            this.dgprixau.DataPropertyName = "PAunitaires1";
            this.dgprixau.HeaderText = "prixu";
            this.dgprixau.Name = "dgprixau";
            // 
            // dgdateachat
            // 
            this.dgdateachat.DataPropertyName = "Date";
            this.dgdateachat.HeaderText = "date";
            this.dgdateachat.Name = "dgdateachat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsupprimer);
            this.groupBox2.Controls.Add(this.btnmodifier);
            this.groupBox2.Controls.Add(this.btnenregistrer);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(842, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 240);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.Red;
            this.btnsupprimer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsupprimer.ForeColor = System.Drawing.Color.White;
            this.btnsupprimer.Image = global::Gestion_stock.Properties.Resources.delete_trash_24px;
            this.btnsupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimer.Location = new System.Drawing.Point(23, 171);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(123, 38);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "   Suprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmodifier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnmodifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Image = global::Gestion_stock.Properties.Resources.update_24px;
            this.btnmodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifier.Location = new System.Drawing.Point(23, 107);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(123, 38);
            this.btnmodifier.TabIndex = 1;
            this.btnmodifier.Text = "   Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.DarkBlue;
            this.btnenregistrer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnenregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnenregistrer.ForeColor = System.Drawing.Color.White;
            this.btnenregistrer.Image = global::Gestion_stock.Properties.Resources.save_26px;
            this.btnenregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenregistrer.Location = new System.Drawing.Point(23, 48);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(123, 38);
            this.btnenregistrer.TabIndex = 0;
            this.btnenregistrer.Text = "      Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdateAchat);
            this.groupBox1.Controls.Add(this.cmbproduit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtquantiteAchat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbfournisseur);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.txtprixAU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(32, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 240);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Achat";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtdateAchat
            // 
            this.txtdateAchat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdateAchat.Location = new System.Drawing.Point(583, 79);
            this.txtdateAchat.MinDate = new System.DateTime(1755, 1, 1, 0, 0, 0, 0);
            this.txtdateAchat.Name = "txtdateAchat";
            this.txtdateAchat.Size = new System.Drawing.Size(205, 27);
            this.txtdateAchat.TabIndex = 19;
            // 
            // cmbproduit
            // 
            this.cmbproduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbproduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbproduit.FormattingEnabled = true;
            this.cmbproduit.Location = new System.Drawing.Point(314, 79);
            this.cmbproduit.Name = "cmbproduit";
            this.cmbproduit.Size = new System.Drawing.Size(222, 27);
            this.cmbproduit.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(310, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Produit";
            // 
            // txtquantiteAchat
            // 
            this.txtquantiteAchat.Location = new System.Drawing.Point(50, 171);
            this.txtquantiteAchat.Multiline = true;
            this.txtquantiteAchat.Name = "txtquantiteAchat";
            this.txtquantiteAchat.Size = new System.Drawing.Size(222, 34);
            this.txtquantiteAchat.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quantite Achat";
            // 
            // cmbfournisseur
            // 
            this.cmbfournisseur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbfournisseur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbfournisseur.FormattingEnabled = true;
            this.cmbfournisseur.Location = new System.Drawing.Point(50, 79);
            this.cmbfournisseur.Name = "cmbfournisseur";
            this.cmbfournisseur.Size = new System.Drawing.Size(222, 27);
            this.cmbfournisseur.TabIndex = 14;
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(728, 15);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(62, 34);
            this.txtcode.TabIndex = 13;
            this.txtcode.Visible = false;
            // 
            // txtprixAU
            // 
            this.txtprixAU.Location = new System.Drawing.Point(314, 171);
            this.txtprixAU.Multiline = true;
            this.txtprixAU.Name = "txtprixAU";
            this.txtprixAU.Size = new System.Drawing.Size(222, 34);
            this.txtprixAU.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "PrixA Unitaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Achat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fournisseur";
            // 
            // btnimprimer
            // 
            this.btnimprimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnimprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnimprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimer.ForeColor = System.Drawing.Color.Black;
            this.btnimprimer.Image = global::Gestion_stock.Properties.Resources.print_26px;
            this.btnimprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimer.Location = new System.Drawing.Point(907, 309);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(123, 38);
            this.btnimprimer.TabIndex = 23;
            this.btnimprimer.Text = "     Imprimer";
            this.btnimprimer.UseVisualStyleBackColor = true;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
            // 
            // btn_bon_entrer
            // 
            this.btn_bon_entrer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_bon_entrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_bon_entrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bon_entrer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bon_entrer.ForeColor = System.Drawing.Color.Black;
            this.btn_bon_entrer.Image = global::Gestion_stock.Properties.Resources.print_26px;
            this.btn_bon_entrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bon_entrer.Location = new System.Drawing.Point(778, 309);
            this.btn_bon_entrer.Name = "btn_bon_entrer";
            this.btn_bon_entrer.Size = new System.Drawing.Size(123, 38);
            this.btn_bon_entrer.TabIndex = 27;
            this.btn_bon_entrer.Text = " B.entrer";
            this.btn_bon_entrer.UseVisualStyleBackColor = true;
            this.btn_bon_entrer.Click += new System.EventHandler(this.btn_bon_entrer_Click);
            // 
            // dateDebut
            // 
            this.dateDebut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDebut.Location = new System.Drawing.Point(501, 324);
            this.dateDebut.MinDate = new System.DateTime(1755, 1, 1, 0, 0, 0, 0);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(105, 23);
            this.dateDebut.TabIndex = 28;
            // 
            // dateFin
            // 
            this.dateFin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFin.Location = new System.Drawing.Point(612, 324);
            this.dateFin.MinDate = new System.DateTime(1755, 1, 1, 0, 0, 0, 0);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(108, 23);
            this.dateFin.TabIndex = 29;
            // 
            // btncheckdate
            // 
            this.btncheckdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncheckdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btncheckdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheckdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckdate.ForeColor = System.Drawing.Color.Black;
            this.btncheckdate.Image = global::Gestion_stock.Properties.Resources.print_26px;
            this.btncheckdate.Location = new System.Drawing.Point(726, 309);
            this.btncheckdate.Name = "btncheckdate";
            this.btncheckdate.Size = new System.Drawing.Size(46, 38);
            this.btncheckdate.TabIndex = 30;
            this.btncheckdate.UseVisualStyleBackColor = true;
            this.btncheckdate.Click += new System.EventHandler(this.btncheckdate_Click);
            // 
            // approvisionnemnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btncheckdate);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.btn_bon_entrer);
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgachat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "approvisionnemnt";
            this.Size = new System.Drawing.Size(1066, 590);
            this.Load += new System.EventHandler(this.approvisionnemnt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgachat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgachat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbfournisseur;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtprixAU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquantiteAchat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbproduit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtdateAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquantiteA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprixau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdateachat;
        private System.Windows.Forms.Button btn_bon_entrer;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.Button btncheckdate;
    }
}
