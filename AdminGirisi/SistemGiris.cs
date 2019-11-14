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
    public partial class SistemGiris : Form
    {
        public SistemGiris()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();
        public static string veri;
        public static string sifredetay;
        private void button1_Click(object sender, EventArgs e)
        {
            string tc = "";
            string sifre = "";
            string id = "";
            bool admin = false;
            List<Musteriler> mst = new List<Musteriler>();
            Musteriler m = new Musteriler();

            mst = db.Customers.Where(x => x.TC == textTCNo.Text).ToList();
            foreach (Musteriler musteri in mst)
            {
                tc = musteri.TC.ToString();
                
                sifre = musteri.Sifre.ToString();
                id = musteri.ID.ToString();
                veri = id;
                
                admin = musteri.IsAdmin.HasValue;
            }
            if (tc == textTCNo.Text && sifre == textSifre.Text)
            {

                if (admin == true)
                {
                    Form2 frmAdminPaneli = new Form2();
                   
                    frmAdminPaneli.Show();
                    this.Hide();
                }
                else
                {
                    Form3 frm = new Form3();
                    sifredetay = sifre;
                    frm.Show();
                    this.Hide();
                }

            }

            else
            {
                MessageBox.Show("Şifre Yanlış.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
