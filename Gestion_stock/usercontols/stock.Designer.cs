namespace Gestion_stock.usercontols
{
    partial class stock
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
            this.dgstock = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgfournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprixu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtypeoperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdateoperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgstock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrecherche
            // 
            this.txtrecherche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.Location = new System.Drawing.Point(153, 38);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(243, 41);
            this.txtrecherche.TabIndex = 30;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(60, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Reherche:";
            // 
            // dgstock
            // 
            this.dgstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgstock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgstock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgfournisseur,
            this.dgquantite,
            this.dgprixu,
            this.dgtypeoperation,
            this.dgdateoperation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgstock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgstock.Location = new System.Drawing.Point(32, 85);
            this.dgstock.Name = "dgstock";
            this.dgstock.Size = new System.Drawing.Size(1003, 477);
            this.dgstock.TabIndex = 28;
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "ID";
            this.dgcode.HeaderText = "code";
            this.dgcode.Name = "dgcode";
            // 
            // dgfournisseur
            // 
            this.dgfournisseur.DataPropertyName = "Produit_id";
            this.dgfournisseur.HeaderText = "produit";
            this.dgfournisseur.Name = "dgfournisseur";
            // 
            // dgquantite
            // 
            this.dgquantite.DataPropertyName = "Quantite";
            this.dgquantite.HeaderText = "quantite";
            this.dgquantite.Name = "dgquantite";
            // 
            // dgprixu
            // 
            this.dgprixu.DataPropertyName = "pu";
            this.dgprixu.HeaderText = "Prixu";
            this.dgprixu.Name = "dgprixu";
            // 
            // dgtypeoperation
            // 
            this.dgtypeoperation.DataPropertyName = "Type_operation";
            this.dgtypeoperation.HeaderText = "type-operation";
            this.dgtypeoperation.Name = "dgtypeoperation";
            // 
            // dgdateoperation
            // 
            this.dgdateoperation.DataPropertyName = "Date";
            this.dgdateoperation.HeaderText = "dat-operation";
            this.dgdateoperation.Name = "dgdateoperation";
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
            this.btnimprimer.Location = new System.Drawing.Point(874, 38);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(123, 38);
            this.btnimprimer.TabIndex = 29;
            this.btnimprimer.Text = "     Imprimer";
            this.btnimprimer.UseVisualStyleBackColor = true;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Gestion_stock.Properties.Resources.print_26px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(745, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 38);
            this.button1.TabIndex = 32;
            this.button1.Text = "fiche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgstock);
            this.Name = "stock";
            this.Size = new System.Drawing.Size(1066, 590);
            this.Load += new System.EventHandler(this.stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgstock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprixu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtypeoperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdateoperation;
    }
}
