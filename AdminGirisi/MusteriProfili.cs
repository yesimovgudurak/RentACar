using AdminGirisi.ORM.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGirisi.ORM.Entity
{
    public partial class MusteriProfili : Form
    {
        ProjectContext db = new ProjectContext();
        int mid;

        public MusteriProfili()
        {
            InitializeComponent();
        }
        //public MusteriProfili()
        //{
        //    InitializeComponent();

        //    mid = Convert.ToInt32(SistemGiris.veri);

        //    List<Musteriler> m = new List<Musteriler>();
        //    m = db.Customers.Where(x => x.ID == mid).ToList();

        //    foreach (Musteriler item in m)
        //    {
        //        textBox_Tc.Text = item.TC;
        //        textBox_Ad.Text = item.Adı;
        //        textBox_Soyad.Text = item.Soyadı;
        //        textBox_tel.Text = item.Telefon;
        //        textBox_eno.Text = item.EhliyetNo;
        //        textBox_email.Text = item.Email;
        //        textBox_adres.Text = item.Adres;
        //    }



        //}

        public void Goster()
        {
            

            mid = Convert.ToInt32(SistemGiris.veri);

          
            updated = db.Customers.Find(mid);

            
                textBox_Tc.Text = updated.TC;
                textBox_Ad.Text = updated.Adı;
                textBox_Soyad.Text = updated.Soyadı;
                textBox_tel.Text = updated.Telefon;
                textBox_eno.Text = updated.EhliyetNo;
                textBox_email.Text = updated.Email;
                textBox_adres.Text = updated.Adres;
           



        }

        Musteriler updated;
        public int id;
        public void SinifDoldur()
        {
            updated = db.Customers.Find(id);
        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            updated.TC = textBox_Tc.Text;
            updated.Adı = textBox_Ad.Text;
            updated.Soyadı = textBox_Soyad.Text;
            updated.Telefon = textBox_tel.Text;
            updated.EhliyetNo = textBox_eno.Text;
            updated.Email= textBox_email.Text;
            updated.Adres = (textBox_adres.Text);
            
            db.Entry(db.Customers.Find(updated.ID)).CurrentValues.SetValues(updated);
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirildi.");

    
            
        }

        private void buttonHSil_Click(object sender, EventArgs e)
        {



            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Hesabınızı silmek istediğinizden emin misiniz?","Uyarı", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Musteriler deleted = db.Customers.Find(updated.ID);
                db.Customers.Remove(deleted);
                db.SaveChanges();
                MessageBox.Show("Silme işlemi gerçekleştirildi.");

            }
            else
            {
               
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreGuncelleme sfrg = new SifreGuncelleme();
            sfrg.id = mid;
            sfrg.Show();

        }

        private void MusteriProfili_Load(object sender, EventArgs e)
        {
            Goster();
        }
    }
}
