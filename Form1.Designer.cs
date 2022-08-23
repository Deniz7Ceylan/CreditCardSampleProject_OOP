namespace CreditCardSampleProject_OOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBankamatik = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKKPlatin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKKAltin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKKGumus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYeni,
            this.mnuCikis});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(51, 20);
            this.mnuDosya.Text = "Dosya";
            // 
            // mnuYeni
            // 
            this.mnuYeni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKart});
            this.mnuYeni.Name = "mnuYeni";
            this.mnuYeni.Size = new System.Drawing.Size(180, 22);
            this.mnuYeni.Text = "Yeni";
            // 
            // mnuKart
            // 
            this.mnuKart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBankamatik,
            this.mnuKKPlatin,
            this.mnuKKAltin,
            this.mnuKKGumus});
            this.mnuKart.Name = "mnuKart";
            this.mnuKart.Size = new System.Drawing.Size(180, 22);
            this.mnuKart.Text = "Kart";
            // 
            // mnuBankamatik
            // 
            this.mnuBankamatik.Name = "mnuBankamatik";
            this.mnuBankamatik.Size = new System.Drawing.Size(180, 22);
            this.mnuBankamatik.Text = "Bankamatik";
            this.mnuBankamatik.Click += new System.EventHandler(this.mnuBankamatik_Click);
            // 
            // mnuKKPlatin
            // 
            this.mnuKKPlatin.Name = "mnuKKPlatin";
            this.mnuKKPlatin.Size = new System.Drawing.Size(180, 22);
            this.mnuKKPlatin.Text = "Kredi Kartı (Platin)";
            this.mnuKKPlatin.Click += new System.EventHandler(this.mnuKKPlatin_Click);
            // 
            // mnuKKAltin
            // 
            this.mnuKKAltin.Name = "mnuKKAltin";
            this.mnuKKAltin.Size = new System.Drawing.Size(180, 22);
            this.mnuKKAltin.Text = "Kredi Kartı (Altın)";
            this.mnuKKAltin.Click += new System.EventHandler(this.mnuKKAltin_Click);
            // 
            // mnuKKGumus
            // 
            this.mnuKKGumus.Name = "mnuKKGumus";
            this.mnuKKGumus.Size = new System.Drawing.Size(180, 22);
            this.mnuKKGumus.Text = "Kredi Kartı (Gümüş)";
            this.mnuKKGumus.Click += new System.EventHandler(this.mnuKKGumus_Click);
            // 
            // mnuCikis
            // 
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(180, 22);
            this.mnuCikis.Text = "Çıkış";
            this.mnuCikis.Click += new System.EventHandler(this.mnuCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 121);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuDosya;
        private ToolStripMenuItem mnuYeni;
        private ToolStripMenuItem mnuKart;
        private ToolStripMenuItem mnuBankamatik;
        private ToolStripMenuItem mnuKKPlatin;
        private ToolStripMenuItem mnuKKAltin;
        private ToolStripMenuItem mnuKKGumus;
        private ToolStripMenuItem mnuCikis;
    }
}