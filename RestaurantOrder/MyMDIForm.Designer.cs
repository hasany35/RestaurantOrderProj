namespace Hamburger_Oop_07042022
{
    partial class MyMDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sİPARİŞBİLGİLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günSonuRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bİLGİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menüBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİPARİŞBİLGİLERİToolStripMenuItem,
            this.bİLGİLERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sİPARİŞBİLGİLERİToolStripMenuItem
            // 
            this.sİPARİŞBİLGİLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişOluşturToolStripMenuItem,
            this.günSonuRaporuToolStripMenuItem});
            this.sİPARİŞBİLGİLERİToolStripMenuItem.Name = "sİPARİŞBİLGİLERİToolStripMenuItem";
            this.sİPARİŞBİLGİLERİToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.sİPARİŞBİLGİLERİToolStripMenuItem.Text = "SİPARİŞ BİLGİLERİ";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            this.siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            this.siparişOluşturToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparişOluşturToolStripMenuItem.Click += new System.EventHandler(this.SiparişOluşturToolStripMenuItem_Click);
            // 
            // günSonuRaporuToolStripMenuItem
            // 
            this.günSonuRaporuToolStripMenuItem.Name = "günSonuRaporuToolStripMenuItem";
            this.günSonuRaporuToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.günSonuRaporuToolStripMenuItem.Text = "GünSonu Raporu";
            this.günSonuRaporuToolStripMenuItem.Click += new System.EventHandler(this.GünSonuRaporuToolStripMenuItem_Click);
            // 
            // bİLGİLERToolStripMenuItem
            // 
            this.bİLGİLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüBilgileriToolStripMenuItem,
            this.extraBilgileriToolStripMenuItem});
            this.bİLGİLERToolStripMenuItem.Name = "bİLGİLERToolStripMenuItem";
            this.bİLGİLERToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.bİLGİLERToolStripMenuItem.Text = "BİLGİLER";
            // 
            // menüBilgileriToolStripMenuItem
            // 
            this.menüBilgileriToolStripMenuItem.Name = "menüBilgileriToolStripMenuItem";
            this.menüBilgileriToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.menüBilgileriToolStripMenuItem.Text = "Menü Bilgileri";
            this.menüBilgileriToolStripMenuItem.Click += new System.EventHandler(this.MenüBilgileriToolStripMenuItem_Click);
            // 
            // extraBilgileriToolStripMenuItem
            // 
            this.extraBilgileriToolStripMenuItem.Name = "extraBilgileriToolStripMenuItem";
            this.extraBilgileriToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.extraBilgileriToolStripMenuItem.Text = "Extra Bilgileri";
            this.extraBilgileriToolStripMenuItem.Click += new System.EventHandler(this.ExtraBilgileriToolStripMenuItem_Click);
            // 
            // MyMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 330);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyMDIForm";
            this.Text = "RestaurantOrder";
            this.Load += new System.EventHandler(this.MyMDIForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sİPARİŞBİLGİLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günSonuRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bİLGİLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menüBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraBilgileriToolStripMenuItem;
    }
}