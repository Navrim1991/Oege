namespace Oege_Get_the_best_price.View
{
    partial class frmParsing
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSuche = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.clmHeaderEan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderArticel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderAmazon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderEbay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblProgressAmazon = new System.Windows.Forms.Label();
            this.lblProgressEbay = new System.Windows.Forms.Label();
            this.lvlProgress = new System.Windows.Forms.Label();
            this.progressBarParsing = new System.Windows.Forms.ProgressBar();
            this.lvlArtikel = new System.Windows.Forms.Label();
            this.txtArtikel = new System.Windows.Forms.TextBox();
            this.grpBoxEbay = new System.Windows.Forms.GroupBox();
            this.butEbay = new System.Windows.Forms.Button();
            this.lblPriceEbay = new System.Windows.Forms.Label();
            this.txtPriceEaby = new System.Windows.Forms.TextBox();
            this.lblShippingEbay = new System.Windows.Forms.Label();
            this.txtShippingEbay = new System.Windows.Forms.TextBox();
            this.lblArticelEbay = new System.Windows.Forms.Label();
            this.txtArticleEbay = new System.Windows.Forms.TextBox();
            this.linkLblEbay = new System.Windows.Forms.LinkLabel();
            this.grpBoxAmazon = new System.Windows.Forms.GroupBox();
            this.butAmazon = new System.Windows.Forms.Button();
            this.lblAmazonPrice = new System.Windows.Forms.Label();
            this.txtPriceAmazon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShippingAmazon = new System.Windows.Forms.TextBox();
            this.lblAmazonArtikel = new System.Windows.Forms.Label();
            this.txtArtikelAmazon = new System.Windows.Forms.TextBox();
            this.linkLblAmazon = new System.Windows.Forms.LinkLabel();
            this.lblEan = new System.Windows.Forms.Label();
            this.txtEan = new System.Windows.Forms.TextBox();
            this.backgroundWorkerExcel = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblPriceOwn = new System.Windows.Forms.Label();
            this.txtPriceOwn = new System.Windows.Forms.TextBox();
            this.clmHeaderOwnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpBoxEbay.SuspendLayout();
            this.grpBoxAmazon.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(749, 642);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSuche);
            this.splitContainer1.Panel1.Controls.Add(this.lblSearch);
            this.splitContainer1.Panel1.Controls.Add(this.listView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblPriceOwn);
            this.splitContainer1.Panel2.Controls.Add(this.txtPriceOwn);
            this.splitContainer1.Panel2.Controls.Add(this.lblProgressAmazon);
            this.splitContainer1.Panel2.Controls.Add(this.lblProgressEbay);
            this.splitContainer1.Panel2.Controls.Add(this.lvlProgress);
            this.splitContainer1.Panel2.Controls.Add(this.progressBarParsing);
            this.splitContainer1.Panel2.Controls.Add(this.lvlArtikel);
            this.splitContainer1.Panel2.Controls.Add(this.txtArtikel);
            this.splitContainer1.Panel2.Controls.Add(this.grpBoxEbay);
            this.splitContainer1.Panel2.Controls.Add(this.grpBoxAmazon);
            this.splitContainer1.Panel2.Controls.Add(this.lblEan);
            this.splitContainer1.Panel2.Controls.Add(this.txtEan);
            this.splitContainer1.Size = new System.Drawing.Size(1241, 688);
            this.splitContainer1.SplitterDistance = 616;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtSuche
            // 
            this.txtSuche.Location = new System.Drawing.Point(52, 24);
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.Size = new System.Drawing.Size(141, 20);
            this.txtSuche.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 27);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(38, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Suche";
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHeaderEan,
            this.clmHeaderArticel,
            this.clmHeaderAmazon,
            this.clmHeaderEbay,
            this.clmHeaderOwnPrice});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(0, 65);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(614, 621);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // clmHeaderEan
            // 
            this.clmHeaderEan.Text = "EAN";
            this.clmHeaderEan.Width = 145;
            // 
            // clmHeaderArticel
            // 
            this.clmHeaderArticel.Text = "Artikelbeschreibung";
            this.clmHeaderArticel.Width = 305;
            // 
            // clmHeaderAmazon
            // 
            this.clmHeaderAmazon.Text = "Amazon";
            this.clmHeaderAmazon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmHeaderAmazon.Width = 81;
            // 
            // clmHeaderEbay
            // 
            this.clmHeaderEbay.Text = "Ebay";
            this.clmHeaderEbay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmHeaderEbay.Width = 81;
            // 
            // lblProgressAmazon
            // 
            this.lblProgressAmazon.AutoSize = true;
            this.lblProgressAmazon.Location = new System.Drawing.Point(95, 601);
            this.lblProgressAmazon.Name = "lblProgressAmazon";
            this.lblProgressAmazon.Size = new System.Drawing.Size(45, 13);
            this.lblProgressAmazon.TabIndex = 10;
            this.lblProgressAmazon.Text = "Amazon";
            // 
            // lblProgressEbay
            // 
            this.lblProgressEbay.AutoSize = true;
            this.lblProgressEbay.Location = new System.Drawing.Point(146, 601);
            this.lblProgressEbay.Name = "lblProgressEbay";
            this.lblProgressEbay.Size = new System.Drawing.Size(31, 13);
            this.lblProgressEbay.TabIndex = 9;
            this.lblProgressEbay.Text = "Ebay";
            // 
            // lvlProgress
            // 
            this.lvlProgress.AutoSize = true;
            this.lvlProgress.Location = new System.Drawing.Point(33, 601);
            this.lvlProgress.Name = "lvlProgress";
            this.lvlProgress.Size = new System.Drawing.Size(56, 13);
            this.lvlProgress.TabIndex = 7;
            this.lvlProgress.Text = "Fortschritt:";
            // 
            // progressBarParsing
            // 
            this.progressBarParsing.Location = new System.Drawing.Point(30, 617);
            this.progressBarParsing.Name = "progressBarParsing";
            this.progressBarParsing.Size = new System.Drawing.Size(383, 23);
            this.progressBarParsing.TabIndex = 6;
            // 
            // lvlArtikel
            // 
            this.lvlArtikel.AutoSize = true;
            this.lvlArtikel.Location = new System.Drawing.Point(30, 53);
            this.lvlArtikel.Name = "lvlArtikel";
            this.lvlArtikel.Size = new System.Drawing.Size(100, 13);
            this.lvlArtikel.TabIndex = 5;
            this.lvlArtikel.Text = "Artikelbeschreibung";
            // 
            // txtArtikel
            // 
            this.txtArtikel.Location = new System.Drawing.Point(136, 50);
            this.txtArtikel.Multiline = true;
            this.txtArtikel.Name = "txtArtikel";
            this.txtArtikel.ReadOnly = true;
            this.txtArtikel.Size = new System.Drawing.Size(263, 56);
            this.txtArtikel.TabIndex = 4;
            // 
            // grpBoxEbay
            // 
            this.grpBoxEbay.Controls.Add(this.butEbay);
            this.grpBoxEbay.Controls.Add(this.lblPriceEbay);
            this.grpBoxEbay.Controls.Add(this.txtPriceEaby);
            this.grpBoxEbay.Controls.Add(this.lblShippingEbay);
            this.grpBoxEbay.Controls.Add(this.txtShippingEbay);
            this.grpBoxEbay.Controls.Add(this.lblArticelEbay);
            this.grpBoxEbay.Controls.Add(this.txtArticleEbay);
            this.grpBoxEbay.Controls.Add(this.linkLblEbay);
            this.grpBoxEbay.Location = new System.Drawing.Point(30, 376);
            this.grpBoxEbay.Name = "grpBoxEbay";
            this.grpBoxEbay.Size = new System.Drawing.Size(383, 209);
            this.grpBoxEbay.TabIndex = 3;
            this.grpBoxEbay.TabStop = false;
            this.grpBoxEbay.Text = "Ebay";
            // 
            // butEbay
            // 
            this.butEbay.Location = new System.Drawing.Point(268, 173);
            this.butEbay.Name = "butEbay";
            this.butEbay.Size = new System.Drawing.Size(104, 23);
            this.butEbay.TabIndex = 18;
            this.butEbay.Text = "Artikel suchen";
            this.butEbay.UseVisualStyleBackColor = true;
            // 
            // lblPriceEbay
            // 
            this.lblPriceEbay.AutoSize = true;
            this.lblPriceEbay.Location = new System.Drawing.Point(6, 87);
            this.lblPriceEbay.Name = "lblPriceEbay";
            this.lblPriceEbay.Size = new System.Drawing.Size(30, 13);
            this.lblPriceEbay.TabIndex = 17;
            this.lblPriceEbay.Text = "Preis";
            // 
            // txtPriceEaby
            // 
            this.txtPriceEaby.Location = new System.Drawing.Point(109, 84);
            this.txtPriceEaby.Name = "txtPriceEaby";
            this.txtPriceEaby.ReadOnly = true;
            this.txtPriceEaby.Size = new System.Drawing.Size(100, 20);
            this.txtPriceEaby.TabIndex = 16;
            // 
            // lblShippingEbay
            // 
            this.lblShippingEbay.AutoSize = true;
            this.lblShippingEbay.Location = new System.Drawing.Point(6, 113);
            this.lblShippingEbay.Name = "lblShippingEbay";
            this.lblShippingEbay.Size = new System.Drawing.Size(78, 13);
            this.lblShippingEbay.TabIndex = 15;
            this.lblShippingEbay.Text = "Versandkosten";
            // 
            // txtShippingEbay
            // 
            this.txtShippingEbay.Location = new System.Drawing.Point(109, 110);
            this.txtShippingEbay.Name = "txtShippingEbay";
            this.txtShippingEbay.ReadOnly = true;
            this.txtShippingEbay.Size = new System.Drawing.Size(100, 20);
            this.txtShippingEbay.TabIndex = 14;
            // 
            // lblArticelEbay
            // 
            this.lblArticelEbay.AutoSize = true;
            this.lblArticelEbay.Location = new System.Drawing.Point(6, 16);
            this.lblArticelEbay.Name = "lblArticelEbay";
            this.lblArticelEbay.Size = new System.Drawing.Size(100, 13);
            this.lblArticelEbay.TabIndex = 13;
            this.lblArticelEbay.Text = "Artikelbeschreibung";
            // 
            // txtArticleEbay
            // 
            this.txtArticleEbay.Location = new System.Drawing.Point(109, 13);
            this.txtArticleEbay.Multiline = true;
            this.txtArticleEbay.Name = "txtArticleEbay";
            this.txtArticleEbay.ReadOnly = true;
            this.txtArticleEbay.Size = new System.Drawing.Size(263, 65);
            this.txtArticleEbay.TabIndex = 12;
            // 
            // linkLblEbay
            // 
            this.linkLblEbay.AutoSize = true;
            this.linkLblEbay.Location = new System.Drawing.Point(3, 143);
            this.linkLblEbay.Name = "linkLblEbay";
            this.linkLblEbay.Size = new System.Drawing.Size(68, 13);
            this.linkLblEbay.TabIndex = 11;
            this.linkLblEbay.TabStop = true;
            this.linkLblEbay.Text = "<Platzhalter>";
            this.linkLblEbay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblEbay_LinkClicked);
            // 
            // grpBoxAmazon
            // 
            this.grpBoxAmazon.Controls.Add(this.butAmazon);
            this.grpBoxAmazon.Controls.Add(this.lblAmazonPrice);
            this.grpBoxAmazon.Controls.Add(this.txtPriceAmazon);
            this.grpBoxAmazon.Controls.Add(this.label2);
            this.grpBoxAmazon.Controls.Add(this.txtShippingAmazon);
            this.grpBoxAmazon.Controls.Add(this.lblAmazonArtikel);
            this.grpBoxAmazon.Controls.Add(this.txtArtikelAmazon);
            this.grpBoxAmazon.Controls.Add(this.linkLblAmazon);
            this.grpBoxAmazon.Location = new System.Drawing.Point(30, 161);
            this.grpBoxAmazon.Name = "grpBoxAmazon";
            this.grpBoxAmazon.Size = new System.Drawing.Size(383, 209);
            this.grpBoxAmazon.TabIndex = 2;
            this.grpBoxAmazon.TabStop = false;
            this.grpBoxAmazon.Text = "Amazon";
            // 
            // butAmazon
            // 
            this.butAmazon.Location = new System.Drawing.Point(268, 180);
            this.butAmazon.Name = "butAmazon";
            this.butAmazon.Size = new System.Drawing.Size(104, 23);
            this.butAmazon.TabIndex = 10;
            this.butAmazon.Text = "Artikel suchen";
            this.butAmazon.UseVisualStyleBackColor = true;
            // 
            // lblAmazonPrice
            // 
            this.lblAmazonPrice.AutoSize = true;
            this.lblAmazonPrice.Location = new System.Drawing.Point(6, 94);
            this.lblAmazonPrice.Name = "lblAmazonPrice";
            this.lblAmazonPrice.Size = new System.Drawing.Size(30, 13);
            this.lblAmazonPrice.TabIndex = 9;
            this.lblAmazonPrice.Text = "Preis";
            // 
            // txtPriceAmazon
            // 
            this.txtPriceAmazon.Location = new System.Drawing.Point(109, 91);
            this.txtPriceAmazon.Name = "txtPriceAmazon";
            this.txtPriceAmazon.ReadOnly = true;
            this.txtPriceAmazon.Size = new System.Drawing.Size(100, 20);
            this.txtPriceAmazon.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Versandkosten";
            // 
            // txtShippingAmazon
            // 
            this.txtShippingAmazon.Location = new System.Drawing.Point(109, 117);
            this.txtShippingAmazon.Name = "txtShippingAmazon";
            this.txtShippingAmazon.ReadOnly = true;
            this.txtShippingAmazon.Size = new System.Drawing.Size(100, 20);
            this.txtShippingAmazon.TabIndex = 6;
            // 
            // lblAmazonArtikel
            // 
            this.lblAmazonArtikel.AutoSize = true;
            this.lblAmazonArtikel.Location = new System.Drawing.Point(6, 23);
            this.lblAmazonArtikel.Name = "lblAmazonArtikel";
            this.lblAmazonArtikel.Size = new System.Drawing.Size(100, 13);
            this.lblAmazonArtikel.TabIndex = 5;
            this.lblAmazonArtikel.Text = "Artikelbeschreibung";
            // 
            // txtArtikelAmazon
            // 
            this.txtArtikelAmazon.Location = new System.Drawing.Point(109, 20);
            this.txtArtikelAmazon.Multiline = true;
            this.txtArtikelAmazon.Name = "txtArtikelAmazon";
            this.txtArtikelAmazon.ReadOnly = true;
            this.txtArtikelAmazon.Size = new System.Drawing.Size(263, 65);
            this.txtArtikelAmazon.TabIndex = 4;
            // 
            // linkLblAmazon
            // 
            this.linkLblAmazon.AutoSize = true;
            this.linkLblAmazon.Location = new System.Drawing.Point(3, 150);
            this.linkLblAmazon.Name = "linkLblAmazon";
            this.linkLblAmazon.Size = new System.Drawing.Size(68, 13);
            this.linkLblAmazon.TabIndex = 3;
            this.linkLblAmazon.TabStop = true;
            this.linkLblAmazon.Text = "<Platzhalter>";
            this.linkLblAmazon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblAmazon_LinkClicked);
            // 
            // lblEan
            // 
            this.lblEan.AutoSize = true;
            this.lblEan.Location = new System.Drawing.Point(30, 27);
            this.lblEan.Name = "lblEan";
            this.lblEan.Size = new System.Drawing.Size(29, 13);
            this.lblEan.TabIndex = 1;
            this.lblEan.Text = "EAN";
            // 
            // txtEan
            // 
            this.txtEan.Location = new System.Drawing.Point(136, 24);
            this.txtEan.Name = "txtEan";
            this.txtEan.ReadOnly = true;
            this.txtEan.Size = new System.Drawing.Size(141, 20);
            this.txtEan.TabIndex = 0;
            // 
            // backgroundWorkerExcel
            // 
            this.backgroundWorkerExcel.WorkerReportsProgress = true;
            this.backgroundWorkerExcel.WorkerSupportsCancellation = true;
            this.backgroundWorkerExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerExcel_DoWork);
            // 
            // lblPriceOwn
            // 
            this.lblPriceOwn.AutoSize = true;
            this.lblPriceOwn.Location = new System.Drawing.Point(30, 115);
            this.lblPriceOwn.Name = "lblPriceOwn";
            this.lblPriceOwn.Size = new System.Drawing.Size(30, 13);
            this.lblPriceOwn.TabIndex = 12;
            this.lblPriceOwn.Text = "Preis";
            // 
            // txtPriceOwn
            // 
            this.txtPriceOwn.Location = new System.Drawing.Point(136, 112);
            this.txtPriceOwn.Name = "txtPriceOwn";
            this.txtPriceOwn.ReadOnly = true;
            this.txtPriceOwn.Size = new System.Drawing.Size(103, 20);
            this.txtPriceOwn.TabIndex = 11;
            // 
            // clmHeaderOwnPrice
            // 
            this.clmHeaderOwnPrice.Text = "Lieferant";
            this.clmHeaderOwnPrice.Width = 81;
            // 
            // frmParsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 688);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmParsing";
            this.Text = "find the price";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmParsing_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpBoxEbay.ResumeLayout(false);
            this.grpBoxEbay.PerformLayout();
            this.grpBoxAmazon.ResumeLayout(false);
            this.grpBoxAmazon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader clmHeaderEan;
        private System.Windows.Forms.ColumnHeader clmHeaderArticel;
        private System.Windows.Forms.ColumnHeader clmHeaderAmazon;
        private System.Windows.Forms.ColumnHeader clmHeaderEbay;
        private System.Windows.Forms.Label lblEan;
        private System.Windows.Forms.TextBox txtEan;
        private System.Windows.Forms.Label lvlArtikel;
        private System.Windows.Forms.TextBox txtArtikel;
        private System.Windows.Forms.GroupBox grpBoxEbay;
        private System.Windows.Forms.GroupBox grpBoxAmazon;
        private System.Windows.Forms.LinkLabel linkLblAmazon;
        private System.Windows.Forms.Label lvlProgress;
        private System.Windows.Forms.ProgressBar progressBarParsing;
        private System.Windows.Forms.TextBox txtSuche;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblProgressAmazon;
        private System.Windows.Forms.Label lblProgressEbay;
        private System.ComponentModel.BackgroundWorker backgroundWorkerExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblAmazonPrice;
        private System.Windows.Forms.TextBox txtPriceAmazon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShippingAmazon;
        private System.Windows.Forms.Label lblAmazonArtikel;
        private System.Windows.Forms.TextBox txtArtikelAmazon;
        private System.Windows.Forms.Button butEbay;
        private System.Windows.Forms.Label lblPriceEbay;
        private System.Windows.Forms.TextBox txtPriceEaby;
        private System.Windows.Forms.Label lblShippingEbay;
        private System.Windows.Forms.TextBox txtShippingEbay;
        private System.Windows.Forms.Label lblArticelEbay;
        private System.Windows.Forms.TextBox txtArticleEbay;
        private System.Windows.Forms.LinkLabel linkLblEbay;
        private System.Windows.Forms.Button butAmazon;
        private System.Windows.Forms.Label lblPriceOwn;
        private System.Windows.Forms.TextBox txtPriceOwn;
        private System.Windows.Forms.ColumnHeader clmHeaderOwnPrice;
    }
}