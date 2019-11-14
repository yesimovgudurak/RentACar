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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        public void ArabaList()
        {
            listViewAraba.Items.Clear();
            foreach (Arabalar item in db.Cars.ToList())
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
                lvi.SubItems.Add(item.AktifMi.ToString());
        
                listViewAraba.Items.Add(lvi);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ArabaList();
        }

        private void btn_Kaydet_Click_1(object sender, EventArgs e)
        {
            Arabalar arabalar = new Arabalar();
            arabalar.Plaka = txt_Plaka.Text;
            arabalar.Marka = txt_Marka.Text;
            arabalar.Model = txt_Model.Text;
            arabalar.AracTipi = comboBoxarac.Text;
            arabalar.Vites = comboBoxvites.Text;
            arabalar.YakitTipi = comboBoxyakit.Text;
            arabalar.Fiyat = Convert.ToDouble(txt_Fiyat.Text);
            arabalar.AktifMi =Convert.ToBoolean (comboBoxaktiflik.SelectedIndex);
            arabalar.AddDate = DateTime.Now;
            db.Cars.Add(arabalar);
            db.SaveChanges();

            txt_Plaka.Text = default(string);
            txt_Marka.Text = string.Empty;
            txt_Model.Text = string.Empty;
            comboBoxarac.SelectedIndex = -1;
            comboBoxvites.SelectedIndex = -1;
            comboBoxyakit.SelectedIndex = -1;
            txt_Fiyat.Text = default(string);
            comboBoxaktiflik.SelectedIndex = -1;
            ArabaList();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (listViewAraba.SelectedItems.Count <= 0) return;

          
            Arabalar deleted = db.Cars.Find(updated.ID);
            db.Cars.Remove(deleted);
            db.SaveChanges();
            ArabaList();
        }

        Arabalar updated;

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (listViewAraba.SelectedItems.Count <= 0 && updated == null) return;
            updated.Plaka = txt_Plaka.Text;
            updated.Marka = txt_Marka.Text;
            updated.Model = txt_Model.Text;
            updated.AracTipi = comboBoxarac.Text;
            updated.Vites = comboBoxvites.Text;
            updated.YakitTipi = comboBoxyakit.Text;
            updated.Fiyat = Convert.ToDouble(txt_Fiyat.Text);
            updated.AktifMi = Convert.ToBoolean(comboBoxaktiflik.SelectedIndex);
            updated.UpdateDate = DateTime.Now;
            db.Entry(db.Cars.Find(updated.ID)).CurrentValues.SetValues(updated);
            db.SaveChanges();

            txt_Plaka.Text = default(string);
            txt_Marka.Text = string.Empty;
            txt_Model.Text = string.Empty;
            comboBoxarac.SelectedIndex = -1;
            comboBoxvites.SelectedIndex = -1;
            comboBoxyakit.SelectedIndex = -1;
            comboBoxaktiflik.SelectedIndex = -1;
            txt_Fiyat.Text = default(string);
            ArabaList();

        }

        private void listViewAraba_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listViewAraba.SelectedItems[0].Text);
            updated = db.Cars.Find(id);
            txt_Plaka.Text = updated.Plaka;
            txt_Marka.Text = updated.Marka;
            txt_Model.Text = updated.Model;
            comboBoxarac.Text = updated.AracTipi;
            comboBoxvites.Text = updated.Vites;
            comboBoxyakit.Text = updated.YakitTipi;
            txt_Fiyat.Text = updated.Fiyat.ToString();
           comboBoxaktiflik.SelectedIndex = Convert.ToInt32(updated.AktifMi);
        }

       
    }
}
