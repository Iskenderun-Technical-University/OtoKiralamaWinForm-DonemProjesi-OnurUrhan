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
    public partial class frmMusteriList : DevExpress.XtraEditors.XtraForm
    {
        DbOto Mycontext = new DbOto();
        public frmMusteriList()
        {

            InitializeComponent();

        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.RefreshData();
            gridControl1.Refresh();
        }

        private void btnAracListele_Click_1(object sender, EventArgs e)
        {
            DbOto Mycontext = new DbOto();

            var list = from m in Mycontext.musteri
                       select new
                       {
                           MüşteriNo = m.MusteriId,
                           Tc = m.Tcno,
                           Ad = m.Ad,
                           Soyad = m.Soyad,
                           Telefonu = m.Telefonu
                       };
            if (textBox1.Text != "")
            {
                list = list.Where(x => x.Tc.Contains(textBox1.Text));
            }
            if (textBox2.Text != "")
            {
                list = list.Where(x => x.Ad.Contains(textBox2.Text));
            }
            if (textBox3.Text != "")
            {
                list = list.Where(x => x.Soyad.Contains(textBox3.Text));
            }
            if (textBox4.Text != "")
            {
                list = list.Where(x => x.Telefonu.Contains(textBox4.Text));
            }

            gridControl1.DataSource = list.ToList();
        }
    }
}