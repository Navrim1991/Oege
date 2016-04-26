namespace Oege_Get_the_best_price.View
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
            this.tabControl = new MdiTabControl.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oegetradingToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.schnellstartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelListeImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einzelneEanSuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(2, 29);
            this.tabControl.MenuRenderer = null;
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1443, 735);
            this.tabControl.TabBorderEnhanced = true;
            this.tabControl.TabCloseButtonImage = null;
            this.tabControl.TabCloseButtonImageDisabled = null;
            this.tabControl.TabCloseButtonImageHot = null;
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedTabChanged += new System.EventHandler(this.tabControl_SelectedTabChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oegetradingToolStripMenu,
            this.erstellenToolStripMenuItem,
            this.extraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(205, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // oegetradingToolStripMenu
            // 
            this.oegetradingToolStripMenu.AutoToolTip = true;
            this.oegetradingToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schnellstartToolStripMenuItem,
            this.projektÖffnenToolStripMenuItem,
            this.speichernUnterToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.oegetradingToolStripMenu.Name = "oegetradingToolStripMenu";
            this.oegetradingToolStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.oegetradingToolStripMenu.Size = new System.Drawing.Size(90, 20);
            this.oegetradingToolStripMenu.Text = "Oege Trading";
            // 
            // schnellstartToolStripMenuItem
            // 
            this.schnellstartToolStripMenuItem.Name = "schnellstartToolStripMenuItem";
            this.schnellstartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.schnellstartToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.schnellstartToolStripMenuItem.Text = "Schnellstart";
            this.schnellstartToolStripMenuItem.Click += new System.EventHandler(this.schnellstartToolStripMenuItem_Click);
            // 
            // projektÖffnenToolStripMenuItem
            // 
            this.projektÖffnenToolStripMenuItem.Name = "projektÖffnenToolStripMenuItem";
            this.projektÖffnenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.projektÖffnenToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.projektÖffnenToolStripMenuItem.Text = "Projekt Öffnen";
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.speichernUnterToolStripMenuItem.Text = "Speichern Unter";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // erstellenToolStripMenuItem
            // 
            this.erstellenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelListeImportierenToolStripMenuItem,
            this.einzelneEanSuchenToolStripMenuItem});
            this.erstellenToolStripMenuItem.Name = "erstellenToolStripMenuItem";
            this.erstellenToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.erstellenToolStripMenuItem.Text = "Erstellen";
            // 
            // excelListeImportierenToolStripMenuItem
            // 
            this.excelListeImportierenToolStripMenuItem.Name = "excelListeImportierenToolStripMenuItem";
            this.excelListeImportierenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.excelListeImportierenToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.excelListeImportierenToolStripMenuItem.Text = "Excel Liste Importieren";
            // 
            // einzelneEanSuchenToolStripMenuItem
            // 
            this.einzelneEanSuchenToolStripMenuItem.Name = "einzelneEanSuchenToolStripMenuItem";
            this.einzelneEanSuchenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.einzelneEanSuchenToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.einzelneEanSuchenToolStripMenuItem.Text = "Einzelne Ean Suchen";
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeToolStripMenuItem,
            this.optionenToolStripMenuItem});
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.hilfeToolStripMenuItem.Text = "Hilfe!";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.optionenToolStripMenuItem.Text = "Optionen";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 762);
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
        private MdiTabControl.TabControl tabControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oegetradingToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem schnellstartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernUnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelListeImportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einzelneEanSuchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
    }
}

