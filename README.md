# DesiGO 📦 - Kargo & Desi Hesaplama Mobil Uygulaması

> **Mobil Cihazlar İçin Yazılım Mühendisliği** dersi kapsamında .NET MAUI platformu kullanılarak geliştirilmiş, gerçek zamanlı kargo ve desi (hacimsel ağırlık) hesaplama mobil uygulaması.

---

## 📌 Proje Hakkında

**DesiGO**, kargo gönderim süreçlerinde gönderici ve alıcı bilgilerinin düzenli bir form yapısında toplanmasını, kargo paketinin boyutları (en, genişlik, yükseklik), kutu adedi ve ağırlığı baz alınarak **uluslararası standartlarda desi (hacimsel ağırlık)** ve **kargo ücreti** hesaplanmasını sağlayan modern bir mobil uygulamadır.

Proje, **Mobil Cihazlar İçin Yazılım Mühendisliği** dersi isterleri doğrultusunda temel kullanıcı arayüzü (UI) bileşenlerini (`Label`, `Entry`, `Button`, `Slider`, `Stepper`) hem görsel hem de işlevsel olarak etkin bir mimaride bir araya getirmektedir.

---

## 🎯 Ödev Kapsamında Kullanılan Arayüz Bileşenleri

Ödev yönergesinde yer alan tüm kontroller `MainPage.xaml` arayüzünde ve `MainPage.xaml.cs` olay dinleyicilerinde (event handlers) aktif olarak kullanılmıştır:

| Bileşen | Projedeki Kontroller | Kullanım Amacı & Açıklama |
| :--- | :--- | :--- |
| **`Label`** | `lblKargoEni`, `lblKargoGenisligi`, `lblKargoYuksekligi`, `lblKutuSayisi`, `lblKargoAgirligi`, `lblKargoUcreti`, Başlıklar | Form etiketleri, bölüm başlıkları, Slider/Stepper değerlerinin anlık sayısal gösterimi ve hesaplanan nihai kargo ücreti çıktısı. |
| **`Entry`** | `entGndAdSoyad`, `entGndAdres`, `entGndTCKimlikNo`, `entGndTelefon`, `entAliciAdSoyad`, `entAliciAdres`, `entAliciTCKimlikNo`, `entAliciTelefon` | Gönderici ve alıcıya ait Ad-Soyad, adres, 11 haneli T.C. Kimlik Numarası ve telefon bilgilerinin alınması (özelleştirilmiş `PlaceholderColor` ve `Keyboard` tipleri ile). |
| **`Slider`** | `sldKargoEni`, `sldKargoGenisligi`, `sldKargoYuksekligi` | Kargo paket boyutlarının (En: 0-100 cm, Genişlik: 0-100 cm, Yükseklik: 0-100 cm) kaydırılarak hassas bir şekilde seçilmesi (`ValueChanged` ile anlık etiket güncellemesi). |
| **`Stepper`** | `stpKutuSayisi`, `stpKargoAgirligi` | Gönderilecek kutu sayısının (1 - 10 adet) ve kargo ağırlığının (1 - 100 kg) adım adım artırılıp/azaltılarak ayarlanması. |
| **`Button`** | `btnKargoUcretiHesapla`, `btnGondericiBilgiGoster`, `btnAliciBilgiGoster`, `btnTumBilgileriGoster`, `btnTumBilgileriTemizle` | Ücret hesaplama algoritmasını çalıştırma, girilen verileri açılır bildirimlerle (`DisplayAlert`) özetleme ve tüm formu sıfırlama işlemleri. |

---

## 📐 Hesaplama Mantığı & Desi Formülü

Uygulamada gerçek kargo taşımacılığı standartlarına uygun hacimsel ağırlık (desi) formülü uygulanmaktadır:

$$\text{Hacim (cm}^3\text{)} = \text{En (cm)} \times \text{Genişlik (cm)} \times \text{Yükseklik (cm)}$$

$$\text{Hacimsel Ağırlık (Desi)} = \frac{\text{Hacim}}{5000}$$

$$\text{Kargo Ücreti (TL)} = \max(\text{Hacimsel Ağırlık}, \text{Kargo Ağırlığı}) \times \text{Kutu Sayısı} \times 10\text{ TL}$$

*Not: Kargo sektör standardına uygun olarak paket hacimsel ağırlığı ile gerçek tartı ağırlığından büyük olanı baz alınarak fiyatlandırılmaktadır.*

---

## 🚀 Öne Çıkan Özellikler & Mimari Yenilikler

- **Modern Grid Tabanlı Form Mimarisi:** Form alanları `ColumnDefinitions` ve `RowDefinitions` kullanılarak hizalı, okunaklı ve duyarlı (responsive) 2 sütunlu ve 3 sütunlu `Grid` yapılarıyla tasarlanmıştır.
- **XAML ResourceDictionary:** Renk paleti (`LabelBgColor`, `MainBgColor`, `ButtonBgColor`, `GridBgColor`, `SliderBgColor` vb.) merkezi bir kaynak sözlüğünde tanımlanarak tutarlı bir tasarım dili oluşturulmuştur.
- **Canlı Değer Güncellemesi:** Slider ve Stepper hareket ettirildiği anda `ValueChanged` mekanizması ile ilgili etikete seçilen değer (örn: `Kargo Eni: 45.0 cm`, `Kutu Sayısı: 3`) anlık olarak yansıtılır.
- **Etkileşimli Bildirimler (DisplayAlert):** Gönderici, alıcı ve kargo özetleri kullanıcıya modal pencereler aracılığıyla düzenli bir formatta sunulur.
- **Form Sıfırlama:** Tek tuşla tüm giriş alanları ve hesaplama verileri varsayılan değerlerine döndürülebilir.

---

## 🛠️ Kullanılan Teknolojiler

- **Platform:** [.NET MAUI (.NET 10)](https://dotnet.microsoft.com/en-us/apps/maui)
- **Programlama Dili:** C# 13
- **Arayüz:** XAML (Extensible Application Markup Language)
- **Geliştirme Ortamı:** JetBrains Rider / Visual Studio 2022
- **Hedef Platform:** Android (API 21+), iOS, Windows Desktop, macOS

---

## 💻 Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için:

1. **Depoyu Klonlayın:**
   ```bash
   git clone https://github.com/yusufsanverdi/DesiGO.git
   cd DesiGO
   ```

2. **Gerekli .NET MAUI İş Yükünü Doğrulayın:**
   ```bash
   dotnet workload install maui
   ```

3. **Android Cihazda / Emülatörde Başlatın:**
   ```bash
   cd DesiGO
   dotnet build -t:Run -f net10.0-android
   ```
   *veya IDE (Rider / Visual Studio) üzerinden Android emülatörünü seçip **Run** butonuna basınız.*

---

## 📱 Ekran Görüntüleri

| Gönderici & Alıcı Formu (Grid) | Kargo Boyutları & Desi Hesaplama | İşlem Butonları & Sonuç |
| :---: | :---: | :---: |
| *(Ekran Görüntüsü Eklenecektir)* | *(Ekran Görüntüsü Eklenecektir)* | *(Ekran Görüntüsü Eklenecektir)* |

---

## 🔗 Kaynak Kod & İletişim

- **GitHub Deposu:** [https://github.com/yusufsanverdi/DesiGO](https://github.com/yusufsanverdi/DesiGO)
- **Geliştirici:** Yusuf Şanverdi ([@yusufsanverdi](https://github.com/yusufsanverdi))
- **Ders:** Mobil Cihazlar İçin Yazılım Mühendisliği
