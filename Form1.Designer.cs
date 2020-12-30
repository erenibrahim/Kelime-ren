namespace KelimeOgren
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_tr = new System.Windows.Forms.TextBox();
            this.textBox_ing = new System.Windows.Forms.TextBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_degistir = new System.Windows.Forms.Button();
            this.labeltr = new System.Windows.Forms.Label();
            this.labeling = new System.Windows.Forms.Label();
            this.textBox_d1 = new System.Windows.Forms.TextBox();
            this.textBox_d2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ara = new System.Windows.Forms.Button();
            this.textBox_ara = new System.Windows.Forms.TextBox();
            this.textBox_known = new System.Windows.Forms.TextBox();
            this.button_add_known = new System.Windows.Forms.Button();
            this.button_all = new System.Windows.Forms.Button();
            this.button_known = new System.Windows.Forms.Button();
            this.button_totalLearned = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_tr
            // 
            this.textBox_tr.Location = new System.Drawing.Point(528, 48);
            this.textBox_tr.Name = "textBox_tr";
            this.textBox_tr.Size = new System.Drawing.Size(100, 20);
            this.textBox_tr.TabIndex = 1;
            // 
            // textBox_ing
            // 
            this.textBox_ing.Location = new System.Drawing.Point(528, 89);
            this.textBox_ing.Name = "textBox_ing";
            this.textBox_ing.Size = new System.Drawing.Size(100, 20);
            this.textBox_ing.TabIndex = 2;
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(518, 191);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(100, 23);
            this.button_ekle.TabIndex = 3;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(518, 231);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(100, 23);
            this.button_sil.TabIndex = 4;
            this.button_sil.Text = "SİL";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_degistir
            // 
            this.button_degistir.Location = new System.Drawing.Point(518, 269);
            this.button_degistir.Name = "button_degistir";
            this.button_degistir.Size = new System.Drawing.Size(100, 23);
            this.button_degistir.TabIndex = 5;
            this.button_degistir.Text = "DEĞİŞTİR";
            this.button_degistir.UseVisualStyleBackColor = true;
            this.button_degistir.Click += new System.EventHandler(this.button_degistir_Click);
            // 
            // labeltr
            // 
            this.labeltr.AutoSize = true;
            this.labeltr.Location = new System.Drawing.Point(471, 51);
            this.labeltr.Name = "labeltr";
            this.labeltr.Size = new System.Drawing.Size(51, 13);
            this.labeltr.TabIndex = 7;
            this.labeltr.Text = "TÜRKÇE";
            // 
            // labeling
            // 
            this.labeling.AutoSize = true;
            this.labeling.Location = new System.Drawing.Point(463, 92);
            this.labeling.Name = "labeling";
            this.labeling.Size = new System.Drawing.Size(59, 13);
            this.labeling.TabIndex = 8;
            this.labeling.Text = "İNGİLİZCE";
            // 
            // textBox_d1
            // 
            this.textBox_d1.Location = new System.Drawing.Point(464, 138);
            this.textBox_d1.Name = "textBox_d1";
            this.textBox_d1.Size = new System.Drawing.Size(100, 20);
            this.textBox_d1.TabIndex = 9;
            // 
            // textBox_d2
            // 
            this.textBox_d2.Location = new System.Drawing.Point(586, 138);
            this.textBox_d2.Name = "textBox_d2";
            this.textBox_d2.Size = new System.Drawing.Size(100, 20);
            this.textBox_d2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "DEĞİŞTİR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "-";
            // 
            // button_ara
            // 
            this.button_ara.Location = new System.Drawing.Point(141, 12);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(100, 23);
            this.button_ara.TabIndex = 13;
            this.button_ara.Text = "ARA";
            this.button_ara.UseVisualStyleBackColor = true;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // textBox_ara
            // 
            this.textBox_ara.Location = new System.Drawing.Point(35, 12);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.Size = new System.Drawing.Size(100, 20);
            this.textBox_ara.TabIndex = 14;
            // 
            // textBox_known
            // 
            this.textBox_known.Location = new System.Drawing.Point(443, 327);
            this.textBox_known.Name = "textBox_known";
            this.textBox_known.Size = new System.Drawing.Size(100, 20);
            this.textBox_known.TabIndex = 15;
            // 
            // button_add_known
            // 
            this.button_add_known.Location = new System.Drawing.Point(558, 325);
            this.button_add_known.Name = "button_add_known";
            this.button_add_known.Size = new System.Drawing.Size(129, 23);
            this.button_add_known.TabIndex = 16;
            this.button_add_known.Text = "BİLİNENLERE EKLE";
            this.button_add_known.UseVisualStyleBackColor = true;
            this.button_add_known.Click += new System.EventHandler(this.button_add_known_Click);
            // 
            // button_all
            // 
            this.button_all.Location = new System.Drawing.Point(247, 12);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(69, 23);
            this.button_all.TabIndex = 17;
            this.button_all.Text = "HEPSİ";
            this.button_all.UseVisualStyleBackColor = true;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // button_known
            // 
            this.button_known.Location = new System.Drawing.Point(322, 12);
            this.button_known.Name = "button_known";
            this.button_known.Size = new System.Drawing.Size(85, 23);
            this.button_known.TabIndex = 18;
            this.button_known.Text = "BİLİNENLER";
            this.button_known.UseVisualStyleBackColor = true;
            this.button_known.Click += new System.EventHandler(this.button_known_Click);
            // 
            // button_totalLearned
            // 
            this.button_totalLearned.Location = new System.Drawing.Point(413, 12);
            this.button_totalLearned.Name = "button_totalLearned";
            this.button_totalLearned.Size = new System.Drawing.Size(130, 23);
            this.button_totalLearned.TabIndex = 19;
            this.button_totalLearned.Text = "TOPLAM ÖĞRENİLEN";
            this.button_totalLearned.UseVisualStyleBackColor = true;
            this.button_totalLearned.Click += new System.EventHandler(this.button_totalLearned_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 368);
            this.Controls.Add(this.button_totalLearned);
            this.Controls.Add(this.button_known);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.button_add_known);
            this.Controls.Add(this.textBox_known);
            this.Controls.Add(this.textBox_ara);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_d2);
            this.Controls.Add(this.textBox_d1);
            this.Controls.Add(this.labeling);
            this.Controls.Add(this.labeltr);
            this.Controls.Add(this.button_degistir);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.textBox_ing);
            this.Controls.Add(this.textBox_tr);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_tr;
        private System.Windows.Forms.TextBox textBox_ing;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_degistir;
        private System.Windows.Forms.Label labeltr;
        private System.Windows.Forms.Label labeling;
        private System.Windows.Forms.TextBox textBox_d1;
        private System.Windows.Forms.TextBox textBox_d2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.TextBox textBox_ara;
        private System.Windows.Forms.TextBox textBox_known;
        private System.Windows.Forms.Button button_add_known;
        private System.Windows.Forms.Button button_all;
        private System.Windows.Forms.Button button_known;
        private System.Windows.Forms.Button button_totalLearned;
    }
}

