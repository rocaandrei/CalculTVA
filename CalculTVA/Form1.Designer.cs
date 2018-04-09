namespace CalculTVA
{
    partial class Form1
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
            this.tbSumaTotalaFaraTVA = new System.Windows.Forms.TextBox();
            this.tbTaxaMembershipFaraTVA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSumaTotalaFaraTVA = new System.Windows.Forms.Label();
            this.b1CalculTotal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSumaCuDiscount = new System.Windows.Forms.Label();
            this.btCalculSumaCuDiscount = new System.Windows.Forms.Button();
            this.rbDiscount5 = new System.Windows.Forms.RadioButton();
            this.rbDiscount10 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.bCalculRate = new System.Windows.Forms.Button();
            this.labelSumaTotalaInRate = new System.Windows.Forms.Label();
            this.cb4Rate = new System.Windows.Forms.CheckBox();
            this.cb5Rate = new System.Windows.Forms.CheckBox();
            this.cb6Rate = new System.Windows.Forms.CheckBox();
            this.cb7Rate = new System.Windows.Forms.CheckBox();
            this.bReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti suma în euro fara TVA inclus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduceti taxa de Student Member fara TVA inclus:";
            // 
            // tbSumaTotalaFaraTVA
            // 
            this.tbSumaTotalaFaraTVA.Location = new System.Drawing.Point(331, 30);
            this.tbSumaTotalaFaraTVA.Name = "tbSumaTotalaFaraTVA";
            this.tbSumaTotalaFaraTVA.Size = new System.Drawing.Size(145, 20);
            this.tbSumaTotalaFaraTVA.TabIndex = 2;
            // 
            // tbTaxaMembershipFaraTVA
            // 
            this.tbTaxaMembershipFaraTVA.Location = new System.Drawing.Point(331, 56);
            this.tbTaxaMembershipFaraTVA.Name = "tbTaxaMembershipFaraTVA";
            this.tbTaxaMembershipFaraTVA.Size = new System.Drawing.Size(145, 20);
            this.tbTaxaMembershipFaraTVA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Euro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Euro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cost total:";
            // 
            // labelSumaTotalaFaraTVA
            // 
            this.labelSumaTotalaFaraTVA.AutoSize = true;
            this.labelSumaTotalaFaraTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumaTotalaFaraTVA.Location = new System.Drawing.Point(125, 85);
            this.labelSumaTotalaFaraTVA.Name = "labelSumaTotalaFaraTVA";
            this.labelSumaTotalaFaraTVA.Size = new System.Drawing.Size(64, 13);
            this.labelSumaTotalaFaraTVA.TabIndex = 7;
            this.labelSumaTotalaFaraTVA.Text = "pending...";
            // 
            // b1CalculTotal
            // 
            this.b1CalculTotal.Location = new System.Drawing.Point(547, 47);
            this.b1CalculTotal.Name = "b1CalculTotal";
            this.b1CalculTotal.Size = new System.Drawing.Size(75, 23);
            this.b1CalculTotal.TabIndex = 8;
            this.b1CalculTotal.Text = "Calculeaza";
            this.b1CalculTotal.UseVisualStyleBackColor = true;
            this.b1CalculTotal.Click += new System.EventHandler(this.b1CalculTotal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Aplică discount de:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cost cu discount:";
            // 
            // labelSumaCuDiscount
            // 
            this.labelSumaCuDiscount.AutoSize = true;
            this.labelSumaCuDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumaCuDiscount.Location = new System.Drawing.Point(429, 113);
            this.labelSumaCuDiscount.Name = "labelSumaCuDiscount";
            this.labelSumaCuDiscount.Size = new System.Drawing.Size(64, 13);
            this.labelSumaCuDiscount.TabIndex = 13;
            this.labelSumaCuDiscount.Text = "pending...";
            // 
            // btCalculSumaCuDiscount
            // 
            this.btCalculSumaCuDiscount.Location = new System.Drawing.Point(225, 109);
            this.btCalculSumaCuDiscount.Name = "btCalculSumaCuDiscount";
            this.btCalculSumaCuDiscount.Size = new System.Drawing.Size(75, 23);
            this.btCalculSumaCuDiscount.TabIndex = 14;
            this.btCalculSumaCuDiscount.Text = "Calculeaza";
            this.btCalculSumaCuDiscount.UseVisualStyleBackColor = true;
            this.btCalculSumaCuDiscount.Click += new System.EventHandler(this.btCalculSumaCuDiscount_Click);
            // 
            // rbDiscount5
            // 
            this.rbDiscount5.AutoSize = true;
            this.rbDiscount5.Location = new System.Drawing.Point(128, 113);
            this.rbDiscount5.Name = "rbDiscount5";
            this.rbDiscount5.Size = new System.Drawing.Size(39, 17);
            this.rbDiscount5.TabIndex = 15;
            this.rbDiscount5.Text = "5%";
            this.rbDiscount5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbDiscount5.UseVisualStyleBackColor = true;
            // 
            // rbDiscount10
            // 
            this.rbDiscount10.AutoSize = true;
            this.rbDiscount10.Location = new System.Drawing.Point(173, 113);
            this.rbDiscount10.Name = "rbDiscount10";
            this.rbDiscount10.Size = new System.Drawing.Size(45, 17);
            this.rbDiscount10.TabIndex = 16;
            this.rbDiscount10.Text = "10%";
            this.rbDiscount10.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbDiscount10.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sistem de plata in rate:";
            // 
            // bCalculRate
            // 
            this.bCalculRate.Location = new System.Drawing.Point(498, 144);
            this.bCalculRate.Name = "bCalculRate";
            this.bCalculRate.Size = new System.Drawing.Size(75, 23);
            this.bCalculRate.TabIndex = 22;
            this.bCalculRate.Text = "Calculeaza";
            this.bCalculRate.UseVisualStyleBackColor = true;
            this.bCalculRate.Click += new System.EventHandler(this.bCalculRate_Click);
            // 
            // labelSumaTotalaInRate
            // 
            this.labelSumaTotalaInRate.AutoSize = true;
            this.labelSumaTotalaInRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumaTotalaInRate.Location = new System.Drawing.Point(24, 184);
            this.labelSumaTotalaInRate.Name = "labelSumaTotalaInRate";
            this.labelSumaTotalaInRate.Size = new System.Drawing.Size(64, 13);
            this.labelSumaTotalaInRate.TabIndex = 23;
            this.labelSumaTotalaInRate.Text = "pending...";
            // 
            // cb4Rate
            // 
            this.cb4Rate.AutoSize = true;
            this.cb4Rate.Location = new System.Drawing.Point(190, 148);
            this.cb4Rate.Name = "cb4Rate";
            this.cb4Rate.Size = new System.Drawing.Size(58, 17);
            this.cb4Rate.TabIndex = 24;
            this.cb4Rate.Text = "4 Rate";
            this.cb4Rate.UseVisualStyleBackColor = true;
            // 
            // cb5Rate
            // 
            this.cb5Rate.AutoSize = true;
            this.cb5Rate.Location = new System.Drawing.Point(254, 148);
            this.cb5Rate.Name = "cb5Rate";
            this.cb5Rate.Size = new System.Drawing.Size(58, 17);
            this.cb5Rate.TabIndex = 25;
            this.cb5Rate.Text = "5 Rate";
            this.cb5Rate.UseVisualStyleBackColor = true;
            // 
            // cb6Rate
            // 
            this.cb6Rate.AutoSize = true;
            this.cb6Rate.Location = new System.Drawing.Point(318, 150);
            this.cb6Rate.Name = "cb6Rate";
            this.cb6Rate.Size = new System.Drawing.Size(58, 17);
            this.cb6Rate.TabIndex = 26;
            this.cb6Rate.Text = "6 Rate";
            this.cb6Rate.UseVisualStyleBackColor = true;
            // 
            // cb7Rate
            // 
            this.cb7Rate.AutoSize = true;
            this.cb7Rate.Location = new System.Drawing.Point(382, 150);
            this.cb7Rate.Name = "cb7Rate";
            this.cb7Rate.Size = new System.Drawing.Size(58, 17);
            this.cb7Rate.TabIndex = 27;
            this.cb7Rate.Text = "7 Rate";
            this.cb7Rate.UseVisualStyleBackColor = true;
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(27, 289);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(162, 23);
            this.bReset.TabIndex = 28;
            this.bReset.Text = "Reseteaza tot";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 341);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.cb7Rate);
            this.Controls.Add(this.cb6Rate);
            this.Controls.Add(this.cb5Rate);
            this.Controls.Add(this.cb4Rate);
            this.Controls.Add(this.labelSumaTotalaInRate);
            this.Controls.Add(this.bCalculRate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbDiscount10);
            this.Controls.Add(this.rbDiscount5);
            this.Controls.Add(this.btCalculSumaCuDiscount);
            this.Controls.Add(this.labelSumaCuDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.b1CalculTotal);
            this.Controls.Add(this.labelSumaTotalaFaraTVA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTaxaMembershipFaraTVA);
            this.Controls.Add(this.tbSumaTotalaFaraTVA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistem de plata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSumaTotalaFaraTVA;
        private System.Windows.Forms.TextBox tbTaxaMembershipFaraTVA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSumaTotalaFaraTVA;
        private System.Windows.Forms.Button b1CalculTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSumaCuDiscount;
        private System.Windows.Forms.Button btCalculSumaCuDiscount;
        private System.Windows.Forms.RadioButton rbDiscount10;
        protected System.Windows.Forms.RadioButton rbDiscount5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bCalculRate;
        private System.Windows.Forms.Label labelSumaTotalaInRate;
        private System.Windows.Forms.CheckBox cb4Rate;
        private System.Windows.Forms.CheckBox cb5Rate;
        private System.Windows.Forms.CheckBox cb6Rate;
        private System.Windows.Forms.CheckBox cb7Rate;
        private System.Windows.Forms.Button bReset;
    }
}