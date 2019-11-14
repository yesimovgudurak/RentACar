using AdminGirisi.ORM.Context;
using AdminGirisi.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGirisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        ProjectContext db = new ProjectContext();

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_Sifre1.Text == txt_Sifre2.Text)
            {
                Musteriler musteriler = new Musteriler();
                musteriler.TC = txt_Tc.Text;
                musteriler.Adı = txt_Ad.Text;
                musteriler.Soyadı = txt_Soyad.Text;
                musteriler.Telefon = txt_TelefonNo.Text;
                musteriler.EhliyetNo = txt_EhliyetNo.Text;
                musteriler.Email = txt_Email.Text;
                musteriler.Adres = txt_Adres.Text;
                musteriler.Sifre = txt_Sifre1.Text;

                db.Customers.Add(musteriler);
                db.SaveChanges();

                txt_Tc.Text = string.Empty;
                txt_Ad.Text = string.Empty;
                txt_Soyad.Text = string.Empty;
                txt_TelefonNo.Text = string.Empty;
                txt_EhliyetNo.Text = string.Empty;
                txt_Email.Text = string.Empty;
                txt_Adres.Text = string.Empty;
                txt_Sifre1.Text = string.Empty;

                MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi.");

                SistemGiris sg = new SistemGiris();
                sg.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Oluşturduğunuz şifrelerin doğruluğundan emin olun.");

            }

        }

       
    }
}
