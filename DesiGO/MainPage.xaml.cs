namespace DesiGO;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }


    private void BtnBilgiGoster_OnClicked(object? sender, EventArgs e)
    {
            DisplayAlertAsync("Bilgi", "Tüm bilgiler gösterildi!", "Tamam");
    }

    private void BtnBilgiTemizle_OnClicked(object? sender, EventArgs e)
    {
            DisplayAlertAsync("Bilgi", "Bilgiler temizlendi!", "Tamam");
    }

    private void BtnKargoUcretiHesapla_OnClicked(object? sender, EventArgs e)
    {
            DisplayAlertAsync("Bilgi", "Kargo ücreti hesaplandı!", "Tamam");
    }

    private void BtnAliciBilgiGoster_OnClicked(object? sender, EventArgs e)
    {
            DisplayAlertAsync("Bilgi", "Alıcı bilgileri gösterildi!", "Tamam");
    }

    private void BtnGondericiBilgiGoster_OnClicked(object? sender, EventArgs e)
    {
                DisplayAlertAsync("Bilgi", "Gönderici bilgileri gösterildi!", "Tamam");
                
    }
}