namespace LoginTeste;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}

	async void TapGestureRecognizer_Tapped_For_Regista(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
	{
		await Shell.Current.GoToAsync("//Registar");
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
    }
}