using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace OtoKiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DbOto context = new DbOto();

            
            frmMusteriList frm=new frmMusteriList();
            frm.Show();
            //Update iþlemi
            //var urun = await context.Marka.FirstOrDefaultAsync(x => x.MarkaAdi=="VOLVO");
            //urun.MarkaAdi = "SEAT";
            //await context.SaveChangesAsync();

            //add iþlemi
            //Marka markaadd = new Marka() { MarkaAdi = textBox1.Text };
            //await context.Marka.AddAsync(markaadd);
            //await context.SaveChangesAsync();



            //delete iþlemi
            //var markadelete = await context.Marka.ToListAsync();
            //context.Marka.Remove(markadelete.FirstOrDefault(x => x.MarkaAdi == textBox1.Text));
            //await context.SaveChangesAsync();

            //var markadi = from Marka in context.Marka
            //              where Marka.MarkaAdi.Contains("Ford")
            //              //contains 'Like görevi görür'
            //              select Marka;


            //Tek veri için FirstOrDefaultAsync() kullanýlýr.
            //var markaname = await context.Marka.Where(m => m.Id == 1).FirstOrDefaultAsync();
            //textBox1.Text = markaname.MarkaAdi.ToString();

            //var marka3 = await context.Marka.FirstOrDefaultAsync(x => x.Id == 1);
            //textBox1.Text = marka3.MarkaAdi;

            //var marka4 = context.Marka.CountAsync();
            //textBox1.Text = marka4.Result.ToString();

            //var marka5 = context.Marka.AnyAsync();
            //textBox1.Text = marka5.Result.ToString();

            //var marka6 = await context.Marka.Where(x => x.MarkaAdi.Contains("or")).ToListAsync();

            //var marka7 = await context.Marka.MaxAsync(x => x.Id);
            //textBox1.Text = marka7.ToString();

            //var marka8 = await context.Marka.Distinct().ToListAsync();

            //var marka9 = await context.Marka.SumAsync(x => x.Id);

            //var marka10 = await context.Marka.Where(x => x.MarkaAdi.StartsWith("F")).ToListAsync();

            //var MarkaAZ = from marka in context.Marka
            //              where marka.Id > 0
            //              orderby marka.MarkaAdi
            //              select marka;

            //var marka11 = from onur in context.Marka select onur;

            //var marka12 = await context.Marka.Select(x => new
            //{
            //    x.MarkaAdi,
            //    x.Id
            //}).ToListAsync();


            //var marka13 = from MarkaTB in context.Marka
            //              where MarkaTB.Id == 5
            //              select new 
            //              {
            //                  Id = MarkaTB.Id,


            //              };

            //var marka14 = await context.Marka.GroupBy(x => x.Id).Select(_ => new 
            //{
            //    Count =_.Count(),
            //    Fiyat=_.Key
            //}
            //).ToListAsync();






        }

    }
}
