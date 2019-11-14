namespace AdminGirisi
{
    partial class SifreGuncelleme
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
            this.textBoxSifre1 = new System.Windows.Forms.TextBox();
            this.textBoxSifre2 = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.textBoxifade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEski = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Şifre Tekrar:";
            // 
            // textBoxSifre1
            // 
            this.textBoxSifre1.Location = new System.Drawing.Point(98, 67);
            this.textBoxSifre1.Name = "textBoxSifre1";
            this.textBoxSifre1.Size = new System.Drawing.Size(100, 20);
            this.textBoxSifre1.TabIndex = 2;
            // 
            // textBoxSifre2
            // 
            this.textBoxSifre2.Location = new System.Drawing.Point(98, 100);
            this.textBoxSifre2.Name = "textBoxSifre2";
            this.textBoxSifre2.Size = new System.Drawing.Size(100, 20);
            this.textBoxSifre2.TabIndex = 3;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(98, 159);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(75, 23);
            this.button_kaydet.TabIndex = 4;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // textBoxifade
            // 
            this.textBoxifade.Location = new System.Drawing.Point(98, 133);
            this.textBoxifade.Name = "textBoxifade";
            this.textBoxifade.Size = new System.Drawing.Size(100, 20);
            this.textBoxifade.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eski Şifre:";
            // 
            // textBoxEski
            // 
            this.textBoxEski.Location = new System.Drawing.Point(98, 37);
            this.textBoxEski.Name = "textBoxEski";
            this.textBoxEski.Size = new System.Drawing.Size(100, 20);
            this.textBoxEski.TabIndex = 9;
            // 
            // SifreGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 205);
            this.Controls.Add(this.textBoxEski);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxifade);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBoxSifre2);
            this.Controls.Add(this.textBoxSifre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SifreGuncelleme";
            this.Text = "SifreGuncelleme";
            this.Load += new System.EventHandler(this.SifreGuncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSifre1;
        private System.Windows.Forms.TextBox textBoxSifre2;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.TextBox textBoxifade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEski;
    }
}