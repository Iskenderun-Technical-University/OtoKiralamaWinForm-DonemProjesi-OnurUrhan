using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraVerticalGrid.ViewInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.DataAccess.Sql;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraLayout.Filtering.Templates;
using DevExpress.Utils;

namespace OtoKiralama
{
    public partial class frmYeniAracKirala : DevExpress.XtraEditors.XtraForm
    {

        DbOto Mycontext = new DbOto();

        public frmYeniAracKirala()
        {
            InitializeComponent();
        }


        private void frmYeniAracKirala_Load(object sender, EventArgs e)
        {
           
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var list = Mycontext.musteri.Where(x => x.Tcno == textBox5.Text).FirstOrDefault();
            if (list != null)
            {
                textEdit1.Text = list.Ad;
                textEdit2.Text = list.Soyad;
            }
            else
            {
                
                MessageBox.Show("Girilen Tc'ye göre kayıtlı müşteri yok Lütfen  Müşteriyi ekleyin");
            }

        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            DateTime kiralamaTarihi;
            bool kiralamaTarihiBasarili = DateTime.TryParse(textBox1.Text, out kiralamaTarihi);

            DateTime bitisTarihi;
            bool bitisTarihiBasarili = DateTime.TryParse(textBox4.Text, out bitisTarihi);

            if (textEdit1.Text != "")
            {
                var list = Mycontext.musteri.Where(x => x.Tcno == textBox5.Text).FirstOrDefault();
                var arac = Mycontext.carList.Where(x => x.Plakano == textBox2.Text).FirstOrDefault();

                AracListesi aracListesi = new AracListesi()
                {
                    Marka = arac.markaid,
                    ModelYılı = arac.modelyili,
                    Plakano = arac.Plakano,
                    Model = arac.modeli,
                    KiralamaTarihi = kiralamaTarihi,
                    BitişTarihi = bitisTarihi,
                    Ucreti = textEdit3.Text,
                    MusteriTc=list.Tcno,
                    MusteriAdSoyad=list.Ad+" "+list.Soyad,
                    MusteriTel=list.Telefonu
                    
                };
                Mycontext.AracListesi.Add(aracListesi);
                Mycontext.SaveChanges();
                MessageBox.Show("Araç Kiralanma Tamamlandı...");
            }
            else
            {
                MessageBox.Show("Müşteri bilgileri eksik");
            }
        }
    }
}