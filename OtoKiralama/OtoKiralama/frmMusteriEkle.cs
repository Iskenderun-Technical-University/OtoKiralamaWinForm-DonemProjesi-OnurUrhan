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
    public partial class frmMusteriEkle : DevExpress.XtraEditors.XtraForm
    {
        DbOto Mycontext = new DbOto();
        public frmMusteriEkle()
        {

            InitializeComponent();

        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            DbOto Mycontext = new DbOto();

            Musteri newmusteri = new Musteri()
            {
                Tcno = textBox1.Text,
                Ad = textBox2.Text,
                Soyad = textBox3.Text,
                Telefonu = textBox4.Text,
            };
            bool tc = Mycontext.musteri.Any(x => x.Tcno == textBox1.Text);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (textBox1.Text.Length != 11 && textBox4.Text.Length != 11)
                {
                    MessageBox.Show("Lütfen Tc ve Telefon numaralarını doğru girin.");
                }
                else
                {
                    if (!tc)
                    {
                        Mycontext.musteri.Add(newmusteri);
                        Mycontext.SaveChanges();
                        MessageBox.Show("Yeni Müşteri Eklendi.");

                    }
                    else
                    {
                        MessageBox.Show("Bu Müşteri zaten kayıtlı.");
                        return;
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