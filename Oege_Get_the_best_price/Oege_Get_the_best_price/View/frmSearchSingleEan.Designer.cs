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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchSingleEan));
            this.butSearchEan = new System.Windows.Forms.Button();
            this.txtSearchEan = new System.Windows.Forms.TextBox();
            this.grpBoxEbay = new System.Windows.Forms.GroupBox();
            this.lblPriceEbay = new System.Windows.Forms.Label();
            this.txtPriceEaby = new System.Windows.Forms.TextBox();
            this.lblShippingEbay = new System.Windows.Forms.Label();
            this.txtShippingEbay = new System.Windows.Forms.TextBox();
            this.lblArticelEbay = new System.Windows.Forms.Label();
            this.txtArticleEbay = new System.Windows.Forms.TextBox();
            this.grpBoxAmazon = new System.Windows.Forms.GroupBox();
            this.lblAmazonPrice = new System.Windows.Forms.Label();
            this.txtPriceAmazon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShippingAmazon = new System.Windows.Forms.TextBox();
            this.lblAmazonArtikel = new System.Windows.Forms.Label();
            this.txtArtikelAmazon = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.butAmazon = new System.Windows.Forms.Button();
            this.butEbay = new System.Windows.Forms.Button();
            this.grpBoxEbay.SuspendLayout();
            this.grpBoxAmazon.SuspendLayout();
            this.SuspendLayout();
            // 
            // butSearchEan
            // 
            this.butSearchEan.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearchEan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butSearchEan.Location = new System.Drawing.Point(323, 20);
            this.butSearchEan.Margin = new System.Windows.Forms.Padding(4);
            this.butSearchEan.Name = "butSearchEan";
            this.butSearchEan.Size = new System.Drawing.Size(149, 39);
            this.butSearchEan.TabIndex = 8;
            this.butSearchEan.Text = "Suchen";
            this.butSearchEan.UseVisualStyleBackColor = true;
            this.butSearchEan.Click += new System.EventHandler(this.butSearchEan_Click);
            // 
            // txtSearchEan
            // 
            this.txtSearchEan.Font = new System.Drawing.Font("Verdana", 14F);
            this.txtSearchEan.Location = new System.Drawing.Point(29, 25);
            this.txtSearchEan.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchEan.Name = "txtSearchEan";
            this.txtSearchEan.Size = new System.Drawing.Size(286, 30);
            this.txtSearchEan.TabIndex = 7;
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
            this.grpBoxEbay.Location = new System.Drawing.Point(19, 374);
            this.grpBoxEbay.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxEbay.Name = "grpBoxEbay";
            this.grpBoxEbay.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxEbay.Size = new System.Drawing.Size(529, 285);
            this.grpBoxEbay.TabIndex = 10;
            this.grpBoxEbay.TabStop = false;
            this.grpBoxEbay.Text = "Ebay";
            // 
            // lblPriceEbay
            // 
            this.lblPriceEbay.AutoSize = true;
            this.lblPriceEbay.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblPriceEbay.ForeColor = System.Drawing.Color.Black;
            this.lblPriceEbay.Location = new System.Drawing.Point(5, 142);
            this.lblPriceEbay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceEbay.Name = "lblPriceEbay";
            this.lblPriceEbay.Size = new System.Drawing.Size(41, 17);
            this.lblPriceEbay.TabIndex = 17;
            this.lblPriceEbay.Text = "Preis";
            // 
            // txtPriceEaby
            // 
            this.txtPriceEaby.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPriceEaby.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtPriceEaby.Location = new System.Drawing.Point(162, 142);
            this.txtPriceEaby.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblShippingEbay.Location = new System.Drawing.Point(4, 174);
            this.lblShippingEbay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShippingEbay.Name = "lblShippingEbay";
            this.lblShippingEbay.Size = new System.Drawing.Size(113, 17);
            this.lblShippingEbay.TabIndex = 15;
            this.lblShippingEbay.Text = "Versandkosten";
            // 
            // txtShippingEbay
            // 
            this.txtShippingEbay.BackColor = System.Drawing.Color.Gainsboro;
            this.txtShippingEbay.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtShippingEbay.Location = new System.Drawing.Point(162, 174);
            this.txtShippingEbay.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblArticelEbay.Location = new System.Drawing.Point(5, 55);
            this.lblArticelEbay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticelEbay.Name = "lblArticelEbay";
            this.lblArticelEbay.Size = new System.Drawing.Size(146, 17);
            this.lblArticelEbay.TabIndex = 13;
            this.lblArticelEbay.Text = "Artikelbeschreibung";
            // 
            // txtArticleEbay
            // 
            this.txtArticleEbay.BackColor = System.Drawing.Color.Gainsboro;
            this.txtArticleEbay.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtArticleEbay.Location = new System.Drawing.Point(162, 55);
            this.txtArticleEbay.Margin = new System.Windows.Forms.Padding(4);
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
            this.grpBoxAmazon.Location = new System.Drawing.Point(19, 73);
            this.grpBoxAmazon.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxAmazon.Name = "grpBoxAmazon";
            this.grpBoxAmazon.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxAmazon.Size = new System.Drawing.Size(529, 278);
            this.grpBoxAmazon.TabIndex = 9;
            this.grpBoxAmazon.TabStop = false;
            this.grpBoxAmazon.Text = "Amazon";
            // 
            // lblAmazonPrice
            // 
            this.lblAmazonPrice.AutoSize = true;
            this.lblAmazonPrice.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblAmazonPrice.ForeColor = System.Drawing.Color.Black;
            this.lblAmazonPrice.Location = new System.Drawing.Point(4, 138);
            this.lblAmazonPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmazonPrice.Name = "lblAmazonPrice";
            this.lblAmazonPrice.Size = new System.Drawing.Size(41, 17);
            this.lblAmazonPrice.TabIndex = 9;
            this.lblAmazonPrice.Text = "Preis";
            // 
            // txtPriceAmazon
            // 
            this.txtPriceAmazon.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPriceAmazon.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtPriceAmazon.Location = new System.Drawing.Point(162, 138);
            this.txtPriceAmazon.Margin = new System.Windows.Forms.Padding(4);
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
            this.label2.Location = new System.Drawing.Point(4, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Versandkosten";
            // 
            // txtShippingAmazon
            // 
            this.txtShippingAmazon.BackColor = System.Drawing.Color.Gainsboro;
            this.txtShippingAmazon.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtShippingAmazon.Location = new System.Drawing.Point(162, 170);
            this.txtShippingAmazon.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblAmazonArtikel.Location = new System.Drawing.Point(4, 51);
            this.lblAmazonArtikel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmazonArtikel.Name = "lblAmazonArtikel";
            this.lblAmazonArtikel.Size = new System.Drawing.Size(146, 17);
            this.lblAmazonArtikel.TabIndex = 5;
            this.lblAmazonArtikel.Text = "Artikelbeschreibung";
            // 
            // txtArtikelAmazon
            // 
            this.txtArtikelAmazon.BackColor = System.Drawing.Color.Gainsboro;
            this.txtArtikelAmazon.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtArtikelAmazon.Location = new System.Drawing.Point(162, 51);
            this.txtArtikelAmazon.Margin = new System.Windows.Forms.Padding(4);
            this.txtArtikelAmazon.Multiline = true;
            this.txtArtikelAmazon.Name = "txtArtikelAmazon";
            this.txtArtikelAmazon.ReadOnly = true;
            this.txtArtikelAmazon.Size = new System.Drawing.Size(349, 79);
            this.txtArtikelAmazon.TabIndex = 4;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // butAmazon
            // 
            this.butAmazon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAmazon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butAmazon.Location = new System.Drawing.Point(373, 242);
            this.butAmazon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butAmazon.Name = "butAmazon";
            this.butAmazon.Size = new System.Drawing.Size(138, 28);
            this.butAmazon.TabIndex = 11;
            this.butAmazon.Text = "Artikel öffnen";
            this.butAmazon.UseVisualStyleBackColor = true;
            this.butAmazon.Click += new System.EventHandler(this.butAmazon_Click);
            // 
            // butEbay
            // 
            this.butEbay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEbay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butEbay.Location = new System.Drawing.Point(373, 249);
            this.butEbay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butEbay.Name = "butEbay";
            this.butEbay.Size = new System.Drawing.Size(138, 28);
            this.butEbay.TabIndex = 18;
            this.butEbay.Text = "Artikel öffnen";
            this.butEbay.UseVisualStyleBackColor = true;
            this.butEbay.Click += new System.EventHandler(this.butEbay_Click);
            // 
            // frmSearchSingleEan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(565, 694);
            this.Controls.Add(this.grpBoxEbay);
            this.Controls.Add(this.grpBoxAmazon);
            this.Controls.Add(this.butSearchEan);
            this.Controls.Add(this.txtSearchEan);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-50, -50);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSearchSingleEan";
            this.Text = "Einzelne Ean  Suchen";
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
        private System.Windows.Forms.GroupBox grpBoxEbay;
        private System.Windows.Forms.Label lblPriceEbay;
        private System.Windows.Forms.TextBox txtPriceEaby;
        private System.Windows.Forms.Label lblShippingEbay;
        private System.Windows.Forms.TextBox txtShippingEbay;
        private System.Windows.Forms.Label lblArticelEbay;
        private System.Windows.Forms.TextBox txtArticleEbay;
        private System.Windows.Forms.GroupBox grpBoxAmazon;
        private System.Windows.Forms.Label lblAmazonPrice;
        private System.Windows.Forms.TextBox txtPriceAmazon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShippingAmazon;
        private System.Windows.Forms.Label lblAmazonArtikel;
        private System.Windows.Forms.TextBox txtArtikelAmazon;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button butEbay;
        private System.Windows.Forms.Button butAmazon;
    }
}