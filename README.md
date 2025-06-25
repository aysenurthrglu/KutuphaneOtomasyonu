# Kütüphane Otomasyon Sistemi

Giriş Bilgileri: Personeller için sabit giriş bilgileri: kullanıcı adı:personel şifre:4321
Öğrenci Bilgileri: veritabanlarında öğrencilere ait bilgiler mevcut. örnek öğrenci bilgisi:  kullanıcı adı:ayse123 şifre:123652

Bu proje, bir kütüphane otomasyon sistemini Windows Forms (C#) ve PostgreSQL veritabanı kullanarak geliştirmek amacıyla hazırlanmıştır.


## 🔧 Kullanılan Teknolojiler

- C# (.NET Framework - Windows Forms)
- PostgreSQL
- Npgsql (PostgreSQL bağlantısı için .NET kütüphanesi)
- Visual Studio 2022

## 📚 Özellikler

- 📘 Kitap ekleme, silme, güncelleme ve listeleme
- 👤 Öğrenci kayıt ve yönetim işlemleri
- 📅 Kitap ödünç verme ve teslim alma (emanet işlemleri)
- 🔐 Giriş ekranı (öğrenci ve personel için ayrı seçenek)
- 🔄 Şifre değiştirme özelliği
- 🎨 Kullanıcı dostu arayüz

## 🗃️ Veritabanı

Veritabanı `kutuphane` olarak adlandırılmıştır. İçerdiği tablolar:
- `kitaplar`
- `ogrenciler`
- `odunc` (ödünç işlemleri)
  ## 🚀 Projeyi Çalıştırma

1. Visual Studio ile projeyi açın.
2. `app.config` veya bağlantı stringlerinin yer aldığı satırlarda kendi PostgreSQL kullanıcı adı ve şifrenizi kontrol edin.
3. PostgreSQL’de `kutuphane` adlı veritabanını ve tabloları oluşturun.
4. `Start` butonuna basarak uygulamayı çalıştırın.

## 📌 Notlar

- Giriş türüne göre öğrenci paneli veya personel yönetim paneli açılır.
- Şifre değişikliği işlemleri giriş ekranından yapılabilir.
- Formlar arası geçişlerde `this.Hide()` ve `FormClosed` kullanılarak giriş ekranına dönüş yapılır.

## 👩‍💻 Geliştirici

- **Ad Soyad:** Ayşenur Tahiroğlu  
- **Öğrenci No:** 235511028  2/B
- **Ders:** Sistem Analizi ve Tasarımı -  Bilgisayar Programcılığı
