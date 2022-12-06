using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace nKATMANLIMIMARUYGULAMASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource= Perlist; 
        }

        private void Ekle_btn_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = ad_txt.Text;
            ent.Soyad = soyad_txt.Text;
            ent.Sehir = sehir_txt.Text;
            ent.Maas = short.Parse(maas_txt.Text);
            ent.Gorev = gorev_txt.Text;
           LogicPersonel.LLPersonelEkle(ent);

        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id=Convert.ToInt32(ıd_txt.Text);
            LogicPersonel.LLPERSONELsil(ent.Id);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(ıd_txt.Text);
            ent.Ad= ad_txt.Text;
            ent.Soyad= soyad_txt.Text;
            ent.Sehir= sehir_txt.Text;
            ent.Maas = short.Parse(maas_txt.Text);
            ent.Gorev= gorev_txt.Text;
            LogicPersonel.LLPersonelGuncelle(ent);


        }
    }
}
