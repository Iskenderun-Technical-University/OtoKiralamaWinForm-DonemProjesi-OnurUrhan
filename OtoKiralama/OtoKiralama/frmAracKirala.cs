using DevExpress.Utils.Menu;
using DevExpress.XtraCharts.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoKiralama
{
    public partial class frmAracKirala : DevExpress.XtraEditors.XtraForm
    {
        public frmAracKirala()
        {
            DbOto Mycontext = new DbOto();


            InitializeComponent();
            simpleButton1.Click += simpleButton1_Click_1;
            dateEdit1.Properties.MinValue = DateTime.Now;



        }

        private void SimpleButton1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.RefreshData();
            gridControl1.Refresh();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            DbOto Mycontext = new DbOto();
            if (dateEdit1.EditValue == null || dateEdit2.EditValue == null)
            {
                MessageBox.Show("Lütfen Tarihleri Giriniz");
                return;
            }
            else
            {


                DateTime baslangicTarihi;
                DateTime bitisTarihi;

                if (DateTime.TryParse(dateEdit1.EditValue.ToString(), out baslangicTarihi) &&
                    DateTime.TryParse(dateEdit2.EditValue.ToString(), out bitisTarihi))
                {
                    var dolu = Mycontext.AracListesi.Where(a => (
                                         a.KiralamaTarihi <= baslangicTarihi && a.BitişTarihi >= baslangicTarihi) ||
                                          a.KiralamaTarihi <= bitisTarihi && a.BitişTarihi >= bitisTarihi).
                                          Select(x => x.Plakano).ToList();

                    var filtreliAraclar = from k in Mycontext.kiralamaArac
                                          join m in Mycontext.Marka on k.markaid equals m.Id
                                          where !dolu.Contains(k.Plakano)

                                          select new
                                          {
                                              Numara = k.id,
                                              Plaka = k.Plakano,
                                              Marka = m.MarkaAdi,
                                              Model = k.modeli,
                                              ModelYılı = k.modelyili,
                                              Ücreti = k.ucreti,
                                              Resim = k.resim,
                                          };
                    if (filtreliAraclar.Count() > 0)
                    {


                        DataTable dt = new DataTable();
                        dt.Columns.Add("Numarası", typeof(int));
                        dt.Columns.Add("Markası", typeof(string));
                        dt.Columns.Add("Modeli", typeof(string));
                        dt.Columns.Add("ModelYili", typeof(string));
                        dt.Columns.Add("Plaka", typeof(string));
                        dt.Columns.Add("Resim", typeof(byte[]));

                        foreach (var item in filtreliAraclar)
                        {
                            try
                            {
                                byte[] imageBytes = File.ReadAllBytes(item.Resim);
                                dt.Rows.Add(item.Numara, item.Marka, item.Model, item.ModelYılı, item.Plaka, imageBytes);
                            }
                            catch (Exception ex)
                            {
                                // Dosya okuma hatasını işle
                                Console.WriteLine("Dosya okuma hatası: " + ex.Message);
                            }
                        }

                        gridControl1.DataSource = dt;


                    }
                    else
                    {
                        MessageBox.Show("Bu tarihlerde Hiç uygun araç yoktur!!!");
                        return;
                    }
                }


                else
                {
                    MessageBox.Show("Tarihlerde hata var");
                }

            }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            dateEdit2.Properties.MinValue = Convert.ToDateTime(dateEdit1.EditValue);
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DateTime date1 = dateEdit1.DateTime.Date;
            DateTime date2 = dateEdit2.DateTime.Date;

            TimeSpan difference = date2 - date1;
            int dayDifference = difference.Days + 1;




            if (gridView1.SelectedRowsCount > 0)
            {
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                string plakaNo = gridView1.GetRowCellValue(selectedRowHandles[0], "Plaka").ToString();
                string marka = gridView1.GetRowCellValue(selectedRowHandles[0], "Marka").ToString();
                decimal ucret = Convert.ToDecimal(gridView1.GetRowCellValue(selectedRowHandles[0], "Ücreti"));

                frmYeniAracKirala frm = new frmYeniAracKirala();
                frm.textBox2.Text = plakaNo;
                frm.textBox3.Text = marka;
                frm.textBox1.Text = date1.ToString();
                frm.textBox4.Text = date2.ToString();
                frm.textEdit3.Text = (dayDifference * ucret).ToString();
                frm.label1.Text = "Günlük ücreti= " + ucret + " Gün sayısı= " + dayDifference + "";
                frm.Show();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }


    }
}



