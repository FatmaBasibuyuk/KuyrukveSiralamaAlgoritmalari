namespace VeriYapilariOdev2
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
            this.btnDairesel = new System.Windows.Forms.Button();
            this.btnOncelikli = new System.Windows.Forms.Button();
            this.btnElemanEkle = new System.Windows.Forms.Button();
            this.btnKiyas = new System.Windows.Forms.Button();
            this.btnKazanc = new System.Windows.Forms.Button();
            this.btnKiyas2 = new System.Windows.Forms.Button();
            this.btnKazanc2 = new System.Windows.Forms.Button();
            this.btnOncelikli2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDairesel
            // 
            this.btnDairesel.Location = new System.Drawing.Point(12, 118);
            this.btnDairesel.Name = "btnDairesel";
            this.btnDairesel.Size = new System.Drawing.Size(151, 50);
            this.btnDairesel.TabIndex = 0;
            this.btnDairesel.Text = "Dairesel Kuyruk";
            this.btnDairesel.UseVisualStyleBackColor = true;
            this.btnDairesel.Click += new System.EventHandler(this.btnDairesel_Click);
            // 
            // btnOncelikli
            // 
            this.btnOncelikli.Location = new System.Drawing.Point(169, 118);
            this.btnOncelikli.Name = "btnOncelikli";
            this.btnOncelikli.Size = new System.Drawing.Size(147, 50);
            this.btnOncelikli.TabIndex = 1;
            this.btnOncelikli.Text = "Öncelikli Kuyruk";
            this.btnOncelikli.UseVisualStyleBackColor = true;
            this.btnOncelikli.Click += new System.EventHandler(this.btnOncelikli_Click);
            // 
            // btnElemanEkle
            // 
            this.btnElemanEkle.Location = new System.Drawing.Point(169, 54);
            this.btnElemanEkle.Name = "btnElemanEkle";
            this.btnElemanEkle.Size = new System.Drawing.Size(125, 46);
            this.btnElemanEkle.TabIndex = 4;
            this.btnElemanEkle.Text = "Eleman Ekle";
            this.btnElemanEkle.UseVisualStyleBackColor = true;
            this.btnElemanEkle.Click += new System.EventHandler(this.btnElemanEkle_Click);
            // 
            // btnKiyas
            // 
            this.btnKiyas.Location = new System.Drawing.Point(58, 208);
            this.btnKiyas.Name = "btnKiyas";
            this.btnKiyas.Size = new System.Drawing.Size(151, 31);
            this.btnKiyas.TabIndex = 5;
            this.btnKiyas.Text = "Kıyas yap";
            this.btnKiyas.UseVisualStyleBackColor = true;
            this.btnKiyas.Click += new System.EventHandler(this.btnKiyas_Click);
            // 
            // btnKazanc
            // 
            this.btnKazanc.Location = new System.Drawing.Point(270, 208);
            this.btnKazanc.Name = "btnKazanc";
            this.btnKazanc.Size = new System.Drawing.Size(151, 31);
            this.btnKazanc.TabIndex = 6;
            this.btnKazanc.Text = "Ortalamalardaki Kazanç";
            this.btnKazanc.UseVisualStyleBackColor = true;
            this.btnKazanc.Click += new System.EventHandler(this.btnKazanc_Click);
            // 
            // btnKiyas2
            // 
            this.btnKiyas2.Location = new System.Drawing.Point(58, 262);
            this.btnKiyas2.Name = "btnKiyas2";
            this.btnKiyas2.Size = new System.Drawing.Size(151, 31);
            this.btnKiyas2.TabIndex = 7;
            this.btnKiyas2.Text = "Kıyas yap2";
            this.btnKiyas2.UseVisualStyleBackColor = true;
            this.btnKiyas2.Click += new System.EventHandler(this.btnKiyas2_Click);
            // 
            // btnKazanc2
            // 
            this.btnKazanc2.Location = new System.Drawing.Point(270, 262);
            this.btnKazanc2.Name = "btnKazanc2";
            this.btnKazanc2.Size = new System.Drawing.Size(151, 31);
            this.btnKazanc2.TabIndex = 8;
            this.btnKazanc2.Text = "Kazanç";
            this.btnKazanc2.UseVisualStyleBackColor = true;
            this.btnKazanc2.Click += new System.EventHandler(this.btnKazanc2_Click);
            // 
            // btnOncelikli2
            // 
            this.btnOncelikli2.Location = new System.Drawing.Point(322, 118);
            this.btnOncelikli2.Name = "btnOncelikli2";
            this.btnOncelikli2.Size = new System.Drawing.Size(138, 50);
            this.btnOncelikli2.TabIndex = 9;
            this.btnOncelikli2.Text = "Öncelikli Kuyruk";
            this.btnOncelikli2.UseVisualStyleBackColor = true;
            this.btnOncelikli2.Click += new System.EventHandler(this.btnOncelikli2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 327);
            this.Controls.Add(this.btnOncelikli2);
            this.Controls.Add(this.btnKazanc2);
            this.Controls.Add(this.btnKiyas2);
            this.Controls.Add(this.btnKazanc);
            this.Controls.Add(this.btnKiyas);
            this.Controls.Add(this.btnElemanEkle);
            this.Controls.Add(this.btnOncelikli);
            this.Controls.Add(this.btnDairesel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDairesel;
        private System.Windows.Forms.Button btnOncelikli;
        private System.Windows.Forms.Button btnElemanEkle;
        private System.Windows.Forms.Button btnKiyas;
        private System.Windows.Forms.Button btnKazanc;
        private System.Windows.Forms.Button btnKiyas2;
        private System.Windows.Forms.Button btnKazanc2;
        private System.Windows.Forms.Button btnOncelikli2;
    }
}

