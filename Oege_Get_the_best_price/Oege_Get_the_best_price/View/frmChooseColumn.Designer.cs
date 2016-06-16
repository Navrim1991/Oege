namespace Oege_Get_the_best_price.View
{
    partial class frmChooseColumn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseColumn));
            this.butOk = new System.Windows.Forms.Button();
            this.textSpaltenNummern = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEan = new System.Windows.Forms.TextBox();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtCurrencyConversion = new Currency_Control.CurrencyControl();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butOk
            // 
            this.butOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butOk.Location = new System.Drawing.Point(309, 253);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(102, 31);
            this.butOk.TabIndex = 0;
            this.butOk.Text = "Ok";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // textSpaltenNummern
            // 
            this.textSpaltenNummern.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpaltenNummern.Location = new System.Drawing.Point(12, 20);
            this.textSpaltenNummern.Name = "textSpaltenNummern";
            this.textSpaltenNummern.Size = new System.Drawing.Size(267, 42);
            this.textSpaltenNummern.TabIndex = 4;
            this.textSpaltenNummern.Text = "Bitte geben Sie den entsprechenden Spaltenbuchstaben an ein:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "EAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "BESCHREIBUNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "PREIS";
            // 
            // txtEan
            // 
            this.txtEan.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEan.Location = new System.Drawing.Point(194, 77);
            this.txtEan.MaxLength = 1;
            this.txtEan.Multiline = true;
            this.txtEan.Name = "txtEan";
            this.txtEan.Size = new System.Drawing.Size(100, 30);
            this.txtEan.TabIndex = 8;
            // 
            // txtDiscription
            // 
            this.txtDiscription.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscription.Location = new System.Drawing.Point(194, 114);
            this.txtDiscription.MaxLength = 3;
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(100, 32);
            this.txtDiscription.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(194, 152);
            this.txtPrice.MaxLength = 1;
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 30);
            this.txtPrice.TabIndex = 10;
            // 
            // txtCurrencyConversion
            // 
            this.txtCurrencyConversion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyConversion.Location = new System.Drawing.Point(194, 188);
            this.txtCurrencyConversion.Multiline = true;
            this.txtCurrencyConversion.Name = "txtCurrencyConversion";
            this.txtCurrencyConversion.Size = new System.Drawing.Size(100, 31);
            this.txtCurrencyConversion.TabIndex = 11;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(12, 188);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(164, 16);
            this.lblCurrency.TabIndex = 12;
            this.lblCurrency.Text = "WÄRUNGSUMRECHNUNG";
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butCancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butCancel.Location = new System.Drawing.Point(201, 253);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(102, 31);
            this.butCancel.TabIndex = 13;
            this.butCancel.Text = "Abbrechen";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // frmChooseColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 302);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.txtCurrencyConversion);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.txtEan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSpaltenNummern);
            this.Controls.Add(this.butOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChooseColumn";
            this.Text = "Spalten Auswählen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChooseColumn_FormClosing);
            this.Load += new System.EventHandler(this.frmChooseColumn_Load);
            this.Shown += new System.EventHandler(this.frmChooseColumn_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Label textSpaltenNummern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEan;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Currency_Control.CurrencyControl txtCurrencyConversion;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Button butCancel;
    }
}