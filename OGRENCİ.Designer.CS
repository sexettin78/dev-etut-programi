namespace ogrencietutkayitsistemi
{
    partial class OGRENCİ
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrtelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnogrenciekle = new System.Windows.Forms.Button();
            this.ogrmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ogrsinif = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ogrsoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ograd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 466);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // ogrtelefon
            // 
            this.ogrtelefon.Location = new System.Drawing.Point(294, 9);
            this.ogrtelefon.Mask = "(999) 000-0000";
            this.ogrtelefon.Name = "ogrtelefon";
            this.ogrtelefon.Size = new System.Drawing.Size(143, 20);
            this.ogrtelefon.TabIndex = 37;
            // 
            // btnogrenciekle
            // 
            this.btnogrenciekle.Location = new System.Drawing.Point(493, 29);
            this.btnogrenciekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnogrenciekle.Name = "btnogrenciekle";
            this.btnogrenciekle.Size = new System.Drawing.Size(143, 34);
            this.btnogrenciekle.TabIndex = 36;
            this.btnogrenciekle.Text = "Öğrenci Ekle";
            this.btnogrenciekle.UseVisualStyleBackColor = true;
            this.btnogrenciekle.Click += new System.EventHandler(this.btnogrenciekle_Click);
            // 
            // ogrmail
            // 
            this.ogrmail.Location = new System.Drawing.Point(294, 42);
            this.ogrmail.Name = "ogrmail";
            this.ogrmail.Size = new System.Drawing.Size(143, 20);
            this.ogrmail.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Telefon:";
            // 
            // ogrsinif
            // 
            this.ogrsinif.Location = new System.Drawing.Point(73, 75);
            this.ogrsinif.Name = "ogrsinif";
            this.ogrsinif.Size = new System.Drawing.Size(143, 20);
            this.ogrsinif.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Sınıf:";
            // 
            // ogrsoyad
            // 
            this.ogrsoyad.Location = new System.Drawing.Point(73, 43);
            this.ogrsoyad.Name = "ogrsoyad";
            this.ogrsoyad.Size = new System.Drawing.Size(143, 20);
            this.ogrsoyad.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Soyad:";
            // 
            // ograd
            // 
            this.ograd.Location = new System.Drawing.Point(73, 12);
            this.ograd.Name = "ograd";
            this.ograd.Size = new System.Drawing.Size(143, 20);
            this.ograd.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ad:";
            // 
            // OGRENCİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(676, 566);
            this.Controls.Add(this.ogrtelefon);
            this.Controls.Add(this.btnogrenciekle);
            this.Controls.Add(this.ogrmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ogrsinif);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ogrsoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ograd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "OGRENCİ";
            this.Text = "OGRENCİ";
            this.Load += new System.EventHandler(this.OGRENCİ_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox ogrtelefon;
        private System.Windows.Forms.Button btnogrenciekle;
        private System.Windows.Forms.TextBox ogrmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ogrsinif;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ogrsoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ograd;
        private System.Windows.Forms.Label label6;
    }
}