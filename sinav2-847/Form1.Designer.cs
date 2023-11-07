namespace sinav2_847
{
    partial class Form1
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
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.lblTaksitSayisi = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.tbTaksitSayi = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksitSayi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(54, 67);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(46, 24);
            this.lblAdet.TabIndex = 0;
            this.lblAdet.Text = "adet";
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimFiyat.Location = new System.Drawing.Point(54, 106);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(87, 24);
            this.lblBirimFiyat.TabIndex = 1;
            this.lblBirimFiyat.Text = "birim fiyat";
            // 
            // lblTaksitSayisi
            // 
            this.lblTaksitSayisi.AutoSize = true;
            this.lblTaksitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksitSayisi.Location = new System.Drawing.Point(54, 152);
            this.lblTaksitSayisi.Name = "lblTaksitSayisi";
            this.lblTaksitSayisi.Size = new System.Drawing.Size(100, 24);
            this.lblTaksitSayisi.TabIndex = 2;
            this.lblTaksitSayisi.Text = "taksit sayısı";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(54, 200);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(94, 24);
            this.lblTutar.TabIndex = 3;
            this.lblTutar.Text = "taksit tutarı";
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(204, 67);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(154, 29);
            this.txtAdet.TabIndex = 4;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyat.Location = new System.Drawing.Point(204, 106);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(154, 29);
            this.txtBirimFiyat.TabIndex = 5;
            // 
            // tbTaksitSayi
            // 
            this.tbTaksitSayi.Location = new System.Drawing.Point(204, 152);
            this.tbTaksitSayi.Name = "tbTaksitSayi";
            this.tbTaksitSayi.Size = new System.Drawing.Size(154, 45);
            this.tbTaksitSayi.TabIndex = 6;
            this.tbTaksitSayi.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTaksitSayi);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblTaksitSayisi);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.lblAdet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksitSayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.Label lblTaksitSayisi;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TrackBar tbTaksitSayi;
    }
}

