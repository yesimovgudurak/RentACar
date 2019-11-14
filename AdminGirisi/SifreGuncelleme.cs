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
    public partial class SifreGuncelleme : Form
    {
        ProjectContext db = new ProjectContext();

        public SifreGuncelleme()
        {
            InitializeComponent();
        }
        public int id;
        public void SinifDoldur()
        {
            updated = db.Customers.Find(id);
        }

        private void SifreGuncelleme_Load(object sender, EventArgs e)
        {
            SinifDoldur();
            Random rastgele = new Random();
            string ifade = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZXWQ1234567890";
            string uret = "";
            for (int i = 0; i < 6; i++)
            {
                uret += ifade[rastgele.Next(ifade.Length)];
            }
            label3.Text = uret.ToString();

           
        }
        public Musteriler updated;
   

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            

            int sifre = Convert.ToInt32(SistemGiris.sifredetay);


            if (sifre.ToString() == textBoxEski.Text)
            {
                if (textBoxSifre1.Text == textBoxSifre2.Text )
                {

                    if (label3.Text == textBoxifade.Text)
                    {
                        updated.Sifre = textBoxSifre1.Text;

                        db.Entry(db.Customers.Find(updated.ID)).CurrentValues.SetValues(updated);
                        db.SaveChanges();

                        MessageBox.Show("Şifre güncelleme işleminiz başarıyla gerçekleştirildi.");
                    }

                    else
                    { MessageBox.Show("Girdiğiniz ifadenin doğruluğundan emin olunuz."); }
                }

                else
                {
                    MessageBox.Show("Girdiğiniz şifrelerin doğruluğundan emin olunuz.");
                }
            }
            else
            { MessageBox.Show("Lütfen değiştirmek istediğiniz şifreyi doğru giriniz."); }
        }
    }
}
