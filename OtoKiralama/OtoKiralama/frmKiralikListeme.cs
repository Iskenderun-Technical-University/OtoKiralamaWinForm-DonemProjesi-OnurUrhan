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
    public partial class frmKiralikListeme : DevExpress.XtraEditors.XtraForm
    {
        DbOto Mycontext = new DbOto();
        public frmKiralikListeme()
        {

            InitializeComponent();
            var marka = Mycontext.Marka.ToList();
            grid();
            comboBox1.Items.Add("Seçiniz");

            foreach (var item in marka)
            {
                comboBox1.Items.Add(item.MarkaAdi);
            }

            comboBox1.DisplayMember = "MarkaAdi";
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("Seçiniz");
            comboBox2.SelectedIndex = 0;
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                comboBox2.Items.Add(i);
            }
        }
        void grid()
        {
            DbOto Mycontext = new DbOto();

            var list = from k in Mycontext.KiralamaListesi
                       join a in Mycontext.Marka on k.Id equals a.Id
                       select new
                       {
                           Id = k.Id,
                           Plakano = k.Plakano,
                           Model = k.Model,
                           ModelYili = k.ModelYılı,
                           Marka = a.MarkaAdi,
                           KiralamaTarihi = k.KiralamaTarihi,
                           BitişTarihi = k.BitişTarihi,
                           MüşteriTcNo = k.MusteriTc,
                           MüşteriAd = k.MusteriAdSoyad,
                           MüşterininTelefonu = k.MusteriTel
                       };
            if (list != null)
            {
                gridControl1.DataSource = list.ToList();
            }

        }

        private void btnAracListele_Click_1(object sender, EventArgs e)
        {
            DbOto Mycontext = new DbOto();

            var list = from k in Mycontext.KiralamaListesi
                       join a in Mycontext.Marka on k.Id equals a.Id
                       select new
                       {
                           Id = k.Id,
                           Plakano = k.Plakano,
                           Model = k.Model,
                           ModelYili = k.ModelYılı,
                           Marka = a.MarkaAdi,
                           KiralamaTarihi = k.KiralamaTarihi,
                           BitişTarihi = k.BitişTarihi,
                           MüşteriTcNo = k.MusteriTc,
                           MüşteriAd = k.MusteriAdSoyad,
                           MüşterininTelefonu = k.MusteriTel
                       };


            if (dtStart.EditValue != null && dtEnd.EditValue != null)
            {
                list = list.Where(x => x.KiralamaTarihi <= Convert.ToDateTime(dtStart.EditValue) && x.BitişTarihi >= Convert.ToDateTime(dtEnd.EditValue));
            }
            else
            {
                list = list.Where(x => x.KiralamaTarihi < DateTime.Now && x.BitişTarihi > DateTime.Now);
            }
            if (comboBox1.SelectedIndex > 0)
            {
                list = list.Where(x => x.Marka == comboBox1.SelectedItem.ToString());
            }

            if (textBox1.Text != "")
            {
                list = list.Where(x => x.Model.Contains(textBox1.Text));
            }
            if (comboBox2.SelectedIndex > 0)
            {
                list = list.Where(x => x.ModelYili == comboBox2.SelectedItem.ToString());
            }

            gridControl1.DataSource = list.ToList();
        }
    }
}