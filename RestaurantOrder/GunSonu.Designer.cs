namespace Hamburger_Oop_07042022
{
    partial class GunSonu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.lblSiparisSayisi = new System.Windows.Forms.Label();
            this.lblExtraMalzeme = new System.Windows.Forms.Label();
            this.lblSatılanUrun = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüm Siparişler";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(29, 62);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(159, 303);
            this.lstSiparisler.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCiro);
            this.groupBox1.Location = new System.Drawing.Point(217, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CİRO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSiparisSayisi);
            this.groupBox2.Location = new System.Drawing.Point(217, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TOPLAM SİPARİŞ SAYISI";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblExtraMalzeme);
            this.groupBox3.Location = new System.Drawing.Point(217, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EXTRA MALZEME GELİRİ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSatılanUrun);
            this.groupBox4.Location = new System.Drawing.Point(217, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 72);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SATILAN ÜRÜN SAYISI";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(149, 20);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(0, 13);
            this.lblCiro.TabIndex = 0;
            // 
            // lblSiparisSayisi
            // 
            this.lblSiparisSayisi.AutoSize = true;
            this.lblSiparisSayisi.Location = new System.Drawing.Point(149, 16);
            this.lblSiparisSayisi.Name = "lblSiparisSayisi";
            this.lblSiparisSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblSiparisSayisi.TabIndex = 0;
            // 
            // lblExtraMalzeme
            // 
            this.lblExtraMalzeme.AutoSize = true;
            this.lblExtraMalzeme.Location = new System.Drawing.Point(149, 16);
            this.lblExtraMalzeme.Name = "lblExtraMalzeme";
            this.lblExtraMalzeme.Size = new System.Drawing.Size(0, 13);
            this.lblExtraMalzeme.TabIndex = 0;
            // 
            // lblSatılanUrun
            // 
            this.lblSatılanUrun.AutoSize = true;
            this.lblSatılanUrun.Location = new System.Drawing.Point(149, 16);
            this.lblSatılanUrun.Name = "lblSatılanUrun";
            this.lblSatılanUrun.Size = new System.Drawing.Size(0, 13);
            this.lblSatılanUrun.TabIndex = 0;
            // 
            // GunSonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(438, 381);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "GunSonu";
            this.Text = "GunSonu";
            this.Load += new System.EventHandler(this.GunSonu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSiparisSayisi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblExtraMalzeme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSatılanUrun;
    }
}