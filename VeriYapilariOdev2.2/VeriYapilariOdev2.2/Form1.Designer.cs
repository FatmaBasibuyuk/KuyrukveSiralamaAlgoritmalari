namespace VeriYapilariOdev2._2
{
    partial class CalismaZamaniKiyaslamalari
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
            this.btnVeriUret = new System.Windows.Forms.Button();
            this.btnBubleSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVeriUret
            // 
            this.btnVeriUret.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVeriUret.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriUret.Location = new System.Drawing.Point(12, 12);
            this.btnVeriUret.Name = "btnVeriUret";
            this.btnVeriUret.Size = new System.Drawing.Size(340, 45);
            this.btnVeriUret.TabIndex = 0;
            this.btnVeriUret.Text = "Random Veri Üret";
            this.btnVeriUret.UseVisualStyleBackColor = false;
            this.btnVeriUret.Click += new System.EventHandler(this.btnVeriUret_Click);
            // 
            // btnBubleSort
            // 
            this.btnBubleSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBubleSort.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBubleSort.Location = new System.Drawing.Point(12, 63);
            this.btnBubleSort.Name = "btnBubleSort";
            this.btnBubleSort.Size = new System.Drawing.Size(155, 58);
            this.btnBubleSort.TabIndex = 1;
            this.btnBubleSort.Text = "Buble Sort";
            this.btnBubleSort.UseVisualStyleBackColor = false;
            this.btnBubleSort.Click += new System.EventHandler(this.btnBubleSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelectionSort.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectionSort.Location = new System.Drawing.Point(194, 63);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(158, 58);
            this.btnSelectionSort.TabIndex = 2;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = false;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInsertionSort.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsertionSort.Location = new System.Drawing.Point(12, 127);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(155, 55);
            this.btnInsertionSort.TabIndex = 3;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = false;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnQuickSort.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuickSort.Location = new System.Drawing.Point(194, 127);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(158, 55);
            this.btnQuickSort.TabIndex = 4;
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.UseVisualStyleBackColor = false;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHeapSort.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHeapSort.Location = new System.Drawing.Point(109, 188);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(155, 54);
            this.btnHeapSort.TabIndex = 5;
            this.btnHeapSort.Text = "Heap Sort";
            this.btnHeapSort.UseVisualStyleBackColor = false;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // CalismaZamaniKiyaslamalari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 245);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnBubleSort);
            this.Controls.Add(this.btnVeriUret);
            this.Name = "CalismaZamaniKiyaslamalari";
            this.Text = "Çalışma Zamanı Kıyaslamaları";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeriUret;
        private System.Windows.Forms.Button btnBubleSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnHeapSort;
    }
}

