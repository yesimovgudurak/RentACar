namespace AdminGirisi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxaktiflik = new System.Windows.Forms.ComboBox();
            this.lbl_Aktif = new System.Windows.Forms.Label();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.listViewAraba = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxyakit = new System.Windows.Forms.ComboBox();
            this.comboBoxvites = new System.Windows.Forms.ComboBox();
            this.comboBoxarac = new System.Windows.Forms.ComboBox();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Plaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxaktiflik);
            this.groupBox1.Controls.Add(this.lbl_Aktif);
            this.groupBox1.Controls.Add(this.btn_Guncelle);
            this.groupBox1.Controls.Add(this.btn_Sil);
            this.groupBox1.Controls.Add(this.listViewAraba);
            this.groupBox1.Controls.Add(this.comboBoxyakit);
            this.groupBox1.Controls.Add(this.comboBoxvites);
            this.groupBox1.Controls.Add(this.comboBoxarac);
            this.groupBox1.Controls.Add(this.txt_Fiyat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_Kaydet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Model);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Marka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Plaka);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 255);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Paneli";
            // 
            // comboBoxaktiflik
            // 
            this.comboBoxaktiflik.FormattingEnabled = true;
            this.comboBoxaktiflik.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBoxaktiflik.Location = new System.Drawing.Point(83, 208);
            this.comboBoxaktiflik.Name = "comboBoxaktiflik";
            this.comboBoxaktiflik.Size = new System.Drawing.Size(121, 21);
            this.comboBoxaktiflik.TabIndex = 21;
            // 
            // lbl_Aktif
            // 
            this.lbl_Aktif.AutoSize = true;
            this.lbl_Aktif.Location = new System.Drawing.Point(6, 216);
            this.lbl_Aktif.Name = "lbl_Aktif";
            this.lbl_Aktif.Size = new System.Drawing.Size(45, 13);
            this.lbl_Aktif.TabIndex = 20;
            this.lbl_Aktif.Text = "Aktif Mi:";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(834, 100);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 19;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(834, 59);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 18;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // listViewAraba
            // 
            this.listViewAraba.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9});
            this.listViewAraba.FullRowSelect = true;
            this.listViewAraba.Location = new System.Drawing.Point(256, 19);
            this.listViewAraba.Name = "listViewAraba";
            this.listViewAraba.Size = new System.Drawing.Size(556, 185);
            this.listViewAraba.TabIndex = 17;
            this.listViewAraba.UseCompatibleStateImageBehavior = false;
            this.listViewAraba.View = System.Windows.Forms.View.Details;
            this.listViewAraba.DoubleClick += new System.EventHandler(this.listViewAraba_DoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PlakaNo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Marka";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "AraçTipi";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vites";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "YakitTipi";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fiyat";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "AktifMi";
            // 
            // comboBoxyakit
            // 
            this.comboBoxyakit.FormattingEnabled = true;
            this.comboBoxyakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "LPG"});
            this.comboBoxyakit.Location = new System.Drawing.Point(83, 157);
            this.comboBoxyakit.Name = "comboBoxyakit";
            this.comboBoxyakit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxyakit.TabIndex = 16;
            // 
            // comboBoxvites
            // 
            this.comboBoxvites.FormattingEnabled = true;
            this.comboBoxvites.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.comboBoxvites.Location = new System.Drawing.Point(83, 130);
            this.comboBoxvites.Name = "comboBoxvites";
            this.comboBoxvites.Size = new System.Drawing.Size(121, 21);
            this.comboBoxvites.TabIndex = 15;
            // 
            // comboBoxarac
            // 
            this.comboBoxarac.FormattingEnabled = true;
            this.comboBoxarac.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback",
            "Station wagon",
            "SUV"});
            this.comboBoxarac.Location = new System.Drawing.Point(83, 103);
            this.comboBoxarac.Name = "comboBoxarac";
            this.comboBoxarac.Size = new System.Drawing.Size(121, 21);
            this.comboBoxarac.TabIndex = 14;
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(83, 184);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(121, 20);
            this.txt_Fiyat.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fiyat:";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(105, 233);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 12;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Yakıt Tipi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Vites:";
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(83, 77);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(121, 20);
            this.txt_Model.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Araç Tipi:";
            // 
            // txt_Marka
            // 
            this.txt_Marka.Location = new System.Drawing.Point(83, 51);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(121, 20);
            this.txt_Marka.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaka No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model:";
            // 
            // txt_Plaka
            // 
            this.txt_Plaka.Location = new System.Drawing.Point(83, 27);
            this.txt_Plaka.Name = "txt_Plaka";
            this.txt_Plaka.Size = new System.Drawing.Size(121, 20);
            this.txt_Plaka.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 444);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Plaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxarac;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxyakit;
        private System.Windows.Forms.ComboBox comboBoxvites;
        private System.Windows.Forms.ListView listViewAraba;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.ComboBox comboBoxaktiflik;
        private System.Windows.Forms.Label lbl_Aktif;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}