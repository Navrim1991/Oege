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
            this.butOk = new System.Windows.Forms.Button();
            this.textSpaltenNummern = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEan = new System.Windows.Forms.TextBox();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // butOk
            // 
            this.butOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOk.Location = new System.Drawing.Point(309, 205);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(102, 31);
            this.butOk.TabIndex = 0;
            this.butOk.Text = "Ok";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // textSpaltenNummern
            // 
            this.textSpaltenNummern.Location = new System.Drawing.Point(12, 20);
            this.textSpaltenNummern.Name = "textSpaltenNummern";
            this.textSpaltenNummern.Size = new System.Drawing.Size(310, 26);
            this.textSpaltenNummern.TabIndex = 4;
            this.textSpaltenNummern.Text = "Bitte geben Sie den entsprechenden Spaltenbuchstaben an ein:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "EAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BESCHREIBUNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PREIS";
            // 
            // txtEan
            // 
            this.txtEan.Location = new System.Drawing.Point(194, 78);
            this.txtEan.MaxLength = 1;
            this.txtEan.Name = "txtEan";
            this.txtEan.Size = new System.Drawing.Size(100, 20);
            this.txtEan.TabIndex = 8;
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(194, 114);
            this.txtDiscription.MaxLength = 1;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(100, 20);
            this.txtDiscription.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(194, 152);
            this.txtPrice.MaxLength = 1;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // frmChooseColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 248);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.txtEan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSpaltenNummern);
            this.Controls.Add(this.butOk);
            this.Name = "frmChooseColumn";
            this.Text = "Form1";
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
    }
}