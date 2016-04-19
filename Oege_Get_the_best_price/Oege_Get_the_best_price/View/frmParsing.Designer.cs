﻿using Oege_Get_the_best_price.Resources;

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
            this.listView = new System.Windows.Forms.ListView();
            this.clmHeaderEan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderArticel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderAmazon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderEbay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderIdealo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpBoxIdealo = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lvlArtikel = new System.Windows.Forms.Label();
            this.txtArtikel = new System.Windows.Forms.TextBox();
            this.grpBoxEbay = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblEbayPrice = new System.Windows.Forms.Label();
            this.grpBoxAmazon = new System.Windows.Forms.GroupBox();
            this.linkLblAmazon = new System.Windows.Forms.LinkLabel();
            this.lblAmazonPrice = new System.Windows.Forms.Label();
            this.lblEan = new System.Windows.Forms.Label();
            this.txtEan = new System.Windows.Forms.TextBox();
            this.progressBarParsing = new System.Windows.Forms.ProgressBar();
            this.lvlProgress = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSuche = new System.Windows.Forms.TextBox();
            this.backgroundWorkerAmazon = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerEbay = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerIdealo = new System.ComponentModel.BackgroundWorker();
            this.currencyEuroBox2 = new Oege_Get_the_best_price.Resources.CurrencyEuroBox();
            this.cur = new Oege_Get_the_best_price.Resources.CurrencyEuroBox();
            this.curAmazonPrice = new Oege_Get_the_best_price.Resources.CurrencyEuroBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpBoxIdealo.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.lvlProgress);
            this.splitContainer1.Panel2.Controls.Add(this.progressBarParsing);
            this.splitContainer1.Panel2.Controls.Add(this.grpBoxIdealo);
            this.splitContainer1.Panel2.Controls.Add(this.lvlArtikel);
            this.splitContainer1.Panel2.Controls.Add(this.txtArtikel);
            this.splitContainer1.Panel2.Controls.Add(this.grpBoxEbay);
            this.splitContainer1.Panel2.Controls.Add(this.grpBoxAmazon);
            this.splitContainer1.Panel2.Controls.Add(this.lblEan);
            this.splitContainer1.Panel2.Controls.Add(this.txtEan);
            this.splitContainer1.Size = new System.Drawing.Size(1241, 643);
            this.splitContainer1.SplitterDistance = 499;
            this.splitContainer1.TabIndex = 0;
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
            this.clmHeaderIdealo});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(0, 65);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(497, 576);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // clmHeaderEan
            // 
            this.clmHeaderEan.Text = "EAN";
            this.clmHeaderEan.Width = 34;
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
            this.clmHeaderAmazon.Width = 50;
            // 
            // clmHeaderEbay
            // 
            this.clmHeaderEbay.Text = "Ebay";
            this.clmHeaderEbay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmHeaderEbay.Width = 36;
            // 
            // clmHeaderIdealo
            // 
            this.clmHeaderIdealo.Text = "Idealo";
            this.clmHeaderIdealo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmHeaderIdealo.Width = 67;
            // 
            // grpBoxIdealo
            // 
            this.grpBoxIdealo.Controls.Add(this.linkLabel2);
            this.grpBoxIdealo.Controls.Add(this.label2);
            this.grpBoxIdealo.Controls.Add(this.currencyEuroBox2);
            this.grpBoxIdealo.Location = new System.Drawing.Point(27, 306);
            this.grpBoxIdealo.Name = "grpBoxIdealo";
            this.grpBoxIdealo.Size = new System.Drawing.Size(383, 91);
            this.grpBoxIdealo.TabIndex = 4;
            this.grpBoxIdealo.TabStop = false;
            this.grpBoxIdealo.Text = "Idealo";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 54);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(68, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "<Platzhalter>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preis";
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
            this.grpBoxEbay.Controls.Add(this.linkLabel1);
            this.grpBoxEbay.Controls.Add(this.lblEbayPrice);
            this.grpBoxEbay.Controls.Add(this.cur);
            this.grpBoxEbay.Location = new System.Drawing.Point(27, 209);
            this.grpBoxEbay.Name = "grpBoxEbay";
            this.grpBoxEbay.Size = new System.Drawing.Size(383, 91);
            this.grpBoxEbay.TabIndex = 3;
            this.grpBoxEbay.TabStop = false;
            this.grpBoxEbay.Text = "Ebay";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 54);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<Platzhalter>";
            // 
            // lblEbayPrice
            // 
            this.lblEbayPrice.AutoSize = true;
            this.lblEbayPrice.Location = new System.Drawing.Point(3, 23);
            this.lblEbayPrice.Name = "lblEbayPrice";
            this.lblEbayPrice.Size = new System.Drawing.Size(30, 13);
            this.lblEbayPrice.TabIndex = 5;
            this.lblEbayPrice.Text = "Preis";
            // 
            // grpBoxAmazon
            // 
            this.grpBoxAmazon.Controls.Add(this.linkLblAmazon);
            this.grpBoxAmazon.Controls.Add(this.lblAmazonPrice);
            this.grpBoxAmazon.Controls.Add(this.curAmazonPrice);
            this.grpBoxAmazon.Location = new System.Drawing.Point(27, 112);
            this.grpBoxAmazon.Name = "grpBoxAmazon";
            this.grpBoxAmazon.Size = new System.Drawing.Size(383, 91);
            this.grpBoxAmazon.TabIndex = 2;
            this.grpBoxAmazon.TabStop = false;
            this.grpBoxAmazon.Text = "Amazon";
            // 
            // linkLblAmazon
            // 
            this.linkLblAmazon.AutoSize = true;
            this.linkLblAmazon.Location = new System.Drawing.Point(3, 54);
            this.linkLblAmazon.Name = "linkLblAmazon";
            this.linkLblAmazon.Size = new System.Drawing.Size(68, 13);
            this.linkLblAmazon.TabIndex = 3;
            this.linkLblAmazon.TabStop = true;
            this.linkLblAmazon.Text = "<Platzhalter>";
            // 
            // lblAmazonPrice
            // 
            this.lblAmazonPrice.AutoSize = true;
            this.lblAmazonPrice.Location = new System.Drawing.Point(3, 23);
            this.lblAmazonPrice.Name = "lblAmazonPrice";
            this.lblAmazonPrice.Size = new System.Drawing.Size(30, 13);
            this.lblAmazonPrice.TabIndex = 2;
            this.lblAmazonPrice.Text = "Preis";
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
            // progressBarParsing
            // 
            this.progressBarParsing.Location = new System.Drawing.Point(27, 453);
            this.progressBarParsing.Name = "progressBarParsing";
            this.progressBarParsing.Size = new System.Drawing.Size(383, 23);
            this.progressBarParsing.TabIndex = 6;
            // 
            // lvlProgress
            // 
            this.lvlProgress.AutoSize = true;
            this.lvlProgress.Location = new System.Drawing.Point(30, 437);
            this.lvlProgress.Name = "lvlProgress";
            this.lvlProgress.Size = new System.Drawing.Size(56, 13);
            this.lvlProgress.TabIndex = 7;
            this.lvlProgress.Text = "Fortschritt:";
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
            // txtSuche
            // 
            this.txtSuche.Location = new System.Drawing.Point(52, 24);
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.Size = new System.Drawing.Size(141, 20);
            this.txtSuche.TabIndex = 4;
            // 
            // currencyEuroBox2
            // 
            this.currencyEuroBox2.Location = new System.Drawing.Point(109, 20);
            this.currencyEuroBox2.Name = "currencyEuroBox2";
            this.currencyEuroBox2.Size = new System.Drawing.Size(100, 20);
            this.currencyEuroBox2.TabIndex = 4;
            this.currencyEuroBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cur
            // 
            this.cur.Location = new System.Drawing.Point(109, 20);
            this.cur.Name = "cur";
            this.cur.Size = new System.Drawing.Size(99, 20);
            this.cur.TabIndex = 4;
            this.cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // curAmazonPrice
            // 
            this.curAmazonPrice.Location = new System.Drawing.Point(109, 20);
            this.curAmazonPrice.Name = "curAmazonPrice";
            this.curAmazonPrice.Size = new System.Drawing.Size(100, 20);
            this.curAmazonPrice.TabIndex = 0;
            this.curAmazonPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmParsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 643);
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
            this.grpBoxIdealo.ResumeLayout(false);
            this.grpBoxIdealo.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader clmHeaderIdealo;
        private System.Windows.Forms.Label lblEan;
        private System.Windows.Forms.TextBox txtEan;
        private System.Windows.Forms.Label lvlArtikel;
        private System.Windows.Forms.TextBox txtArtikel;
        private System.Windows.Forms.GroupBox grpBoxEbay;
        private System.Windows.Forms.GroupBox grpBoxAmazon;
        private System.Windows.Forms.GroupBox grpBoxIdealo;
        private System.Windows.Forms.Label lblAmazonPrice;
        private CurrencyEuroBox curAmazonPrice;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
        private CurrencyEuroBox currencyEuroBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblEbayPrice;
        private CurrencyEuroBox cur;
        private System.Windows.Forms.LinkLabel linkLblAmazon;
        private System.Windows.Forms.Label lvlProgress;
        private System.Windows.Forms.ProgressBar progressBarParsing;
        private System.Windows.Forms.TextBox txtSuche;
        private System.Windows.Forms.Label lblSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAmazon;
        private System.ComponentModel.BackgroundWorker backgroundWorkerEbay;
        private System.ComponentModel.BackgroundWorker backgroundWorkerIdealo;
    }
}