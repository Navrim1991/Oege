namespace Oege_Get_the_best_price.View.Main
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffneFensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelDateiÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new MdiTabControl.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oegeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(55, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oegeToolStripMenuItem
            // 
            this.oegeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffneFensterToolStripMenuItem,
            this.excelDateiÖffnenToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.oegeToolStripMenuItem.Name = "oegeToolStripMenuItem";
            this.oegeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.oegeToolStripMenuItem.Text = "Oege";
            // 
            // öffneFensterToolStripMenuItem
            // 
            this.öffneFensterToolStripMenuItem.Name = "öffneFensterToolStripMenuItem";
            this.öffneFensterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.öffneFensterToolStripMenuItem.Text = "Öffne Fenster";
            this.öffneFensterToolStripMenuItem.Click += new System.EventHandler(this.öffneFensterToolStripMenuItem_Click);
            // 
            // excelDateiÖffnenToolStripMenuItem
            // 
            this.excelDateiÖffnenToolStripMenuItem.Name = "excelDateiÖffnenToolStripMenuItem";
            this.excelDateiÖffnenToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.excelDateiÖffnenToolStripMenuItem.Text = "Excel-Datei öffnen";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(2, 27);
            this.tabControl.MenuRenderer = null;
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1242, 634);
            this.tabControl.TabBorderEnhanced = true;
            this.tabControl.TabCloseButtonImage = null;
            this.tabControl.TabCloseButtonImageDisabled = null;
            this.tabControl.TabCloseButtonImageHot = null;
            this.tabControl.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 661);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Oege get the best price";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelDateiÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private MdiTabControl.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem öffneFensterToolStripMenuItem;
    }
}

