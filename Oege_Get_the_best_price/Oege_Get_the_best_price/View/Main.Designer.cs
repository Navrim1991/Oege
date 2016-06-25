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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl = new MdiTabControl.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oegetradingToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.schnellstartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelListeImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einzelneEanSuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.BackColor = System.Drawing.Color.Transparent;
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ForeColor = System.Drawing.Color.Black;
            this.tabControl.Location = new System.Drawing.Point(0, 57);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.MenuRenderer = null;
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1163, 677);
            this.tabControl.TabBorderEnhanced = true;
            this.tabControl.TabCloseButtonImage = null;
            this.tabControl.TabCloseButtonImageDisabled = null;
            this.tabControl.TabCloseButtonImageHot = null;
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedTabChanged += new System.EventHandler(this.tabControl_SelectedTabChanged);
            this.tabControl.Load += new System.EventHandler(this.tabControl_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oegetradingToolStripMenu,
            this.erstellenToolStripMenuItem,
            this.extraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(258, 14);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(60, 60, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(332, 26);
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
            this.exportToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.oegetradingToolStripMenu.Font = new System.Drawing.Font("Verdana", 12F);
            this.oegetradingToolStripMenu.ForeColor = System.Drawing.Color.Black;
            this.oegetradingToolStripMenu.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.oegetradingToolStripMenu.Name = "oegetradingToolStripMenu";
            this.oegetradingToolStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.oegetradingToolStripMenu.Size = new System.Drawing.Size(128, 22);
            this.oegetradingToolStripMenu.Text = "Oege Trading";
            this.oegetradingToolStripMenu.Click += new System.EventHandler(this.oegetradingToolStripMenu_Click);
            // 
            // schnellstartToolStripMenuItem
            // 
            this.schnellstartToolStripMenuItem.Name = "schnellstartToolStripMenuItem";
            this.schnellstartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.schnellstartToolStripMenuItem.Size = new System.Drawing.Size(393, 22);
            this.schnellstartToolStripMenuItem.Text = "Schnellstart";
            this.schnellstartToolStripMenuItem.Click += new System.EventHandler(this.schnellstartToolStripMenuItem_Click);
            // 
            // projektÖffnenToolStripMenuItem
            // 
            this.projektÖffnenToolStripMenuItem.Name = "projektÖffnenToolStripMenuItem";
            this.projektÖffnenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.projektÖffnenToolStripMenuItem.Size = new System.Drawing.Size(393, 22);
            this.projektÖffnenToolStripMenuItem.Text = "Projekt Öffnen";
            this.projektÖffnenToolStripMenuItem.Click += new System.EventHandler(this.projektÖffnenToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(393, 22);
            this.exportToolStripMenuItem.Text = "Datei-Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(393, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // erstellenToolStripMenuItem
            // 
            this.erstellenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelListeImportierenToolStripMenuItem,
            this.einzelneEanSuchenToolStripMenuItem});
            this.erstellenToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.erstellenToolStripMenuItem.Name = "erstellenToolStripMenuItem";
            this.erstellenToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.erstellenToolStripMenuItem.Text = "Erstellen";
            // 
            // excelListeImportierenToolStripMenuItem
            // 
            this.excelListeImportierenToolStripMenuItem.Name = "excelListeImportierenToolStripMenuItem";
            this.excelListeImportierenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.excelListeImportierenToolStripMenuItem.Size = new System.Drawing.Size(327, 22);
            this.excelListeImportierenToolStripMenuItem.Text = "Excel Liste Importieren";
            this.excelListeImportierenToolStripMenuItem.Click += new System.EventHandler(this.excelListeImportierenToolStripMenuItem_Click);
            // 
            // einzelneEanSuchenToolStripMenuItem
            // 
            this.einzelneEanSuchenToolStripMenuItem.Name = "einzelneEanSuchenToolStripMenuItem";
            this.einzelneEanSuchenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.einzelneEanSuchenToolStripMenuItem.Size = new System.Drawing.Size(327, 22);
            this.einzelneEanSuchenToolStripMenuItem.Text = "Einzelne Ean Suchen";
            this.einzelneEanSuchenToolStripMenuItem.Click += new System.EventHandler(this.einzelneEanSuchenToolStripMenuItem_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeToolStripMenuItem,
            this.optionenToolStripMenuItem});
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.hilfeToolStripMenuItem.Text = "Hilfe!";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.optionenToolStripMenuItem.Text = "Optionen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_3);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeaderPanel.BackgroundImage")));
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Controls.Add(this.menuStrip1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1163, 54);
            this.HeaderPanel.TabIndex = 3;
            this.HeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPanel_Paint);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1163, 733);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.tabControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Oege Get The Best Price";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MdiTabControl.TabControl tabControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oegetradingToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem schnellstartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelListeImportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einzelneEanSuchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel HeaderPanel;
    }
}

