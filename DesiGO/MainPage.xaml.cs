using Android.App;

namespace DesiGO;

public partial class MainPage : ContentPage
{

        public MainPage()
        {
                InitializeComponent();
        }
        

        private void SldKargoEni_OnValueChanged(object? sender, ValueChangedEventArgs e)
        {
                lblKargoEni.Text = $"Kargo Eni: {e.NewValue:F1} cm";
        }

        private void SldKargoGenisligi_OnValueChanged(object? sender, ValueChangedEventArgs e)
        {
                lblKargoGenisligi.Text = $"Kargo Genişliği: {e.NewValue:F1} cm";
        }

        private void SldKargoYuksekligi_OnValueChanged(object? sender, ValueChangedEventArgs e)
        {
                lblKargoYuksekligi.Text = $"Kargo Yüksekliği: {e.NewValue:F1} cm";
        }

        private void StpKutuSayisi_OnValueChanged(object? sender, ValueChangedEventArgs e)
        {
                lblKutuSayisi.Text = $"Kutu Sayısı: {e.NewValue:F0}";
        }
        
        private void StpKargoAgirligi_OnValueChanged(object? sender, ValueChangedEventArgs e)
        {
                lblKargoAgirligi.Text = $"Kargo Ağırlığı: {e.NewValue:F1} kg";
        }


        private void BtnKargoUcretiHesapla_OnClicked(object? sender, EventArgs e)
        {
                double kargoEni = sldKargoEni.Value;
                double kargoGenisligi = sldKargoGenisligi.Value;
                double kargoYuksekligi = sldKargoYuksekligi.Value;
                int kutuSayisi = (int)stpKutuSayisi.Value;
                double kargoAgirligi = stpKargoAgirligi.Value;

                double hacim = kargoEni * kargoGenisligi * kargoYuksekligi; // cm^3
                double hacimAgirligi = hacim / 5000; // kg

                double ucret = Math.Max(hacimAgirligi, kargoAgirligi) * kutuSayisi * 10; // 10 TL per kg

                lblKargoUcreti.Text = $"Kargo Ücreti: {ucret:F2} TL";
        }

        private void BtnGondericiBilgiGoster_OnClicked(object? sender, EventArgs e)
        {
                DisplayAlertAsync( "Gönderici Bilgileri", $"Ad: {entGndAdSoyad.Text}\nAdres: {entGndAdres.Text}, Türkiye\nTelefon: {entGndTelefon.Text}\n TC: {entGndTCKimlikNo.Text}", "Tamam");

        }

        private void BtnAliciBilgiGoster_OnClicked(object? sender, EventArgs e)
        {
                DisplayAlertAsync( "Alıcı Bilgileri", $"Ad: {entAliciAdSoyad.Text}\nAdres: {entAliciAdres.Text}, Türkiye\nTelefon: {entAliciTelefon.Text}\n TC: {entAliciTCKimlikNo.Text}", "Tamam");

        }

        private void BtnTumBilgileriGoster_OnClicked(object? sender, EventArgs e)
        {
                string ucretMetni = !string.IsNullOrEmpty(lblKargoUcreti.Text) && lblKargoUcreti.Text.Contains(':') 
                        ? lblKargoUcreti.Text.Split(':')[1].Trim() 
                        : "Hesaplanmadı";

                DisplayAlertAsync( "Gönderici Bilgileri", $"Ad: {entGndAdSoyad.Text}\nAdres: {entGndAdres.Text}, Türkiye\nTelefon: {entGndTelefon.Text}\n TC: {entGndTCKimlikNo.Text}", "Tamam");
                DisplayAlertAsync( "Alıcı Bilgileri", $"Ad: {entAliciAdSoyad.Text}\nAdres: {entAliciAdres.Text}, Türkiye\nTelefon: {entAliciTelefon.Text}\n TC: {entAliciTCKimlikNo.Text}", "Tamam");
                DisplayAlertAsync( "Kargo Bilgileri", $"Kargo Eni: {sldKargoEni.Value:F1} cm\nKargo Genişliği: {sldKargoGenisligi.Value:F1} cm\nKargo Yüksekliği: {sldKargoYuksekligi.Value:F1} cm\nKutu Sayısı: {(int)stpKutuSayisi.Value}\nKargo Ağırlığı: {stpKargoAgirligi.Value:F1} kg\nKargo Ücreti: {ucretMetni}", "Tamam");
        }

        private void BtnTumBilgileriTemizle_OnClicked(object? sender, EventArgs e)
        {
                sldKargoEni.Value = 0;
                sldKargoGenisligi.Value = 0;
                sldKargoYuksekligi.Value = 0;
                stpKutuSayisi.Value = 1;
                stpKargoAgirligi.Value = 1;
                lblKargoEni.Text = "Kargo Eni: 0.0 cm";
                lblKargoGenisligi.Text = "Kargo Genişliği: 0.0 cm";
                lblKargoYuksekligi.Text = "Kargo Yüksekliği: 0.0 cm";
                lblKutuSayisi.Text = "Kutu Sayısı: 1";
                lblKargoAgirligi.Text = "Kargo Ağırlığı: 1.0 kg";
                lblKargoUcreti.Text = "Kargo Ücreti: 0.00 TL";
        }
}