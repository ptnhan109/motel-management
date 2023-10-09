using Motel.App.ViewModels;

namespace Motel.App;

public partial class Authenticate : ContentPage
{
	public Authenticate(LoginViewModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}