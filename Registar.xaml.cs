namespace LoginTeste;

public partial class Registar : ContentPage
{
	public Registar()
	{
		InitializeComponent();
	}

    async void TapGestureRecognizer_Tapped_Login(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
		await Shell.Current.GoToAsync("//SignIn");
    }
}
