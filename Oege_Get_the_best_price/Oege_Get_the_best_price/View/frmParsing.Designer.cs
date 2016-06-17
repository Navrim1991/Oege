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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParsing));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdioButShipping = new System.Windows.Forms.RadioButton();
            this.rdioButNoShipping = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdioButBrutto = new System.Windows.Forms.RadioButton();
            this.rdioButNetto = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butSearchEan = new System.Windows.Forms.Button();
            this.txtSearchEan = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.clmHeaderEan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderArticel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderAmazon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderEbay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderOwnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblProgressAmazon = new System.Windows.Forms.Label();
            this.lblProgressEbay = new System.Windows.Forms.Label();
            this.lvlProgress = new System.Windows.Forms.Label();
            this.progressBarParsing = new System.Windows.Forms.ProgressBar();
            this.grpBoxEbay = new System.Windows.Forms.GroupBox();
            this.butEbay = new System.Windows.Forms.Button();
            this.lblPriceEbay = new System.Windows.Forms.Label();
            this.txtPriceEaby = new System.Windows.Forms.TextBox();
            this.lblShippingEbay = new System.Windows.Forms.Label();
            this.txtShippingEbay = new System.Windows.Forms.TextBox();
            this.lblArticelEbay = new System.Windows.Forms.Label();
            this.txtArticleEbay = new System.Windows.Forms.TextBox();
            this.grpBoxAmazon = new System.Windows.Forms.GroupBox();
            this.butAmazon = new System.Windows.Forms.Button();
            this.lblAmazonPrice = new System.Windows.Forms.Label();
            this.txtPriceAmazon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShippingAmazon = new System.Windows.Forms.TextBox();
            this.lblAmazonArtikel = new System.Windows.Forms.Label();
            this.txtArtikelAmazon = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPriceOwn = new System.Windows.Forms.TextBox();
            this.lblPriceOwn = new System.Windows.Forms.Label();
            this.lblEan = new System.Windows.Forms.Label();
            this.lvlArtikel = new System.Windows.Forms.Label();
            this.txtArtikel = new System.Windows.Forms.TextBox();
            this.txtEan = new System.Windows.Forms.TextBox();
            this.backgroundWorkerExcel = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxEbay.SuspendLayout();
            this.grpBoxAmazon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(999, 790);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.butSearchEan);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchEan);
            this.splitContainer1.Panel1.Controls.Add(this.listView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblProgressAmazon);
            this.splitContainer1.Panel2.Controls.Add(this.lblProgressEbay);
            this.splitContainer1.Panel2.Controls.Add(this.lvlProgress);
            this.splitContainer1.Panel2.Controls.Add(this.progressBarParsing);
            this.splitContainer1.Panel2.Controls.Add(this.grpBoxEbay);
            this.splitContainer1.Panel2.Controls.Add(this.grpBoxAmazon);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1573, 936);
            this.splitContainer1.SplitterDistance = 1110;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rdioButShipping);
            this.panel2.Controls.Add(this.rdioButNoShipping);
            this.panel2.Location = new System.Drawing.Point(940, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 52);
            this.panel2.TabIndex = 8;
            // 
            // rdioButShipping
            // 
            this.rdioButShipping.AutoSize = true;
            this.rdioButShipping.Location = new System.Drawing.Point(3, 3);
            this.rdioButShipping.Name = "rdioButShipping";
            this.rdioButShipping.Size = new System.Drawing.Size(147, 20);
            this.rdioButShipping.TabIndex = 1;
            this.rdioButShipping.Text = "mit Versandkosten";
            this.rdioButShipping.UseVisualStyleBackColor = true;
            this.rdioButShipping.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rdioButNoShipping
            // 
            this.rdioButNoShipping.AutoSize = true;
            this.rdioButNoShipping.Checked = true;
            this.rdioButNoShipping.Location = new System.Drawing.Point(3, 29);
            this.rdioButNoShipping.Name = "rdioButNoShipping";
            this.rdioButNoShipping.Size = new System.Drawing.Size(161, 20);
            this.rdioButNoShipping.TabIndex = 0;
            this.rdioButNoShipping.TabStop = true;
            this.rdioButNoShipping.Text = "keine Versandkosten";
            this.rdioButNoShipping.UseVisualStyleBackColor = true;
            this.rdioButNoShipping.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rdioButBrutto);
            this.panel1.Controls.Add(this.rdioButNetto);
            this.panel1.Location = new System.Drawing.Point(855, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 52);
            this.panel1.TabIndex = 7;
            // 
            // rdioButBrutto
            // 
            this.rdioButBrutto.AutoSize = true;
            this.rdioButBrutto.Checked = true;
            this.rdioButBrutto.Location = new System.Drawing.Point(3, 29);
            this.rdioButBrutto.Name = "rdioButBrutto";
            this.rdioButBrutto.Size = new System.Drawing.Size(67, 20);
            this.rdioButBrutto.TabIndex = 1;
            this.rdioButBrutto.TabStop = true;
            this.rdioButBrutto.Text = "Brutto";
            this.rdioButBrutto.UseVisualStyleBackColor = true;
            this.rdioButBrutto.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rdioButNetto
            // 
            this.rdioButNetto.AutoSize = true;
            this.rdioButNetto.Location = new System.Drawing.Point(3, 3);
            this.rdioButNetto.Name = "rdioButNetto";
            this.rdioButNetto.Size = new System.Drawing.Size(63, 20);
            this.rdioButNetto.TabIndex = 0;
            this.rdioButNetto.Text = "Netto";
            this.rdioButNetto.UseVisualStyleBackColor = true;
            this.rdioButNetto.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // butSearchEan
            // 
            this.butSearchEan.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.butSearchEan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butSearchEan.Location = new System.Drawing.Point(254, 27);
            this.butSearchEan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butSearchEan.Name = "butSearchEan";
            this.butSearchEan.Size = new System.Drawing.Size(127, 35);
            this.butSearchEan.TabIndex = 5;
            this.butSearchEan.Text = "Suchen";
            this.butSearchEan.UseVisualStyleBackColor = true;
            this.butSearchEan.Click += new System.EventHandler(this.butSearchEan_Click);
            // 
            // txtSearchEan
            // 
            this.txtSearchEan.Font = new System.Drawing.Font("Verdana", 14F);
            this.txtSearchEan.Location = new System.Drawing.Point(36, 27);
            this.txtSearchEan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchEan.Multiline = true;
            this.txtSearchEan.Name = "txtSearchEan";
            this.txtSearchEan.Size = new System.Drawing.Size(212, 35);
            this.txtSearchEan.TabIndex = 4;
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
            this.listView.Font = new System.Drawing.Font("Verdana", 11F);
            this.listView.ForeColor = System.Drawing.Color.Black;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 80);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1105, 1158);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // clmHeaderEan
            // 
            this.clmHeaderEan.Text = "EAN";
            this.clmHeaderEan.Width = 254;
            // 
            // clmHeaderArticel
            // 
            this.clmHeaderArticel.Text = "Artikelbeschreibung";
            this.clmHeaderArticel.Width = 308;
            // 
            // clmHeaderAmazon
            // 
            this.clmHeaderAmazon.Text = "Amazon";
            this.clmHeaderAmazon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmHeaderAmazon.Width = 168;
            // 
            // clmHeaderEbay
            // 
            this.clmHeaderEbay.Text = "Ebay";
            this.clmHeaderEbay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmHeaderEbay.Width = 193;
            // 
            // clmHeaderOwnPrice
            // 
            this.clmHeaderOwnPrice.Text = "Lieferant";
            this.clmHeaderOwnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmHeaderOwnPrice.Width = 178;
            // 
            // lblProgressAmazon
            // 
            this.lblProgressAmazon.AutoSize = true;
            this.lblProgressAmazon.ForeColor = System.Drawing.Color.Black;
            this.lblProgressAmazon.Location = new System.Drawing.Point(108, 821);
            this.lblProgressAmazon.Name = "lblProgressAmazon";
            this.lblProgressAmazon.Size = new System.Drawing.Size(59, 16);
            this.lblProgressAmazon.TabIndex = 10;
            this.lblProgressAmazon.Text = "Amazon";
            // 
            // lblProgressEbay
            // 
            this.lblProgressEbay.AutoSize = true;
            this.lblProgressEbay.ForeColor = System.Drawing.Color.Black;
            this.lblProgressEbay.Location = new System.Drawing.Point(175, 821);
            this.lblProgressEbay.Name = "lblProgressEbay";
            this.lblProgressEbay.Size = new System.Drawing.Size(40, 16);
            this.lblProgressEbay.TabIndex = 9;
            this.lblProgressEbay.Text = "Ebay";
            // 
            // lvlProgress
            // 
            this.lvlProgress.AutoSize = true;
            this.lvlProgress.ForeColor = System.Drawing.Color.Black;
            this.lvlProgress.Location = new System.Drawing.Point(24, 821);
            this.lvlProgress.Name = "lvlProgress";
            this.lvlProgress.Size = new System.Drawing.Size(84, 16);
            this.lvlProgress.TabIndex = 7;
            this.lvlProgress.Text = "Fortschritt:";
            // 
            // progressBarParsing
            // 
            this.progressBarParsing.Location = new System.Drawing.Point(21, 840);
            this.progressBarParsing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarParsing.Name = "progressBarParsing";
            this.progressBarParsing.Size = new System.Drawing.Size(513, 37);
            this.progressBarParsing.TabIndex = 6;
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
            this.grpBoxEbay.Font = new System.Drawing.Font("Verdana", 18F);
            this.grpBoxEbay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpBoxEbay.Location = new System.Drawing.Point(21, 522);
            this.grpBoxEbay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxEbay.Name = "grpBoxEbay";
            this.grpBoxEbay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxEbay.Size = new System.Drawing.Size(513, 266);
            this.grpBoxEbay.TabIndex = 3;
            this.grpBoxEbay.TabStop = false;
            this.grpBoxEbay.Text = "Ebay";
            // 
            // butEbay
            // 
            this.butEbay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEbay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butEbay.Location = new System.Drawing.Point(358, 213);
            this.butEbay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butEbay.Name = "butEbay";
            this.butEbay.Size = new System.Drawing.Size(138, 28);
            this.butEbay.TabIndex = 18;
            this.butEbay.Text = "Artikel suchen";
            this.butEbay.UseVisualStyleBackColor = true;
            this.butEbay.Click += new System.EventHandler(this.butEbay_Click);
            // 
            // lblPriceEbay
            // 
            this.lblPriceEbay.AutoSize = true;
            this.lblPriceEbay.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblPriceEbay.ForeColor = System.Drawing.Color.Black;
            this.lblPriceEbay.Location = new System.Drawing.Point(3, 131);
            this.lblPriceEbay.Name = "lblPriceEbay";
            this.lblPriceEbay.Size = new System.Drawing.Size(41, 17);
            this.lblPriceEbay.TabIndex = 17;
            this.lblPriceEbay.Text = "Preis";
            // 
            // txtPriceEaby
            // 
            this.txtPriceEaby.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPriceEaby.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtPriceEaby.Location = new System.Drawing.Point(155, 131);
            this.txtPriceEaby.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceEaby.Name = "txtPriceEaby";
            this.txtPriceEaby.ReadOnly = true;
            this.txtPriceEaby.Size = new System.Drawing.Size(132, 24);
            this.txtPriceEaby.TabIndex = 16;
            // 
            // lblShippingEbay
            // 
            this.lblShippingEbay.AutoSize = true;
            this.lblShippingEbay.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblShippingEbay.ForeColor = System.Drawing.Color.Black;
            this.lblShippingEbay.Location = new System.Drawing.Point(3, 163);
            this.lblShippingEbay.Name = "lblShippingEbay";
            this.lblShippingEbay.Size = new System.Drawing.Size(113, 17);
            this.lblShippingEbay.TabIndex = 15;
            this.lblShippingEbay.Text = "Versandkosten";
            // 
            // txtShippingEbay
            // 
            this.txtShippingEbay.BackColor = System.Drawing.Color.Gainsboro;
            this.txtShippingEbay.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtShippingEbay.Location = new System.Drawing.Point(155, 163);
            this.txtShippingEbay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShippingEbay.Name = "txtShippingEbay";
            this.txtShippingEbay.ReadOnly = true;
            this.txtShippingEbay.Size = new System.Drawing.Size(132, 24);
            this.txtShippingEbay.TabIndex = 14;
            // 
            // lblArticelEbay
            // 
            this.lblArticelEbay.AutoSize = true;
            this.lblArticelEbay.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblArticelEbay.ForeColor = System.Drawing.Color.Black;
            this.lblArticelEbay.Location = new System.Drawing.Point(3, 44);
            this.lblArticelEbay.Name = "lblArticelEbay";
            this.lblArticelEbay.Size = new System.Drawing.Size(146, 17);
            this.lblArticelEbay.TabIndex = 13;
            this.lblArticelEbay.Text = "Artikelbeschreibung";
            // 
            // txtArticleEbay
            // 
            this.txtArticleEbay.BackColor = System.Drawing.Color.Gainsboro;
            this.txtArticleEbay.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtArticleEbay.Location = new System.Drawing.Point(155, 44);
            this.txtArticleEbay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArticleEbay.Multiline = true;
            this.txtArticleEbay.Name = "txtArticleEbay";
            this.txtArticleEbay.ReadOnly = true;
            this.txtArticleEbay.Size = new System.Drawing.Size(349, 79);
            this.txtArticleEbay.TabIndex = 12;
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
            this.grpBoxAmazon.Font = new System.Drawing.Font("Verdana", 18F);
            this.grpBoxAmazon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpBoxAmazon.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.grpBoxAmazon.Location = new System.Drawing.Point(21, 257);
            this.grpBoxAmazon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxAmazon.Name = "grpBoxAmazon";
            this.grpBoxAmazon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxAmazon.Size = new System.Drawing.Size(513, 266);
            this.grpBoxAmazon.TabIndex = 2;
            this.grpBoxAmazon.TabStop = false;
            this.grpBoxAmazon.Text = "Amazon";
            this.grpBoxAmazon.UseCompatibleTextRendering = true;
            // 
            // butAmazon
            // 
            this.butAmazon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAmazon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butAmazon.Location = new System.Drawing.Point(358, 222);
            this.butAmazon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butAmazon.Name = "butAmazon";
            this.butAmazon.Size = new System.Drawing.Size(138, 28);
            this.butAmazon.TabIndex = 10;
            this.butAmazon.Text = "Artikel suchen";
            this.butAmazon.UseVisualStyleBackColor = true;
            this.butAmazon.Click += new System.EventHandler(this.butAmazon_Click);
            // 
            // lblAmazonPrice
            // 
            this.lblAmazonPrice.AutoSize = true;
            this.lblAmazonPrice.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblAmazonPrice.ForeColor = System.Drawing.Color.Black;
            this.lblAmazonPrice.Location = new System.Drawing.Point(3, 127);
            this.lblAmazonPrice.Name = "lblAmazonPrice";
            this.lblAmazonPrice.Size = new System.Drawing.Size(41, 17);
            this.lblAmazonPrice.TabIndex = 9;
            this.lblAmazonPrice.Text = "Preis";
            // 
            // txtPriceAmazon
            // 
            this.txtPriceAmazon.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPriceAmazon.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtPriceAmazon.Location = new System.Drawing.Point(157, 127);
            this.txtPriceAmazon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceAmazon.Name = "txtPriceAmazon";
            this.txtPriceAmazon.ReadOnly = true;
            this.txtPriceAmazon.Size = new System.Drawing.Size(132, 24);
            this.txtPriceAmazon.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Versandkosten";
            // 
            // txtShippingAmazon
            // 
            this.txtShippingAmazon.BackColor = System.Drawing.Color.Gainsboro;
            this.txtShippingAmazon.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtShippingAmazon.Location = new System.Drawing.Point(157, 159);
            this.txtShippingAmazon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShippingAmazon.Name = "txtShippingAmazon";
            this.txtShippingAmazon.ReadOnly = true;
            this.txtShippingAmazon.Size = new System.Drawing.Size(132, 24);
            this.txtShippingAmazon.TabIndex = 6;
            // 
            // lblAmazonArtikel
            // 
            this.lblAmazonArtikel.AutoSize = true;
            this.lblAmazonArtikel.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblAmazonArtikel.ForeColor = System.Drawing.Color.Black;
            this.lblAmazonArtikel.Location = new System.Drawing.Point(3, 40);
            this.lblAmazonArtikel.Name = "lblAmazonArtikel";
            this.lblAmazonArtikel.Size = new System.Drawing.Size(146, 17);
            this.lblAmazonArtikel.TabIndex = 5;
            this.lblAmazonArtikel.Text = "Artikelbeschreibung";
            // 
            // txtArtikelAmazon
            // 
            this.txtArtikelAmazon.BackColor = System.Drawing.Color.Gainsboro;
            this.txtArtikelAmazon.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtArtikelAmazon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtArtikelAmazon.Location = new System.Drawing.Point(156, 40);
            this.txtArtikelAmazon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArtikelAmazon.Multiline = true;
            this.txtArtikelAmazon.Name = "txtArtikelAmazon";
            this.txtArtikelAmazon.ReadOnly = true;
            this.txtArtikelAmazon.Size = new System.Drawing.Size(349, 79);
            this.txtArtikelAmazon.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPriceOwn);
            this.groupBox1.Controls.Add(this.lblPriceOwn);
            this.groupBox1.Controls.Add(this.lblEan);
            this.groupBox1.Controls.Add(this.lvlArtikel);
            this.groupBox1.Controls.Add(this.txtArtikel);
            this.groupBox1.Controls.Add(this.txtEan);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 18F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 220);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ausgewähltes Produkt";
            // 
            // txtPriceOwn
            // 
            this.txtPriceOwn.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPriceOwn.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtPriceOwn.Location = new System.Drawing.Point(155, 175);
            this.txtPriceOwn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceOwn.Name = "txtPriceOwn";
            this.txtPriceOwn.ReadOnly = true;
            this.txtPriceOwn.Size = new System.Drawing.Size(135, 24);
            this.txtPriceOwn.TabIndex = 11;
            // 
            // lblPriceOwn
            // 
            this.lblPriceOwn.AutoSize = true;
            this.lblPriceOwn.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblPriceOwn.ForeColor = System.Drawing.Color.Black;
            this.lblPriceOwn.Location = new System.Drawing.Point(3, 175);
            this.lblPriceOwn.Name = "lblPriceOwn";
            this.lblPriceOwn.Size = new System.Drawing.Size(41, 17);
            this.lblPriceOwn.TabIndex = 12;
            this.lblPriceOwn.Text = "Preis";
            // 
            // lblEan
            // 
            this.lblEan.AutoSize = true;
            this.lblEan.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEan.ForeColor = System.Drawing.Color.Black;
            this.lblEan.Location = new System.Drawing.Point(3, 58);
            this.lblEan.Name = "lblEan";
            this.lblEan.Size = new System.Drawing.Size(37, 17);
            this.lblEan.TabIndex = 1;
            this.lblEan.Text = "EAN";
            // 
            // lvlArtikel
            // 
            this.lvlArtikel.AutoSize = true;
            this.lvlArtikel.Font = new System.Drawing.Font("Verdana", 10F);
            this.lvlArtikel.ForeColor = System.Drawing.Color.Black;
            this.lvlArtikel.Location = new System.Drawing.Point(3, 90);
            this.lvlArtikel.Name = "lvlArtikel";
            this.lvlArtikel.Size = new System.Drawing.Size(146, 17);
            this.lvlArtikel.TabIndex = 5;
            this.lvlArtikel.Text = "Artikelbeschreibung";
            // 
            // txtArtikel
            // 
            this.txtArtikel.BackColor = System.Drawing.Color.Gainsboro;
            this.txtArtikel.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtArtikel.Location = new System.Drawing.Point(155, 90);
            this.txtArtikel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArtikel.Multiline = true;
            this.txtArtikel.Name = "txtArtikel";
            this.txtArtikel.ReadOnly = true;
            this.txtArtikel.Size = new System.Drawing.Size(349, 77);
            this.txtArtikel.TabIndex = 4;
            // 
            // txtEan
            // 
            this.txtEan.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEan.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtEan.Location = new System.Drawing.Point(155, 58);
            this.txtEan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEan.Name = "txtEan";
            this.txtEan.ReadOnly = true;
            this.txtEan.Size = new System.Drawing.Size(187, 24);
            this.txtEan.TabIndex = 0;
            // 
            // backgroundWorkerExcel
            // 
            this.backgroundWorkerExcel.WorkerReportsProgress = true;
            this.backgroundWorkerExcel.WorkerSupportsCancellation = true;
            this.backgroundWorkerExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerExcel_DoWork);
            // 
            // frmParsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1573, 936);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmParsing";
            this.ShowIcon = false;
            this.Text = "Excel Liste Durchführen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmParsing_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxEbay.ResumeLayout(false);
            this.grpBoxEbay.PerformLayout();
            this.grpBoxAmazon.ResumeLayout(false);
            this.grpBoxAmazon.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lvlProgress;
        private System.Windows.Forms.ProgressBar progressBarParsing;
        private System.Windows.Forms.TextBox txtSearchEan;
        private System.Windows.Forms.Label lblProgressAmazon;
        private System.Windows.Forms.Label lblProgressEbay;
        private System.ComponentModel.BackgroundWorker backgroundWorkerExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblAmazonPrice;
        private System.Windows.Forms.TextBox txtPriceAmazon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShippingAmazon;
        private System.Windows.Forms.Label lblAmazonArtikel;
        private System.Windows.Forms.Button butEbay;
        private System.Windows.Forms.Label lblPriceEbay;
        private System.Windows.Forms.TextBox txtPriceEaby;
        private System.Windows.Forms.Label lblShippingEbay;
        private System.Windows.Forms.TextBox txtShippingEbay;
        private System.Windows.Forms.Label lblArticelEbay;
        private System.Windows.Forms.TextBox txtArticleEbay;
        private System.Windows.Forms.Button butAmazon;
        private System.Windows.Forms.Label lblPriceOwn;
        private System.Windows.Forms.TextBox txtPriceOwn;
        private System.Windows.Forms.ColumnHeader clmHeaderOwnPrice;
        private System.Windows.Forms.Button butSearchEan;
        private System.Windows.Forms.TextBox txtArtikelAmazon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdioButShipping;
        private System.Windows.Forms.RadioButton rdioButNoShipping;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdioButBrutto;
        private System.Windows.Forms.RadioButton rdioButNetto;
    }
}