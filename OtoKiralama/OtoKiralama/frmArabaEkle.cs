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
    public partial class frmArabaEkle : DevExpress.XtraEditors.XtraForm
    {
        DbOto Mycontext = new DbOto();
        public frmArabaEkle()
        {

            InitializeComponent();
            var marka = Mycontext.Marka.ToList();

            comboBox1.Items.Add("Seçiniz");

            foreach (var item in marka)
            {
                comboBox1.Items.Add(item.MarkaAdi);
            }
            comboBox1.DisplayMember = "MarkaAdi";
            comboBox1.ValueMember = "Id";
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
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void btnAracListele_Click_1(object sender, EventArgs e)
        {

            if (textBox2.Text != "" || textBox3.Text != "" || comboBox1.SelectedIndex > 0 || comboBox2.SelectedIndex > 0)
            {
                if (textBox3.Text.Length != 7)
                {
                    MessageBox.Show("Lütfen Plakayı  doğru girin.");
                }
                else
                {
                    bool plaka = Mycontext.carList.Any(x => x.Plakano == textBox3.Text);
                    if (!plaka)
                    {
                        CarList newcar = new CarList()
                        {
                            Plakano = textBox3.Text,
                            markaid = comboBox1.SelectedIndex + 1,
                            modeli = textBox2.Text,
                            modelyili = comboBox2.SelectedItem.ToString(),
                        };
                        Mycontext.carList.Add(newcar);
                        Mycontext.SaveChanges();
                        MessageBox.Show("Yeni Araç Eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Bu Plakalı araç zaten kayıtlı.");
                    }

                }


            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
        }
    }


}
