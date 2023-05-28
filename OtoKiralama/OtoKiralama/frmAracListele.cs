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
using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using System.Windows.Controls;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraRichEdit.Model;

namespace OtoKiralama
{
    public partial class frmAracListele : DevExpress.XtraEditors.XtraForm
    {

        public frmAracListele()
        {
            DbOto Mycontext = new();
            InitializeComponent();
            var marka = Mycontext.Marka.ToList();

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



        private void btnAracListele_Click(object sender, EventArgs e)
        {


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Refresh();
            gridView1.RefreshData();
            gridControl1.Refresh();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }
        private RepositoryItemPictureEdit repositoryItemPictureEdit;

        private void btnAracListele_Click_1(object sender, EventArgs e)
        {
            gridView1.OptionsView.ColumnAutoWidth = true;

            DbOto Mycontext = new();
            var list = from cl in Mycontext.carList
                       join a in Mycontext.Marka on cl.markaid equals a.Id
                       select new
                       {
                           Numarası = cl.id,
                           Markası = a.MarkaAdi,
                           Modeli = cl.modeli,
                           ModelYili = cl.modelyili,
                           Plaka = cl.Plakano,

                       };

            if (comboBox1.SelectedIndex > 0)
            {
                list = list.Where(x => x.Markası == comboBox1.SelectedItem.ToString());
            }
            if (comboBox2.SelectedIndex > 0)
            {
                list = list.Where(x => x.ModelYili == comboBox2.SelectedItem.ToString());
            }
            if (textBox1.Text != "")
            {
                list = list.Where(x => x.Modeli.Contains(textBox1.Text));
            }

            gridControl1.DataSource = list.ToList();





        }
    }
}
