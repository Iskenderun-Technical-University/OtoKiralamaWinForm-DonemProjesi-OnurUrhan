using DevExpress.XtraBars;
using Microsoft.EntityFrameworkCore;
using OtelForm;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Controls;
//Ekleme ****
//DbOto context = new();
//Marka marka = new() { MarkaAdi = "Bmw" };
//Marka marka1 = new() { MarkaAdi = "Mercedes" };
//Marka marka2 = new() { MarkaAdi = "Opel" };
//Marka marka3 = new() { MarkaAdi = "Ford" };
//Marka marka4 = new() { MarkaAdi = "Volkswagen" };

//await context.AddAsync(marka);
//await context.SaveChangesAsync();

//Güncelleme ****

//DbOto context = new DbOto();

//Marka marka = await context.Marka.FirstOrDefaultAsync(x => x.Id == 1);
//marka.MarkaAdi = "Volvo";

//await context.SaveChangesAsync();


//Silme ****

//DbOto context = new();

//Marka marka = await context.Marka.FirstOrDefaultAsync(x => x.Id == 7);
//context.Marka.Remove(marka);
//await context.SaveChangesAsync();



namespace OtoKiralama
{
    
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new formLogin());
        }
    }
}




public class DbOto : DbContext
{
  
    public DbSet<Musteri> musteri { get; set; }
    public DbSet<Marka> Marka { get; set; }
    public DbSet<AracListesi> KiralamaListesi { get; set; }
    public DbSet<AracListesi> AracListesi { get; set; }

    public DbSet<CarList> kiralamaArac { get; set; }

    public DbSet<CarList> carList { get; set; }
    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=OtoKiralama;User Id=onur;Password=123456;TrustServerCertificate=True");

    }

}
public class User
{
    [Key]
    public int  Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
public class AracListesi
{
    public int Id { get; set; }
    public string? Plakano { get; set; }
    public string? Model { get; set; }
    public string? ModelYýlý { get; set; }
    public int Marka { get; set; }
    public string? Ucreti { get; set; }
    public DateTime KiralamaTarihi { get; set; }
    public DateTime BitiþTarihi { get; set; }
    public string? MusteriTc { get; set; }
    public string? MusteriTel { get; set; }
    public string? MusteriAdSoyad { get; set; }
}

//    public class KiralamaListesi
//{
//    public int Id { get; set; }
//    public string MusteriTc { get; set; }
//    public string MusteriTel { get; set; }
//    public string MusteriAdSoyad { get; set; }
//    public string Plakano { get; set; }
//    public string Model { get; set; }
//    public int ModelYýlý { get; set; }
//    public int Marka { get; set; }
//    public string ucreti { get; set; }
//}
public class CarList
{
    public int id { get; set; }
    public int markaid { get; set; }
    public string modeli { get; set; }
    public string? modelyili { get; set; }
    public string Plakano { get; set; }
    public decimal? ucreti { get; set; }
    public string? resim { get; set; }
}

public class Musteri
{
    public int MusteriId { get; set; }
    public string Tcno { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Telefonu { get; set; }

}
public class Marka
{
    public int Id { get; set; }
    public string MarkaAdi { get; set; }
}