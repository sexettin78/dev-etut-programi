﻿namespace ogrencietutkayitsistemi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEtut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.cmbOgrtmen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtetutid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtogrenciid = new System.Windows.Forms.TextBox();
            this.btnetutver = new System.Windows.Forms.Button();
            this.lblogrenci = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEtut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mskSaat);
            this.groupBox1.Controls.Add(this.cmbOgrtmen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.cmbDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(381, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEtut
            // 
            this.btnEtut.Location = new System.Drawing.Point(120, 203);
            this.btnEtut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEtut.Name = "btnEtut";
            this.btnEtut.Size = new System.Drawing.Size(134, 34);
            this.btnEtut.TabIndex = 8;
            this.btnEtut.Text = "Etüt oluştur";
            this.btnEtut.UseVisualStyleBackColor = true;
            this.btnEtut.Click += new System.EventHandler(this.btnEtut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saat:";
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(82, 161);
            this.mskSaat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(248, 29);
            this.mskSaat.TabIndex = 6;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // cmbOgrtmen
            // 
            this.cmbOgrtmen.FormattingEnabled = true;
            this.cmbOgrtmen.Location = new System.Drawing.Point(82, 74);
            this.cmbOgrtmen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOgrtmen.Name = "cmbOgrtmen";
            this.cmbOgrtmen.Size = new System.Drawing.Size(248, 29);
            this.cmbOgrtmen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen:";
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(82, 119);
            this.mskTarih.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(248, 29);
            this.mskTarih.TabIndex = 2;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(82, 26);
            this.cmbDers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(248, 29);
            this.cmbDers.TabIndex = 1;
            this.cmbDers.SelectedIndexChanged += new System.EventHandler(this.cmbDers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtetutid);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtogrenciid);
            this.groupBox2.Controls.Add(this.btnetutver);
            this.groupBox2.Controls.Add(this.lblogrenci);
            this.groupBox2.Location = new System.Drawing.Point(412, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(311, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtetutid
            // 
            this.txtetutid.Enabled = false;
            this.txtetutid.Location = new System.Drawing.Point(79, 19);
            this.txtetutid.Name = "txtetutid";
            this.txtetutid.Size = new System.Drawing.Size(143, 29);
            this.txtetutid.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Etüt id:";
            // 
            // txtogrenciid
            // 
            this.txtogrenciid.Location = new System.Drawing.Point(79, 54);
            this.txtogrenciid.Name = "txtogrenciid";
            this.txtogrenciid.Size = new System.Drawing.Size(143, 29);
            this.txtogrenciid.TabIndex = 10;
            // 
            // btnetutver
            // 
            this.btnetutver.Location = new System.Drawing.Point(79, 93);
            this.btnetutver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnetutver.Name = "btnetutver";
            this.btnetutver.Size = new System.Drawing.Size(134, 34);
            this.btnetutver.TabIndex = 9;
            this.btnetutver.Text = "Etüt ver";
            this.btnetutver.UseVisualStyleBackColor = true;
            this.btnetutver.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblogrenci
            // 
            this.lblogrenci.AutoSize = true;
            this.lblogrenci.Location = new System.Drawing.Point(5, 57);
            this.lblogrenci.Name = "lblogrenci";
            this.lblogrenci.Size = new System.Drawing.Size(68, 21);
            this.lblogrenci.TabIndex = 1;
            this.lblogrenci.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(2, 248);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(746, 420);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(747, 670);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEtut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.ComboBox cmbOgrtmen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnetutver;
        private System.Windows.Forms.Label lblogrenci;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtogrenciid;
        private System.Windows.Forms.TextBox txtetutid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}

