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
using DevExpress.XtraDialogs;
using DevExpress.PivotGrid.CriteriaVisitors;
using DevExpress.XtraEditors;
using DevExpress.CodeParser;

namespace OtoKiralama
{

    public partial class frmArabaEkle : DevExpress.XtraEditors.XtraForm
    {
        private string Dosyayolu = "";
        DbOto Mycontext = new DbOto();
        public frmArabaEkle()
        {

            InitializeComponent();
            var marka = Mycontext.Marka.ToList();

            comboBox2.Items.Add("Seçiniz");

            foreach (var item in marka)
            {
                comboBox2.Items.Add(item.MarkaAdi);
            }
            comboBox2.DisplayMember = "MarkaAdi";
            comboBox2.ValueMember = "Id";
            comboBox2.SelectedIndex = 0;

            comboBox1.Items.Add("Seçiniz");
            comboBox1.SelectedIndex = 0;
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                comboBox1.Items.Add(i);
            }

        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {

            Mycontext.AracListesi.ToList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Refresh();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void btnAracListele_Click_1(object sender, EventArgs e)
        {

            if (textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedIndex > 0 && comboBox2.SelectedIndex > 0 && textBox1.Text != "" && Dosyayolu != "")
            {
                if (textBox3.Text.Length != 7)
                {
                    XtraMessageBox.Show("Lütfen Plakayı  doğru girin.");
                    return;
                }
                else
                {


                    bool plaka = Mycontext.carList.Any(x => x.Plakano == textBox3.Text);
                    if (!plaka)
                    {
                        CarList newcar = new CarList()
                        {
                            Plakano = textBox3.Text,
                            markaid = comboBox2.SelectedIndex,
                            modeli = textBox2.Text,
                            modelyili = comboBox1.SelectedItem.ToString(),
                            resim = Dosyayolu,
                            ucreti = Convert.ToDecimal(textBox1.Text)
                        };
                        Mycontext.carList.Add(newcar);
                        Mycontext.SaveChanges();
                        XtraMessageBox.Show("Yeni Araç Eklendi.");
                    }
                    else
                    {
                        XtraMessageBox.Show("Bu Plakalı araç zaten kayıtlı.");
                    }

                }


            }
            else
            {
                XtraMessageBox.Show("Lütfen tüm alanları doldurun.");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Dosyayolu = openFileDialog.FileName;
                    // Seçilen resmin yolunu görüntü kutusuna yükle
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    // Dosya yolunu veritabanına kaydetmek için aşağıdaki adımları takip edin.
                    // ...
                }
            }
        }
    }


}
