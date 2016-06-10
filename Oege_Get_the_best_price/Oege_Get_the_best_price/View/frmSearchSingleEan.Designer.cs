namespace Oege_Get_the_best_price.View
{
    partial class frmSearchSingleEan
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
            this.butSearchEan = new System.Windows.Forms.Button();
            this.txtSearchEan = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpBoxEbay = new System.Windows.Forms.GroupBox();
            this.lblPriceEbay = new System.Windows.Forms.Label();
            this.txtPriceEaby = new System.Windows.Forms.TextBox();
            this.lblShippingEbay = new System.Windows.Forms.Label();
            this.txtShippingEbay = new System.Windows.Forms.TextBox();
            this.lblArticelEbay = new System.Windows.Forms.Label();
            this.txtArticleEbay = new System.Windows.Forms.TextBox();
            this.linkLblEbay = new System.Windows.Forms.LinkLabel();
            this.grpBoxAmazon = new System.Windows.Forms.GroupBox();
            this.lblAmazonPrice = new System.Windows.Forms.Label();
            this.txtPriceAmazon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShippingAmazon = new System.Windows.Forms.TextBox();
            this.lblAmazonArtikel = new System.Windows.Forms.Label();
            this.txtArtikelAmazon = new System.Windows.Forms.TextBox();
            this.linkLblAmazon = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.grpBoxEbay.SuspendLayout();
            this.grpBoxAmazon.SuspendLayout();
            this.SuspendLayout();
            // 
            // butSearchEan
            // 
            this.butSearchEan.Location = new System.Drawing.Point(207, 10);
            this.butSearchEan.Name = "butSearchEan";
            this.butSearchEan.Size = new System.Drawing.Size(75, 23);
            this.butSearchEan.TabIndex = 8;
            this.butSearchEan.Text = "Suchen";
            this.butSearchEan.UseVisualStyleBackColor = true;
            this.butSearchEan.Click += new System.EventHandler(this.butSearchEan_Click);
            // 
            // txtSearchEan
            // 
            this.txtSearchEan.Location = new System.Drawing.Point(60, 12);
            this.txtSearchEan.Name = "txtSearchEan";
            this.txtSearchEan.Size = new System.Drawing.Size(141, 20);
            this.txtSearchEan.TabIndex = 7;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(11, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(38, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Suche";
            // 
            // grpBoxEbay
            // 
            this.grpBoxEbay.Controls.Add(this.lblPriceEbay);
            this.grpBoxEbay.Controls.Add(this.txtPriceEaby);
            this.grpBoxEbay.Controls.Add(this.lblShippingEbay);
            this.grpBoxEbay.Controls.Add(this.txtShippingEbay);
            this.grpBoxEbay.Controls.Add(this.lblArticelEbay);
            this.grpBoxEbay.Controls.Add(this.txtArticleEbay);
            this.grpBoxEbay.Controls.Add(this.linkLblEbay);
            this.grpBoxEbay.Location = new System.Drawing.Point(14, 254);
            this.grpBoxEbay.Name = "grpBoxEbay";
            this.grpBoxEbay.Size = new System.Drawing.Size(383, 209);
            this.grpBoxEbay.TabIndex = 10;
            this.grpBoxEbay.TabStop = false;
            this.grpBoxEbay.Text = "Ebay";
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
            this.txtPriceEaby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(191)))));
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
            this.txtShippingEbay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(191)))));
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
            this.txtArticleEbay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(191)))));
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
            // 
            // grpBoxAmazon
            // 
            this.grpBoxAmazon.Controls.Add(this.lblAmazonPrice);
            this.grpBoxAmazon.Controls.Add(this.txtPriceAmazon);
            this.grpBoxAmazon.Controls.Add(this.label2);
            this.grpBoxAmazon.Controls.Add(this.txtShippingAmazon);
            this.grpBoxAmazon.Controls.Add(this.lblAmazonArtikel);
            this.grpBoxAmazon.Controls.Add(this.txtArtikelAmazon);
            this.grpBoxAmazon.Controls.Add(this.linkLblAmazon);
            this.grpBoxAmazon.Location = new System.Drawing.Point(14, 39);
            this.grpBoxAmazon.Name = "grpBoxAmazon";
            this.grpBoxAmazon.Size = new System.Drawing.Size(383, 209);
            this.grpBoxAmazon.TabIndex = 9;
            this.grpBoxAmazon.TabStop = false;
            this.grpBoxAmazon.Text = "Amazon";
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
            this.txtPriceAmazon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(191)))));
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
            this.txtShippingAmazon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(191)))));
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
            this.txtArtikelAmazon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(191)))));
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
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // frmSearchSingleEan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 476);
            this.Controls.Add(this.grpBoxEbay);
            this.Controls.Add(this.grpBoxAmazon);
            this.Controls.Add(this.butSearchEan);
            this.Controls.Add(this.txtSearchEan);
            this.Controls.Add(this.lblSearch);
            this.Name = "frmSearchSingleEan";
            this.Text = "frmSearchSingleEan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchSingleEan_FormClosing);
            this.grpBoxEbay.ResumeLayout(false);
            this.grpBoxEbay.PerformLayout();
            this.grpBoxAmazon.ResumeLayout(false);
            this.grpBoxAmazon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSearchEan;
        private System.Windows.Forms.TextBox txtSearchEan;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grpBoxEbay;
        private System.Windows.Forms.Label lblPriceEbay;
        private System.Windows.Forms.TextBox txtPriceEaby;
        private System.Windows.Forms.Label lblShippingEbay;
        private System.Windows.Forms.TextBox txtShippingEbay;
        private System.Windows.Forms.Label lblArticelEbay;
        private System.Windows.Forms.TextBox txtArticleEbay;
        private System.Windows.Forms.LinkLabel linkLblEbay;
        private System.Windows.Forms.GroupBox grpBoxAmazon;
        private System.Windows.Forms.Label lblAmazonPrice;
        private System.Windows.Forms.TextBox txtPriceAmazon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShippingAmazon;
        private System.Windows.Forms.Label lblAmazonArtikel;
        private System.Windows.Forms.TextBox txtArtikelAmazon;
        private System.Windows.Forms.LinkLabel linkLblAmazon;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}