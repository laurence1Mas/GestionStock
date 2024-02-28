namespace Gestion_stock.usercontols
{
    partial class client
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgclient = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgclient)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.txtmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtadresse);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(35, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement client";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(728, 16);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(72, 34);
            this.txtcode.TabIndex = 12;
            this.txtcode.Visible = false;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(457, 160);
            this.txtmail.Multiline = true;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(267, 34);
            this.txtmail.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mail";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(103, 164);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(272, 34);
            this.txtnumero.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero";
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(457, 78);
            this.txtadresse.Multiline = true;
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(267, 34);
            this.txtadresse.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adresse";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(103, 73);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(272, 39);
            this.txtnom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // dgclient
            // 
            this.dgclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgclient.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgnom,
            this.dgadresse,
            this.dgnumero,
            this.dgmail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgclient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgclient.Location = new System.Drawing.Point(35, 348);
            this.dgclient.Name = "dgclient";
            this.dgclient.Size = new System.Drawing.Size(998, 215);
            this.dgclient.TabIndex = 1;
            this.dgclient.DoubleClick += new System.EventHandler(this.dgclient_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "codeclient";
            this.dgcode.HeaderText = "codeClient";
            this.dgcode.Name = "dgcode";
            // 
            // dgnom
            // 
            this.dgnom.DataPropertyName = "nom";
            this.dgnom.HeaderText = "nom";
            this.dgnom.Name = "dgnom";
            // 
            // dgadresse
            // 
            this.dgadresse.DataPropertyName = "Adresse";
            this.dgadresse.HeaderText = "Adresse";
            this.dgadresse.Name = "dgadresse";
            // 
            // dgnumero
            // 
            this.dgnumero.DataPropertyName = "numero";
            this.dgnumero.HeaderText = "numero";
            this.dgnumero.Name = "dgnumero";
            // 
            // dgmail
            // 
            this.dgmail.DataPropertyName = "mail";
            this.dgmail.HeaderText = "mail";
            this.dgmail.Name = "dgmail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsupprimer);
            this.groupBox2.Controls.Add(this.btnmodifier);
            this.groupBox2.Controls.Add(this.btnenregistrer);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(847, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 228);
            this.groupBox2.TabIndex = 2;
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
            this.btnsupprimer.Location = new System.Drawing.Point(23, 160);
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
            this.btnmodifier.Location = new System.Drawing.Point(23, 91);
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
            this.btnenregistrer.Location = new System.Drawing.Point(23, 32);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(123, 38);
            this.btnenregistrer.TabIndex = 0;
            this.btnenregistrer.Text = "      Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(45, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Reherche:";
            // 
            // txtrecherche
            // 
            this.txtrecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.Location = new System.Drawing.Point(138, 304);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(232, 41);
            this.txtrecherche.TabIndex = 12;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
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
            this.btnimprimer.Location = new System.Drawing.Point(870, 304);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(123, 38);
            this.btnimprimer.TabIndex = 3;
            this.btnimprimer.Text = "     Imprimer";
            this.btnimprimer.UseVisualStyleBackColor = true;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Gestion_stock.Properties.Resources.update;
            this.pictureBox1.Location = new System.Drawing.Point(947, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgclient);
            this.Controls.Add(this.groupBox1);
            this.Name = "client";
            this.Size = new System.Drawing.Size(1066, 590);
            this.Load += new System.EventHandler(this.client_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgclient)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgclient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
