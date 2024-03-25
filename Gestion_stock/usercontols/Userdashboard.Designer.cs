namespace Gestion_stock.usercontols
{
    partial class Userdashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblclient = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblfournisseur = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblproduit = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblvente = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.graphiqueAchat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphiqueVente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphiqueAchat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphiqueVente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(51, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 117);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clients";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblclient);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(17, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 82);
            this.panel3.TabIndex = 0;
            // 
            // lblclient
            // 
            this.lblclient.AutoSize = true;
            this.lblclient.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclient.Location = new System.Drawing.Point(15, 27);
            this.lblclient.Name = "lblclient";
            this.lblclient.Size = new System.Drawing.Size(68, 24);
            this.lblclient.TabIndex = 1;
            this.lblclient.Text = "label5";
            this.lblclient.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_stock.Properties.Resources.adherants;
            this.pictureBox1.Location = new System.Drawing.Point(102, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(302, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 117);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fournisseurs";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblfournisseur);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(17, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 82);
            this.panel5.TabIndex = 0;
            // 
            // lblfournisseur
            // 
            this.lblfournisseur.AutoSize = true;
            this.lblfournisseur.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfournisseur.Location = new System.Drawing.Point(13, 27);
            this.lblfournisseur.Name = "lblfournisseur";
            this.lblfournisseur.Size = new System.Drawing.Size(68, 24);
            this.lblfournisseur.TabIndex = 2;
            this.lblfournisseur.Text = "label6";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestion_stock.Properties.Resources.people;
            this.pictureBox2.Location = new System.Drawing.Point(101, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(555, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 117);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Produits";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblproduit);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Location = new System.Drawing.Point(17, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(173, 82);
            this.panel6.TabIndex = 0;
            // 
            // lblproduit
            // 
            this.lblproduit.AutoSize = true;
            this.lblproduit.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduit.Location = new System.Drawing.Point(13, 27);
            this.lblproduit.Name = "lblproduit";
            this.lblproduit.Size = new System.Drawing.Size(68, 24);
            this.lblproduit.TabIndex = 2;
            this.lblproduit.Text = "label7";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gestion_stock.Properties.Resources.people;
            this.pictureBox3.Location = new System.Drawing.Point(100, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Navy;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(805, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(210, 117);
            this.panel7.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ventes";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.lblvente);
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Location = new System.Drawing.Point(17, 32);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(175, 82);
            this.panel8.TabIndex = 0;
            // 
            // lblvente
            // 
            this.lblvente.AutoSize = true;
            this.lblvente.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvente.Location = new System.Drawing.Point(12, 27);
            this.lblvente.Name = "lblvente";
            this.lblvente.Size = new System.Drawing.Size(68, 24);
            this.lblvente.TabIndex = 2;
            this.lblvente.Text = "label8";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Gestion_stock.Properties.Resources.icone_panier;
            this.pictureBox4.Location = new System.Drawing.Point(102, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // graphiqueAchat
            // 
            this.graphiqueAchat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.graphiqueAchat.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.graphiqueAchat.BorderlineColor = System.Drawing.Color.RoyalBlue;
            chartArea1.Name = "ChartArea1";
            this.graphiqueAchat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graphiqueAchat.Legends.Add(legend1);
            this.graphiqueAchat.Location = new System.Drawing.Point(51, 318);
            this.graphiqueAchat.Name = "graphiqueAchat";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graphiqueAchat.Series.Add(series1);
            this.graphiqueAchat.Size = new System.Drawing.Size(469, 254);
            this.graphiqueAchat.TabIndex = 7;
            this.graphiqueAchat.Text = "Achats";
            // 
            // graphiqueVente
            // 
            this.graphiqueVente.BackColor = System.Drawing.Color.LightSteelBlue;
            this.graphiqueVente.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.graphiqueVente.BorderlineColor = System.Drawing.Color.DodgerBlue;
            chartArea2.Name = "ChartArea1";
            this.graphiqueVente.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graphiqueVente.Legends.Add(legend2);
            this.graphiqueVente.Location = new System.Drawing.Point(595, 318);
            this.graphiqueVente.Name = "graphiqueVente";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graphiqueVente.Series.Add(series2);
            this.graphiqueVente.Size = new System.Drawing.Size(420, 254);
            this.graphiqueVente.TabIndex = 8;
            this.graphiqueVente.Text = "Ventes";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(51, 173);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(300, 139);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Userdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.graphiqueVente);
            this.Controls.Add(this.graphiqueAchat);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Userdashboard";
            this.Size = new System.Drawing.Size(1066, 590);
            this.Load += new System.EventHandler(this.Userdashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphiqueAchat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphiqueVente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblclient;
        private System.Windows.Forms.Label lblfournisseur;
        private System.Windows.Forms.Label lblproduit;
        private System.Windows.Forms.Label lblvente;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphiqueAchat;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphiqueVente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
