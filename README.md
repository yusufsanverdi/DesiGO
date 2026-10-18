# DesiGO 📦 - Kargo & Desi Hesaplama Mobil Uygulaması

> **Mobil Cihazlar İçin Yazılım Mühendisliği** dersi kapsamında geliştirilmiş .NET MAUI tabanlı mobil kargo ve desi hesaplama uygulaması.

---

## 📌 Proje Hakkında

**DesiGO**, kullanıcıların gönderici ve alıcı bilgilerini kolayca yönetebildiği, kargo paketinin fiziksel ölçüleri (en, boy, yükseklik), ağırlığı ve taşıma mesafesine göre dinamik olarak desi ve kargo ücreti hesaplaması yapabildiği modern bir mobil uygulamadır.

Bu proje, **Mobil Cihazlar İçin Yazılım Mühendisliği** dersi ödevi isterleri doğrultusunda temel kullanıcı arayüzü (UI) bileşenlerini etkin bir şekilde kullanmak ve mobil cihazlarda sorunsuz çalışacak şekilde tasarlanmıştır.

---

## 🎯 Ödev Kapsamında Kullanılan Arayüz Bileşenleri

Ödev isterlerinde belirtilen tüm arayüz görünümleri XAML ve C# arka plan kodlarıyla entegre edilerek kullanılmıştır:

| Bileşen | Kullanım Alanı & Açıklama |
| :--- | :--- |
| **`Label`** | Gönderici/Alıcı bilgi başlıkları, form alan isimleri, dinamik değer gösterimleri ve sonuç metinleri. |
| **`Entry`** | Gönderici ve alıcıya ait Ad-Soyad, 11 haneli T.C. Kimlik Numarası ve adres metin girişleri (Numeric & Text klavye tipleri ile). |
| **`Slider`** | Kargo paketi boyutları (En, Boy, Yükseklik: 0-100 cm), mesafe (30-1500 km) ve ağırlık (0-100 kg) değerlerinin hassas seçimi. |
| **`Stepper`** | Gönderilecek koli/paket adedinin artırılıp azaltılarak belirlenmesi. |
| **`Button`** | "Kargo Ücreti Hesapla", "Bilgileri Göster", "Alıcı Bilgileri Göster", "Gönderici Bilgileri Göster" ve "Bilgileri Temizle" eylemleri. |

---

## 🚀 Temel Özellikler

- **Gönderici & Alıcı Bilgi Yönetimi:** Ad, soyad, TC kimlik ve adres bilgilerinin düzenli form yapısında toplanması.
- **Dinamik Desi & Boyut Seçimi:** Slider kontrolleri ile en, boy, yükseklik ve ağırlık parametrelerinin anlık seçimi.
- **Mesafe ve Ücret Simülasyonu:** Taşıma mesafesi ve paket hacmine göre kargo bedeli hesaplama altyapısı.
- **İşlem Butonları:** Bilgileri özetleyen diyaloglar (`DisplayAlert`) ve formu sıfırlama işlevleri.
- **Çapraz Platform (Cross-Platform):** Android, iOS, Windows ve MacCatalyst desteği sağlayan .NET MAUI mimarisi.

---

## 🛠️ Kullanılan Teknolojiler & Gereksinimler

- **Platform:** [.NET MAUI (.NET 10)](https://dotnet.microsoft.com/en-us/apps/maui)
- **Dil:** C# 13 / XAML
- **Geliştirme Ortamı:** JetBrains Rider / Visual Studio 2022 / VS Code
- **Hedef Cihazlar:** Android (min SDK 21+), iOS, Windows Desktop

---

## 💻 Kurulum ve Çalıştırma

Projeyi yerel ortamınızda derleyip çalıştırmak için:

1. **Depoyu Klonlayın:**
   ```bash
   git clone https://github.com/KULLANICI_ADINIZ/DesiGO.git
   cd DesiGO
   ```

2. **Gereksinimleri Yükleyin:**
   .NET MAUI iş yükünün yüklü olduğundan emin olun:
   ```bash
   dotnet workload install maui
   ```

3. **Android Cihazda / Emülatörde Çalıştırın:**
   ```bash
   cd DesiGO
   dotnet build -t:Run -f net10.0-android
   ```
   *veya JetBrains Rider / Visual Studio üzerinden doğrudan hedef Android cihazınızı seçerek **Run** butonuna tıklayınız.*

---

## 📱 Ekran Görüntüleri

| Ana Ekran / Form Girişi | Kargo & Desi Ayarları | Hesaplama & İşlemler |
| :---: | :---: | :---: |
| *(Ekran Görüntüsü Eklenecektir)* | *(Ekran Görüntüsü Eklenecektir)* | *(Ekran Görüntüsü Eklenecektir)* |

---

## 🔗 Kaynak Kod & Depo Bilgisi

- **GitHub Depo Bağlantısı:** `https://github.com/KULLANICI_ADINIZ/DesiGO`
- **Öğrenci / Geliştirici:** Yusuf
- **Ders:** Mobil Cihazlar İçin Yazılım Mühendisliği
