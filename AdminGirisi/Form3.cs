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
    public partial class Form3 : Form
    {
        ProjectContext db = new ProjectContext();
        public Form3()
        {
            InitializeComponent();
            ArabaSec();
        }
        //Kiralama ttarih;
        private void ArabaSec()
        {
            listView1.Items.Clear();


            List<Kiralama> krl = new List<Kiralama>();


            foreach (Arabalar item in db.Cars.Where(x => x.AktifMi == true).ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Plaka);
                lvi.SubItems.Add(item.Marka);
                lvi.SubItems.Add(item.Model);
                lvi.SubItems.Add(item.AracTipi);
                lvi.SubItems.Add(item.Vites);
                lvi.SubItems.Add(item.YakitTipi);
                lvi.SubItems.Add(item.Fiyat.ToString());

                listView1.Items.Add(lvi);
            }






        }
        Arabalar rent;
        double fiyat;
        string gun;
        TimeSpan Sonuc;
        int id;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(listView1.SelectedItems[0].Text);
            rent = db.Cars.Find(id);
            double x = rent.Fiyat;

            DateTime bTarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime kTarih = Convert.ToDateTime(dateTimePicker2.Text);
            Sonuc = (kTarih - bTarih);
            gun = Sonuc.TotalDays.ToString();
            fiyat = Convert.ToDouble(gun) * x;

            txt_Tutar.Text = fiyat.ToString();

        }
        //Arabalar updated1;
        private void btn_kirala_Click(object sender, EventArgs e)
        {


            int id = Convert.ToInt32(listView1.SelectedItems[0].Text);

            List<Arabalar> arabalars = new List<Arabalar>();
            arabalars = db.Cars.Where(x => x.ID == id).ToList();

            rent = db.Cars.Find(id);
            //rent.AktifMi = false;

            Kiralama kiralama = new Kiralama();

            foreach (Arabalar item in arabalars)
            {

                TimeSpan ks = dateTimePicker2.Value - dateTimePicker1.Value;

                kiralama.ArabaID = rent.ID;
                kiralama.MusteriID = rent.ID;
                kiralama.AlisTarihi = dateTimePicker1.Value;
                kiralama.TeslimTarihi = dateTimePicker2.Value;
                kiralama.KiralanmaSuresi = Convert.ToInt32(ks.Days.ToString());
                kiralama.FaturaTutari = fiyat;
                kiralama.AktifMi = true;
                //updated1.AktifMi = false;
                rent.AktifMi = false;



            }
            //
            //updated1.AktifMi = false;

            db.Kiralamas.Add(kiralama);
            db.Entry(db.Cars.Find(rent.ID)).CurrentValues.SetValues(rent);

            db.SaveChanges();

            MessageBox.Show("Kiralama İşlemi Gerçekleştirildi.");
            MessageBox.Show("Sözleşme DB'e Eklendi");
            ArabaSec();





        }
        List<int> ArabaId = new List<int>();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

            List<Kiralama> kiralama = new List<Kiralama>();
            kiralama = db.Kiralamas.ToList();
            foreach (Kiralama item in kiralama)
            {
                if (item.TeslimTarihi == dateTimePicker1.Value)
                {
                    
                    ArabaId.Add(item.ArabaID);
                    foreach (Arabalar a in db.Cars.Where(x => x.ID == item.ArabaID).ToList())
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = a.ID.ToString();
                        lvi.SubItems.Add(a.Plaka);
                        lvi.SubItems.Add(a.Marka);
                        lvi.SubItems.Add(a.Model);
                        lvi.SubItems.Add(a.AracTipi);
                        lvi.SubItems.Add(a.Vites);
                        lvi.SubItems.Add(a.YakitTipi);
                        lvi.SubItems.Add(a.Fiyat.ToString());
                        listView1.Items.Add(lvi);
                    }
                }
            }






        }

        private void label4_Click(object sender, EventArgs e)
        {
            MusteriProfili mf = new MusteriProfili();
            mf.Show();

        }

        private void linkLabelProfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MusteriProfili mp = new MusteriProfili();
            mp.Show();
            this.Hide();
        }
    }
}
