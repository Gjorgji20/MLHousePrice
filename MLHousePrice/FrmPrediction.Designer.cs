namespace MLHousePrice
{
    partial class FrmPrediction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.btnPredictPrice = new System.Windows.Forms.Button();
            this.lblP = new System.Windows.Forms.Label();
            this.tbCreditYear = new System.Windows.Forms.TextBox();
            this.lblCreditYear = new System.Windows.Forms.Label();
            this.lblCreditAmount = new System.Windows.Forms.Label();
            this.lblCreditAmount1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbtnPredictInstallment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(86, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.label2.Location = new System.Drawing.Point(76, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.label3.Location = new System.Drawing.Point(46, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Material";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(152, 201);
            this.tbSize.Margin = new System.Windows.Forms.Padding(4);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(217, 22);
            this.tbSize.TabIndex = 3;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(152, 247);
            this.tbYear.Margin = new System.Windows.Forms.Padding(4);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(217, 22);
            this.tbYear.TabIndex = 4;
            // 
            // cbMaterial
            // 
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Items.AddRange(new object[] {
            "Gable",
            "Hip",
            "Mansard"});
            this.cbMaterial.Location = new System.Drawing.Point(152, 299);
            this.cbMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(217, 24);
            this.cbMaterial.TabIndex = 5;
            // 
            // btnPredictPrice
            // 
            this.btnPredictPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnPredictPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredictPrice.ForeColor = System.Drawing.Color.White;
            this.btnPredictPrice.Location = new System.Drawing.Point(152, 368);
            this.btnPredictPrice.Margin = new System.Windows.Forms.Padding(4);
            this.btnPredictPrice.Name = "btnPredictPrice";
            this.btnPredictPrice.Size = new System.Drawing.Size(219, 43);
            this.btnPredictPrice.TabIndex = 6;
            this.btnPredictPrice.Text = "Price Prediction";
            this.btnPredictPrice.UseVisualStyleBackColor = false;
            this.btnPredictPrice.Click += new System.EventHandler(this.btnPredictPrice_Click);
            // 
            // lblP
            // 
            this.lblP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblP.AutoSize = true;
            this.lblP.BackColor = System.Drawing.Color.White;
            this.lblP.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblP.Location = new System.Drawing.Point(41, 121);
            this.lblP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(396, 49);
            this.lblP.TabIndex = 7;
            this.lblP.Text = "Getting Credit Amount";
            this.lblP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbCreditYear
            // 
            this.tbCreditYear.Location = new System.Drawing.Point(648, 300);
            this.tbCreditYear.Margin = new System.Windows.Forms.Padding(4);
            this.tbCreditYear.Name = "tbCreditYear";
            this.tbCreditYear.Size = new System.Drawing.Size(217, 22);
            this.tbCreditYear.TabIndex = 8;
            // 
            // lblCreditYear
            // 
            this.lblCreditYear.AutoSize = true;
            this.lblCreditYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblCreditYear.Location = new System.Drawing.Point(511, 301);
            this.lblCreditYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditYear.Name = "lblCreditYear";
            this.lblCreditYear.Size = new System.Drawing.Size(124, 24);
            this.lblCreditYear.TabIndex = 9;
            this.lblCreditYear.Text = "Year of Credit";
            // 
            // lblCreditAmount
            // 
            this.lblCreditAmount.AutoSize = true;
            this.lblCreditAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblCreditAmount.Location = new System.Drawing.Point(514, 253);
            this.lblCreditAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditAmount.Name = "lblCreditAmount";
            this.lblCreditAmount.Size = new System.Drawing.Size(124, 24);
            this.lblCreditAmount.TabIndex = 10;
            this.lblCreditAmount.Text = "Total Amount";
            // 
            // lblCreditAmount1
            // 
            this.lblCreditAmount1.AutoSize = true;
            this.lblCreditAmount1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditAmount1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblCreditAmount1.Location = new System.Drawing.Point(648, 253);
            this.lblCreditAmount1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditAmount1.Name = "lblCreditAmount1";
            this.lblCreditAmount1.Size = new System.Drawing.Size(0, 24);
            this.lblCreditAmount1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.label4.Location = new System.Drawing.Point(492, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(526, 49);
            this.label4.TabIndex = 13;
            this.label4.Text = "Getting Installment per month";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnbtnPredictInstallment
            // 
            this.btnbtnPredictInstallment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnbtnPredictInstallment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbtnPredictInstallment.ForeColor = System.Drawing.Color.White;
            this.btnbtnPredictInstallment.Location = new System.Drawing.Point(646, 368);
            this.btnbtnPredictInstallment.Margin = new System.Windows.Forms.Padding(4);
            this.btnbtnPredictInstallment.Name = "btnbtnPredictInstallment";
            this.btnbtnPredictInstallment.Size = new System.Drawing.Size(219, 69);
            this.btnbtnPredictInstallment.TabIndex = 12;
            this.btnbtnPredictInstallment.Text = "Installment Prediction";
            this.btnbtnPredictInstallment.UseVisualStyleBackColor = false;
            this.btnbtnPredictInstallment.Click += new System.EventHandler(this.btnbtnPredictInstallment_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.label5.Location = new System.Drawing.Point(537, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 49);
            this.label5.TabIndex = 13;
            this.label5.Text = "Getting Installment";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.label6.Location = new System.Drawing.Point(300, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 58);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prediction Page";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmPrediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnbtnPredictInstallment);
            this.Controls.Add(this.lblCreditAmount1);
            this.Controls.Add(this.lblCreditAmount);
            this.Controls.Add(this.lblCreditYear);
            this.Controls.Add(this.tbCreditYear);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.btnPredictPrice);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrediction";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Button btnPredictPrice;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox tbCreditYear;
        private System.Windows.Forms.Label lblCreditYear;
        private System.Windows.Forms.Label lblCreditAmount;
        private System.Windows.Forms.Label lblCreditAmount1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnbtnPredictInstallment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

