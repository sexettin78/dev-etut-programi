namespace ogrencietutkayitsistemi
{
    partial class OGRETMEN
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
            this.btnogretmenkaydet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.txtogretmensoyad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtogretmenad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(14, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnogretmenkaydet
            // 
            this.btnogretmenkaydet.Location = new System.Drawing.Point(297, 39);
            this.btnogretmenkaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnogretmenkaydet.Name = "btnogretmenkaydet";
            this.btnogretmenkaydet.Size = new System.Drawing.Size(143, 34);
            this.btnogretmenkaydet.TabIndex = 29;
            this.btnogretmenkaydet.Text = "Öğretmen Ekle";
            this.btnogretmenkaydet.UseVisualStyleBackColor = true;
            this.btnogretmenkaydet.Click += new System.EventHandler(this.btnogretmenkaydet_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(481, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Ders:";
            // 
            // cmbders
            // 
            this.cmbders.FormattingEnabled = true;
            this.cmbders.Location = new System.Drawing.Point(513, 13);
            this.cmbders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(190, 21);
            this.cmbders.TabIndex = 27;
            // 
            // txtogretmensoyad
            // 
            this.txtogretmensoyad.Location = new System.Drawing.Point(282, 12);
            this.txtogretmensoyad.Name = "txtogretmensoyad";
            this.txtogretmensoyad.Size = new System.Drawing.Size(190, 20);
            this.txtogretmensoyad.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Soyad:";
            // 
            // txtogretmenad
            // 
            this.txtogretmenad.Location = new System.Drawing.Point(40, 12);
            this.txtogretmenad.Name = "txtogretmenad";
            this.txtogretmenad.Size = new System.Drawing.Size(190, 20);
            this.txtogretmenad.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Ad:";
            // 
            // OGRETMEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(713, 469);
            this.Controls.Add(this.btnogretmenkaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtogretmenad);
            this.Controls.Add(this.cmbders);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtogretmensoyad);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "OGRETMEN";
            this.Text = "OGRETMEN";
            this.Load += new System.EventHandler(this.OGRETMEN_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnogretmenkaydet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.TextBox txtogretmensoyad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtogretmenad;
        private System.Windows.Forms.Label label13;
    }
}