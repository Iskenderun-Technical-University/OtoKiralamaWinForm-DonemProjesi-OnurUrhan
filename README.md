[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/uelKf0-p)

Araç kiralama otomasyonunun içeriğinde bir oto-kiralama şirketinin kullanabileceği gerekli özelliklere sahip olması ve iş yükünden kolaylık sağlamasıdır.
Örneğin mevcut araçları listeleyeceği,güncelleyeceği,müşteri listesi ve kiralık araçları görebileceği gibi özellikleri bulunduracak.


Neden bu otomasyon sorusuna gelirsek yaygın olarak  iş olan oto-kiralamada ,daha kolay bir şekilde ihtiyacı olan  müşteri bulunabilmesidir.
MsSql veritabanında Araç listesi,Müşteri listesi, Kiralık araçların müşteri-araç bağlantılı olan bir liste ve programı kullanacak kişilerin  uygulamaya giriş yapabileceği bilgilerinin tutulduğu bir tablo yer alacak.

Uygulamanın kod kısmında ise Entity Net framework Linq kullandım.Bunun sebebi ise Sql bağlantısında ve sorgularında çok daha kullanışlı olması aynı zamanda örneğin mssql den farklı bir veritabanına geçmek istgediğinizde sizi uğraştırmadan yeni veritabanına kendisi uyarlamasıdır.Bu yüzden Entity Framework büyük avantaj sağlıyor.

Tasarım kısmına gelecek olursak Devexpress kütüphanelerinden faydalanarak çok daha kullanışlı ve göze hitap açısından bize birçok olağan sunması devexpressi seçme nedenim oldu. Örneğin Bar menüler,ribbon fromlar ve benim için en önemlisi gridview üzerinde kolaylıkla arama,sıralama ve bir çok filtreyi kendi içerisinde barındırması kullanım açısından büyük kolaylık sağlamaktadır.
