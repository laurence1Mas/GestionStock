﻿namespace Gestion_stock.usercontols
{
    partial class vente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgventes = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgproduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdatevente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtdatevente = new System.Windows.Forms.DateTimePicker();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbproduitref = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbrefclient = new System.Windows.Forms.ComboBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtquantitevente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.btncheckdate = new System.Windows.Forms.Button();
            this.btn_bon_sortie = new System.Windows.Forms.Button();
            this.btnfacture = new System.Windows.Forms.Button();
            this.btnimprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgventes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrecherche
            // 
            this.txtrecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.Location = new System.Drawing.Point(124, 311);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(195, 30);
            this.txtrecherche.TabIndex = 36;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(31, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Reherche:";
            // 
            // dgventes
            // 
            this.dgventes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgventes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgventes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgventes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgventes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgclient,
            this.dgproduit,
            this.dgquantite,
            this.dgprix,
            this.dgdatevente});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgventes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgventes.Location = new System.Drawing.Point(32, 347);
            this.dgventes.Name = "dgventes";
            this.dgventes.Size = new System.Drawing.Size(1003, 215);
            this.dgventes.TabIndex = 34;
            this.dgventes.DoubleClick += new System.EventHandler(this.dgventes_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "ID";
            this.dgcode.HeaderText = "code";
            this.dgcode.Name = "dgcode";
            // 
            // dgclient
            // 
            this.dgclient.DataPropertyName = "Client_id";
            this.dgclient.HeaderText = "client";
            this.dgclient.Name = "dgclient";
            // 
            // dgproduit
            // 
            this.dgproduit.DataPropertyName = "Produit_id";
            this.dgproduit.HeaderText = "produit";
            this.dgproduit.Name = "dgproduit";
            // 
            // dgquantite
            // 
            this.dgquantite.DataPropertyName = "Quantite";
            this.dgquantite.HeaderText = "quantite";
            this.dgquantite.Name = "dgquantite";
            // 
            // dgprix
            // 
            this.dgprix.DataPropertyName = "PVunitaires1";
            this.dgprix.HeaderText = "prix";
            this.dgprix.Name = "dgprix";
            // 
            // dgdatevente
            // 
            this.dgdatevente.DataPropertyName = "Date";
            this.dgdatevente.HeaderText = "date-vente";
            this.dgdatevente.Name = "dgdatevente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsupprimer);
            this.groupBox2.Controls.Add(this.btnmodifier);
            this.groupBox2.Controls.Add(this.btnenregistrer);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(865, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 257);
            this.groupBox2.TabIndex = 33;
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
            this.btnsupprimer.Location = new System.Drawing.Point(27, 166);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(123, 38);
            this.btnsupprimer.TabIndex = 5;
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
            this.btnmodifier.Location = new System.Drawing.Point(27, 97);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(123, 38);
            this.btnmodifier.TabIndex = 4;
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
            this.btnenregistrer.Location = new System.Drawing.Point(27, 38);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(123, 38);
            this.btnenregistrer.TabIndex = 3;
            this.btnenregistrer.Text = "      Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtdatevente);
            this.groupBox1.Controls.Add(this.txtprix);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbproduitref);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbrefclient);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.txtquantitevente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(32, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 257);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Vente";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Gestion_stock.Properties.Resources.plus_26px;
            this.button1.Location = new System.Drawing.Point(280, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 31);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdatevente
            // 
            this.txtdatevente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdatevente.Location = new System.Drawing.Point(614, 81);
            this.txtdatevente.Name = "txtdatevente";
            this.txtdatevente.Size = new System.Drawing.Size(200, 27);
            this.txtdatevente.TabIndex = 23;
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(341, 173);
            this.txtprix.Multiline = true;
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(240, 34);
            this.txtprix.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Prix";
            // 
            // cmbproduitref
            // 
            this.cmbproduitref.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbproduitref.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbproduitref.FormattingEnabled = true;
            this.cmbproduitref.Location = new System.Drawing.Point(341, 81);
            this.cmbproduitref.Name = "cmbproduitref";
            this.cmbproduitref.Size = new System.Drawing.Size(240, 27);
            this.cmbproduitref.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Produit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date Operation";
            // 
            // cmbrefclient
            // 
            this.cmbrefclient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbrefclient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbrefclient.FormattingEnabled = true;
            this.cmbrefclient.Location = new System.Drawing.Point(47, 79);
            this.cmbrefclient.Name = "cmbrefclient";
            this.cmbrefclient.Size = new System.Drawing.Size(227, 27);
            this.cmbrefclient.TabIndex = 14;
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(752, 16);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(62, 34);
            this.txtcode.TabIndex = 13;
            this.txtcode.Visible = false;
            // 
            // txtquantitevente
            // 
            this.txtquantitevente.Location = new System.Drawing.Point(47, 173);
            this.txtquantitevente.Multiline = true;
            this.txtquantitevente.Name = "txtquantitevente";
            this.txtquantitevente.Size = new System.Drawing.Size(227, 34);
            this.txtquantitevente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // dateFin
            // 
            this.dateFin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFin.Location = new System.Drawing.Point(437, 318);
            this.dateFin.MinDate = new System.DateTime(1755, 1, 1, 0, 0, 0, 0);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(108, 23);
            this.dateFin.TabIndex = 43;
            // 
            // dateDebut
            // 
            this.dateDebut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDebut.Location = new System.Drawing.Point(326, 318);
            this.dateDebut.MinDate = new System.DateTime(1755, 1, 1, 0, 0, 0, 0);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(105, 23);
            this.dateDebut.TabIndex = 42;
            // 
            // btncheckdate
            // 
            this.btncheckdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncheckdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btncheckdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheckdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckdate.ForeColor = System.Drawing.Color.Black;
            this.btncheckdate.Image = global::Gestion_stock.Properties.Resources.print_26px;
            this.btncheckdate.Location = new System.Drawing.Point(540, 303);
            this.btncheckdate.Name = "btncheckdate";
            this.btncheckdate.Size = new System.Drawing.Size(46, 38);
            this.btncheckdate.TabIndex = 44;
            this.btncheckdate.UseVisualStyleBackColor = true;
            this.btncheckdate.Click += new System.EventHandler(this.btncheckdate_Click);
            // 
            // btn_bon_sortie
            // 
            this.btn_bon_sortie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_bon_sortie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_bon_sortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bon_sortie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bon_sortie.ForeColor = System.Drawing.Color.Black;
            this.btn_bon_sortie.Image = global::Gestion_stock.Properties.Resources.print_26px;
            this.btn_bon_sortie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bon_sortie.Location = new System.Drawing.Point(802, 303);
            this.btn_bon_sortie.Name = "btn_bon_sortie";
            this.btn_bon_sortie.Size = new System.Drawing.Size(104, 38);
            this.btn_bon_sortie.TabIndex = 41;
            this.btn_bon_sortie.Text = " B.sortie";
            this.btn_bon_sortie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bon_sortie.UseVisualStyleBackColor = true;
            this.btn_bon_sortie.Click += new System.EventHandler(this.btn_bon_sortie_Click);
            // 
            // btnfacture
            // 
            this.btnfacture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnfacture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnfacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacture.ForeColor = System.Drawing.Color.Black;
            this.btnfacture.Image = global::Gestion_stock.Properties.Resources.print_26px;
            this.btnfacture.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnfacture.Location = new System.Drawing.Point(696, 303);
            this.btnfacture.Name = "btnfacture";
            this.btnfacture.Size = new System.Drawing.Size(100, 38);
            this.btnfacture.TabIndex = 39;
            this.btnfacture.Text = "facture";
            this.btnfacture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfacture.UseVisualStyleBackColor = true;
            this.btnfacture.Click += new System.EventHandler(this.btnfacture_Click);
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
            this.btnimprimer.Location = new System.Drawing.Point(912, 303);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(123, 38);
            this.btnimprimer.TabIndex = 35;
            this.btnimprimer.Text = "     Imprimer";
            this.btnimprimer.UseVisualStyleBackColor = true;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
            // 
            // vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btncheckdate);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.btn_bon_sortie);
            this.Controls.Add(this.btnfacture);
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgventes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "vente";
            this.Size = new System.Drawing.Size(1066, 590);
            this.Load += new System.EventHandler(this.vente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgventes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgventes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbrefclient;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtquantitevente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbproduitref;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprix;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdatevente;
        private System.Windows.Forms.DateTimePicker txtdatevente;
        private System.Windows.Forms.Button btnfacture;
        private System.Windows.Forms.Button btn_bon_sortie;
        private System.Windows.Forms.Button btncheckdate;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.Button button1;
    }
}
