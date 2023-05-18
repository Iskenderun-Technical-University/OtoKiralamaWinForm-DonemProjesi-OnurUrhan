using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoKiralama
{
    public partial class frmAnasayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }


        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmAracListele frmAracListele = new frmAracListele();
            frmAracListele.MdiParent = this;
            frmAracListele.Show();
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriEkle frm = new frmMusteriEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriList frm = new frmMusteriList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAracKirala frm=new frmAracKirala();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmArabaEkle frm = new frmArabaEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKiralikListeme frm= new frmKiralikListeme();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmAracKirala frm= new frmAracKirala();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmArabaEkle frm= new frmArabaEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAracListele frm= new frmAracListele();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}